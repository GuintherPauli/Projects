// Copyright 2007 Castle Project - http://www.castleproject.org/
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Threading;
using Castle.Components.Scheduler.JobStores;
using Castle.Core;
using Castle.Core.Logging;

namespace Castle.Components.Scheduler
{
    /// <summary>
    /// A simple default job scheduler based on a <see cref="IJobStore" />
    /// and <see cref="IJobRunner" />.
    /// The <see cref="IJobStore" /> provides persistence and sends 
    /// notification of jobs that require processing.
    /// The <see cref="IJobRunner" /> executes jobs asynchronously.
    /// </summary>
    [Singleton]
    public class DefaultScheduler : IScheduler
    {
        /// <summary>
        /// Gets the default error recovery delay in seconds.
        /// </summary>
        public const int DefaultErrorRecoveryDelayInSeconds = 30;

        private readonly object syncRoot = new object();

        private bool isDisposed;
        private string name;
        private IJobRunner jobRunner;
        private IJobStore jobStore;
        private ILogger logger;

        private IDisposable currentJobWatcher;
        private Thread currentJobWatcherThread;

        private int errorRecoveryDelayInSeconds;

        /// <summary>
        /// Creates a default scheduler.
        /// </summary>
        /// <param name="jobStore">The job store</param>
        /// <param name="jobRunner">The job runner</param>
        /// <exception cref="ArgumentNullException">Thrown if <paramref name="jobStore"/> or
        /// <paramref name="jobRunner"/> is null</exception>
        public DefaultScheduler(IJobStore jobStore, IJobRunner jobRunner)
        {
            if (jobStore == null)
                throw new ArgumentNullException("jobStore");
            if (jobRunner == null)
                throw new ArgumentNullException("jobRunner");

            this.jobStore = jobStore;
            this.jobRunner = jobRunner;

            logger = NullLogger.Instance;
            errorRecoveryDelayInSeconds = DefaultErrorRecoveryDelayInSeconds;

            name = GetDefaultName();
        }

        /// <summary>
        /// Gets or sets the logger used by the scheduler.
        /// </summary>
        /// <exception cref="ArgumentNullException">Thrown if <paramref name="value"/> is null</exception>
        public ILogger Logger
        {
            get { return logger; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");
                logger = value;
            }
        }

        /// <summary>
        /// Returns true if the scheduler has been disposed.
        /// </summary>
        public bool IsDisposed
        {
            get { return isDisposed; }
        }

        /// <summary>
        /// Returns true if the scheduler has been started and is running.
        /// </summary>
        public bool IsRunning
        {
            get { return currentJobWatcher != null; }
        }

        /// <summary>
        /// Gets or sets the name of the scheduler, never null.
        /// The name might not be unique.
        /// </summary>
        /// <remarks>
        /// If no name is set, a default name is used.
        /// </remarks>
        /// <exception cref="ArgumentNullException">Thrown if <paramref name="value"/> is null</exception>
        public string Name
        {
            get { return name; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");
                name = value;
            }
        }

        /// <summary>
        /// Gets or sets the number of seconds to wait after an error occurs before
        /// resuming normal operation.  This is intended to reduce the likelihood of
        /// repeated errors from locking up the system.
        /// </summary>
        /// <value>
        /// The default value is 30 seconds.
        /// </value>
        /// <todo>
        /// Replace with an exponential backoff mechanism.
        /// </todo>
        public int ErrorRecoveryDelayInSeconds
        {
            get { return errorRecoveryDelayInSeconds; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("value", "Error recovery delay must be non-negative.");
                errorRecoveryDelayInSeconds = value;
            }
        }

        public void Dispose()
        {
            if (!isDisposed)
            {
                Stop();

                isDisposed = true;
            }
        }

        public void Start()
        {
            lock (syncRoot)
            {
                ThrowIfDisposed();

                if (currentJobWatcher != null)
                    return;

                currentJobWatcher = jobStore.CreateJobWatcher(name);
                currentJobWatcherThread = new Thread(WatchTriggeredJobs);
                currentJobWatcherThread.IsBackground = true;
                currentJobWatcherThread.Name = String.Format(CultureInfo.CurrentCulture, "Job Watcher for '{0}'.", name);
                currentJobWatcherThread.Start(currentJobWatcher);
            }
        }

        public void Stop()
        {
            Thread threadToJoin;

            lock (syncRoot)
            {
                ThrowIfDisposed();

                if (currentJobWatcher == null)
                    return;

                // Causes the thread to shutdown when it can.
                // It will take care of resetting the state of the scheduler back to not running
                // when it finishes shutting down.  There is a possible race condition between Stop()
                // and Start() wherein if the scheduling is shutting down Start() is called before
                // it finishes stopping, the scheduler will still end up stopped in the end.
                // I think this is okay for now.  -- Jeff.
                currentJobWatcher.Dispose();
                threadToJoin = currentJobWatcherThread;
            }

            if (threadToJoin != null)
                threadToJoin.Join();
        }

        public JobDetails GetJobDetails(string jobName)
        {
            if (jobName == null)
                throw new ArgumentNullException("jobName");

            ThrowIfDisposed();

            return jobStore.GetJobDetails(jobName);
        }

        public bool CreateJob(JobSpec jobSpec, JobData jobData, CreateJobConflictAction conflictAction)
        {
            if (jobSpec == null)
                throw new ArgumentNullException("jobSpec");

            ThrowIfDisposed();

            return jobStore.CreateJob(jobSpec, jobData, DateTime.Now, conflictAction);
        }

        public bool DeleteJob(string jobName)
        {
            if (jobName == null)
                throw new ArgumentNullException("jobName");

            ThrowIfDisposed();

            return jobStore.DeleteJob(jobName);
        }

        private void WatchTriggeredJobs(object arg)
        {
            IJobWatcher jobWatcher = (IJobWatcher) arg;

            try
            {
                for (; ; )
                {
                    JobDetails jobDetails;
                    try
                    {
                        jobDetails = jobWatcher.GetNextJobToProcess();
                        if (jobDetails == null)
                            return; // watcher was disposed
                    }
                    catch (ObjectDisposedException ex)
                    {
                        // watcher was disposed not quite so nicely
                        logger.FatalFormat(ex, "The job store was disposed prematurely.  Stopping the scheduler.");
                        return;
                    }
                    catch (Exception ex)
                    {
                        logger.ErrorFormat(ex,
                            "The scheduled job watcher threw an exception.  Pausing for '{0}' seconds before resuming job processing.",
                            errorRecoveryDelayInSeconds);
                        Thread.Sleep(errorRecoveryDelayInSeconds * 1000);
                        continue;
                    }

                    try
                    {
                        ScheduleJob(jobDetails);
                    }
                    catch (Exception ex)
                    {
                        logger.ErrorFormat(ex,
                            "The scheduled job processor threw an exception.  Pausing for '{0}' seconds before resuming job processing.",
                            errorRecoveryDelayInSeconds);
                        Thread.Sleep(errorRecoveryDelayInSeconds * 1000);
                    }
                }
            }
            finally
            {
                // Put the scheduler back in the stopped state.
                lock (syncRoot)
                {
                    if (currentJobWatcher == jobWatcher)
                    {
                        currentJobWatcher = null;
                        currentJobWatcherThread = null;
                    }
                }

                try
                {
                    jobWatcher.Dispose();
                }
                catch (Exception ex)
                {
                    logger.WarnFormat(ex, "The job watcher threw an exception when disposed.  The exception will be ignored.");
                }
            }
        }

        private void ScheduleJob(JobDetails jobDetails)
        {
            DateTime timeBasis = DateTime.UtcNow;

            TriggerScheduleAction action = UpdateTrigger(timeBasis, jobDetails);
            PerformActionAndSaveChanges(timeBasis, jobDetails, action);
        }

        private TriggerScheduleAction UpdateTrigger(DateTime timeBasis, JobDetails jobDetails)
        {
            try
            {
                Trigger trigger = jobDetails.JobSpec.Trigger;

                TriggerScheduleAction action;
                switch (jobDetails.JobState)
                {
                    case JobState.Pending:
                        action = trigger.Schedule(TriggerScheduleCondition.FirstTime, timeBasis);
                        break;

                    case JobState.Triggered:
                        if (jobDetails.NextTriggerFireTime.HasValue)
                        {
                            DateTime nextScheduledTime = jobDetails.NextTriggerFireTime.Value;
                            TimeSpan difference = timeBasis - nextScheduledTime;

                            if (! jobDetails.NextTriggerMisfireThreshold.HasValue
                                || difference <= jobDetails.NextTriggerMisfireThreshold.Value)
                            {
                                action = trigger.Schedule(TriggerScheduleCondition.Fire, timeBasis);
                                break;
                            }
                        }
                        else
                        {
                            logger.WarnFormat("Job '{0}' was in the Triggered state but its NextTriggerFireTime "
                                + "property was null in violation of the scheduler's invariants.  "
                                + "Assuming that the trigger misfired.",
                                jobDetails.JobSpec.Name);
                        }

                        action = trigger.Schedule(TriggerScheduleCondition.Misfire, timeBasis);
                        break;

                    case JobState.Completed:
                        if (jobDetails.LastJobExecutionDetails != null)
                        {
                            if (!jobDetails.LastJobExecutionDetails.EndTime.HasValue)
                            {
                                logger.WarnFormat("Job '{0}' was in the Completed state but its EndTime property was null in violatoin of the scheduler's invariants.  "
                                    + "It has been set to the current time.", jobDetails.JobSpec.Name);
                                jobDetails.LastJobExecutionDetails.EndTime = timeBasis;
                            }

                            if (jobDetails.LastJobExecutionDetails.Succeeded)
                            {
                                action = trigger.Schedule(TriggerScheduleCondition.JobSucceeded, timeBasis);
                                break;
                            }
                        }
                        else
                        {
                            string completedInvariantViolationMessage = String.Format(CultureInfo.CurrentCulture,
                                "Job '{0}' was in the Completed state but its LastJobExecutionDetails property was null in violation of the scheduler's invariants.  "
                                + "Assuming that the job failed.", jobDetails.JobSpec.Name);

                            logger.Warn(completedInvariantViolationMessage);

                            jobDetails.LastJobExecutionDetails = new JobExecutionDetails(name, DateTime.MinValue);
                            jobDetails.LastJobExecutionDetails.Succeeded = false;
                            jobDetails.LastJobExecutionDetails.StatusMessage = completedInvariantViolationMessage;
                            jobDetails.LastJobExecutionDetails.EndTime = timeBasis;
                        }

                        action = trigger.Schedule(TriggerScheduleCondition.JobFailed, timeBasis);
                        break;

                    case JobState.Orphaned:
                        string orphanedMessage = String.Format(CultureInfo.CurrentCulture,
                            "Job '{0}' was orphaned by its scheduler.  It may have failed part way through execution.  "
                            + "Assuming that the job failed.",
                            jobDetails.JobSpec.Name);

                        if (jobDetails.LastJobExecutionDetails == null)
                        {
                            jobDetails.LastJobExecutionDetails = new JobExecutionDetails(name, DateTime.MinValue);
                            orphanedMessage += "  In addition, the job's LastJobExecutionDetails property was null in violation of the scheduler's invariants.";
                        }

                        logger.Warn(orphanedMessage);

                        jobDetails.LastJobExecutionDetails.Succeeded = false;
                        jobDetails.LastJobExecutionDetails.StatusMessage = orphanedMessage;
                        jobDetails.LastJobExecutionDetails.EndTime = timeBasis;

                        action = trigger.Schedule(TriggerScheduleCondition.JobFailed, timeBasis);
                        break;

                    default:
                        logger.WarnFormat("Job watcher returned job '{0}' which was in an unexpected job state '{1}'.  The trigger will be stopped.",
                            jobDetails.JobSpec.Name, jobDetails.JobState);
                        return TriggerScheduleAction.Stop;
                }

                jobDetails.NextTriggerFireTime = trigger.NextFireTime;
                jobDetails.NextTriggerMisfireThreshold = trigger.NextMisfireThreshold;
                return action;
            }
            catch (Exception ex)
            {
                logger.ErrorFormat(ex, "Trigger for job '{0}' threw an exception.  The trigger will be stopped.",
                    jobDetails.JobSpec.Name);
                return TriggerScheduleAction.Stop;
            }
        }

        private void PerformActionAndSaveChanges(DateTime timeBasis, JobDetails jobDetails, TriggerScheduleAction action)
        {
            try
            {
                switch (action)
                {
                    case TriggerScheduleAction.Skip:
                        jobDetails.JobState = JobState.Scheduled;
                        jobStore.SaveJobDetails(jobDetails);
                        return;

                    case TriggerScheduleAction.DeleteJob:
                        jobStore.DeleteJob(jobDetails.JobSpec.Name);
                        return;

                    case TriggerScheduleAction.ExecuteJob:
                        jobDetails.JobState = JobState.Running;
                        jobDetails.LastJobExecutionDetails = new JobExecutionDetails(name, timeBasis);
                        jobStore.SaveJobDetails(jobDetails);

                        BeginExecuteJob(jobDetails);
                        return;

                    case TriggerScheduleAction.Stop:
                        break;

                    default:
                        logger.WarnFormat("Trigger for job '{0}' returned an unexpected action '{1}'.  The trigger will be stopped.",
                            jobDetails.JobSpec.Name, action);
                        break;
                }

                jobDetails.JobState = JobState.Stopped;
                jobDetails.NextTriggerFireTime = null;
                jobDetails.NextTriggerMisfireThreshold = null;
                jobStore.SaveJobDetails(jobDetails);
            }
            catch (ConcurrentModificationException ex)
            {
                logger.DebugFormat(ex,
                    "Job '{0}' was concurrently modified by another scheduler instance so the changes made "
                    + "by this scheduler instance will be discarded.  This is normal behavior in a cluster.",
                    jobDetails.JobSpec.Name);
            }
        }

        private void BeginExecuteJob(JobDetails jobDetails)
        {
            ILogger jobLogger = logger.CreateChildLogger("Job: " + jobDetails.JobSpec.Name);
            JobExecutionContext context = new JobExecutionContext(this, jobLogger, jobDetails.JobSpec, jobDetails.JobData);
            try
            {
                jobLogger.InfoFormat("Job '{0}' started at {1}.",
                    jobDetails.JobSpec.Name, jobDetails.LastJobExecutionDetails.StartTime);

                JobExecuteAsyncState asyncState = new JobExecuteAsyncState(jobDetails, context);
                jobRunner.BeginExecute(context, EndExecuteJob, asyncState);
            }
            catch (Exception ex)
            {
                DateTime endTime = DateTime.UtcNow;

                jobLogger.ErrorFormat(ex, "Job '{0}' failed because the job runner could not start it.",
                    jobDetails.JobSpec.Name);

                jobDetails.LastJobExecutionDetails.Succeeded = false;
                jobDetails.LastJobExecutionDetails.EndTime = endTime;
                jobDetails.LastJobExecutionDetails.StatusMessage = String.Format(CultureInfo.CurrentCulture,
                    "Job runner failed to start the job due to an exception:\n{0}", ex);
                jobDetails.JobState = JobState.Completed;

                ScheduleJob(jobDetails);
            }
        }

        private void EndExecuteJob(IAsyncResult asyncResult)
        {
            JobExecuteAsyncState asyncState = (JobExecuteAsyncState)asyncResult.AsyncState;
            JobDetails jobDetails = asyncState.JobDetails;
            JobExecutionContext context = asyncState.Context;
            ILogger jobLogger = context.Logger;
            try
            {
                try
                {
                    bool succeeded = jobRunner.EndExecute(asyncResult);
                    DateTime endTime = DateTime.UtcNow;

                    jobDetails.LastJobExecutionDetails.Succeeded = succeeded;
                    jobDetails.LastJobExecutionDetails.EndTime = endTime;

                    if (succeeded)
                    {
                        jobLogger.InfoFormat("Job '{0}' completed successfully at {1}.",
                            jobDetails.JobSpec.Name, endTime);

                        jobDetails.LastJobExecutionDetails.StatusMessage = "Completed successfully.";
                    }
                    else
                    {
                        jobLogger.ErrorFormat("Job '{0}' completed with an error at {1}.",
                            jobDetails.JobSpec.Name, endTime);

                        jobDetails.LastJobExecutionDetails.StatusMessage = "Completed with an unspecified error.";
                    }

                    jobDetails.JobData = context.JobData;
                }
                catch (Exception ex)
                {
                    DateTime endTime = DateTime.UtcNow;

                    jobLogger.ErrorFormat(ex, "Job '{0}' failed with an exception at {1}.",
                        jobDetails.JobSpec.Name, endTime);

                    jobDetails.LastJobExecutionDetails.Succeeded = false;
                    jobDetails.LastJobExecutionDetails.EndTime = endTime;
                    jobDetails.LastJobExecutionDetails.StatusMessage = String.Format(CultureInfo.CurrentCulture,
                        "Job execution failed with an exception:\n{0}", ex);
                }

                jobDetails.JobState = JobState.Completed;

                ScheduleJob(jobDetails);
            }
            catch (Exception ex)
            {
                logger.FatalFormat(ex,
                    "A fatal exception occurred while finalizing the execution of job '{0}'.  "
                        + "The job's updated status may not have been saved to the job store.",
                    jobDetails.JobSpec.Name);
            }
        }

        private void ThrowIfDisposed()
        {
            if (isDisposed)
                throw new ObjectDisposedException(GetType().Name);
        }

        private static string GetDefaultName()
        {
            try
            {
                return String.Format(CultureInfo.CurrentCulture, "{0}/{1}, Scheduler #{2}",
                    Environment.MachineName,
                    Process.GetCurrentProcess().ProcessName,
                    Interlocked.Increment(ref instanceId));
            }
            catch (Exception)
            {
                return "Scheduler";
            }
        }
        private static int instanceId;

        private class JobExecuteAsyncState
        {
            public readonly JobDetails JobDetails;
            public readonly JobExecutionContext Context;

            public JobExecuteAsyncState(JobDetails jobDetails, JobExecutionContext context)
            {
                this.JobDetails = jobDetails;
                this.Context = context;
            }
        }
    }
}
