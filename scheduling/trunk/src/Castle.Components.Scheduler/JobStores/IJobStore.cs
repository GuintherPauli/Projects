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
using System.Text;

namespace Castle.Components.Scheduler.JobStores
{
    /// <summary>
    /// A job store provides a persistence mechanism for jobs.
    /// </summary>
    public interface IJobStore : IDisposable
    {
        /// <summary>
        /// Gets a job watcher for the job store.
        /// </summary>
        /// <returns>The job watcher</returns>
        /// <param name="schedulerName">The name of the scheduler that is watching the job store</param>
        /// <exception cref="ArgumentNullException">Thrown if <paramref name="schedulerName"/> is null</exception>
        /// <exception cref="ObjectDisposedException">Thrown if the job store has been disposed</exception>
        IJobWatcher CreateJobWatcher(string schedulerName);

        /// <summary>
        /// Gets the details of the job with the specified name.
        /// </summary>
        /// <param name="jobName">The name of the job</param>
        /// <returns>The job details, or null if not found</returns>
        /// <exception cref="ArgumentNullException">Thrown if <paramref name="jobName"/> is null</exception>
        /// <exception cref="SchedulerException">Thrown if an error occurs</exception>
        /// <exception cref="ObjectDisposedException">Thrown if the job store has been disposed</exception>
        JobDetails GetJobDetails(string jobName);

        /// <summary>
        /// SAves the job details details of the job.
        /// </summary>
        /// <param name="jobDetails">The job details to save</param>
        /// <exception cref="ArgumentNullException">Thrown if <paramref name="jobDetails"/> is null</exception>
        /// <exception cref="ConcurrentModificationException">Thrown if another thread or scheduler instance
        /// has concurrently modified the job in such fashion that the
        /// job details could not be saved (an implementation may track this information by
        /// augmenting its job details with a Version token)</exception>
        /// <exception cref="SchedulerException">Thrown if an error occurs</exception>
        /// <exception cref="ObjectDisposedException">Thrown if the job store has been disposed</exception>
        void SaveJobDetails(JobDetails jobDetails);

        /// <summary>
        /// Creates a job.
        /// </summary>
        /// <param name="jobSpec">The job specification</param>
        /// <param name="jobData">The initial job data, or null if none</param>
        /// <param name="creationTime">The creation time to record</param>
        /// <param name="conflictAction">The action to take if a job with the
        /// same name already exists</param>
        /// <returns>True if the job was created or updated, false if a conflict occurred
        /// and no changes were made</returns>
        /// <exception cref="ArgumentNullException">Thrown if <paramref name="jobSpec"/> is null</exception>
        /// <exception cref="SchedulerException">Thrown if an error occurs</exception>
        /// <exception cref="ObjectDisposedException">Thrown if the job store has been disposed</exception>
        bool CreateJob(JobSpec jobSpec, JobData jobData, DateTime creationTime, CreateJobConflictAction conflictAction);

        /// <summary>
        /// Deletes the job with the specified name.
        /// </summary>
        /// <param name="jobName">The name of the job to delete</param>
        /// <returns>True if a job was actually deleted, false if no such job was found</returns>
        /// <exception cref="ArgumentNullException">Thrown if <paramref name="jobName"/> is null</exception>
        /// <exception cref="SchedulerException">Thrown if an error occurs</exception>
        /// <exception cref="ObjectDisposedException">Thrown if the job store has been disposed</exception>
        bool DeleteJob(string jobName);
    }
}
