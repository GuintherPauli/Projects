// Copyright 2007 Jonathon Rossi - http://www.jonorossi.com/
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

namespace Castle.VisualStudio.NVelocityLanguageService
{
    using System;
    using System.Diagnostics;
    using System.Drawing;
    using System.Runtime.InteropServices;
    using System.Threading;
    using System.Windows.Forms;
    using Castle.NVelocity;
    using Castle.NVelocity.Ast;
    using Castle.VisualStudio.MonoRailIntelliSenseProvider;
    using Microsoft.VisualStudio;
    using Microsoft.VisualStudio.Package;
    using Microsoft.VisualStudio.TextManager.Interop;

    [Guid(NVelocityConstants.LanguageServiceGuidString)]
    public class NVelocityLanguage : LanguageService
    {
        private LanguagePreferences preferences;

        private readonly ColorableItem[] _colorableItems;

        public NVelocityLanguage()
        {
            #region Colorable Items

            _colorableItems = new ColorableItem[] {
                // NVText
                new ColorableItem("NVelocity � Text", "NVelocity � Text", COLORINDEX.CI_SYSPLAINTEXT_FG, COLORINDEX.CI_USERTEXT_BK, Color.Empty, Color.Empty, FONTFLAGS.FF_DEFAULT),
                // NVKeyword
                new ColorableItem("NVelocity � Keyword", "NVelocity � Keyword", COLORINDEX.CI_BLUE, COLORINDEX.CI_USERTEXT_BK, Color.Empty, Color.Empty, FONTFLAGS.FF_BOLD),
                // NVComment
                new ColorableItem("NVelocity � Comment", "NVelocity � Comment", COLORINDEX.CI_DARKGREEN, COLORINDEX.CI_USERTEXT_BK, Color.Empty, Color.Empty, FONTFLAGS.FF_DEFAULT),
                // NVIdentifier
                new ColorableItem("NVelocity � Identifier", "NVelocity � Identifier", COLORINDEX.CI_PURPLE, COLORINDEX.CI_USERTEXT_BK, Color.Empty, Color.Empty, FONTFLAGS.FF_DEFAULT),
                // NVString
                new ColorableItem("NVelocity � String", "NVelocity � String", COLORINDEX.CI_MAROON, COLORINDEX.CI_USERTEXT_BK, Color.Empty, Color.Empty, FONTFLAGS.FF_DEFAULT),
                // NVNumber
                new ColorableItem("NVelocity � Number", "NVelocity � Number", COLORINDEX.CI_SYSPLAINTEXT_FG, COLORINDEX.CI_USERTEXT_BK, Color.Empty, Color.Empty, FONTFLAGS.FF_DEFAULT),
                // NVDirective
                new ColorableItem("NVelocity � Directive", "NVelocity � Directive", COLORINDEX.CI_BLUE, COLORINDEX.CI_USERTEXT_BK, Color.Empty, Color.Empty, FONTFLAGS.FF_BOLD),
                // NVOperator
                new ColorableItem("NVelocity � Operator", "NVelocity � Operator", COLORINDEX.CI_SYSPLAINTEXT_FG, COLORINDEX.CI_USERTEXT_BK, Color.Empty, Color.Empty, FONTFLAGS.FF_DEFAULT),
                // NVBracket
                new ColorableItem("NVelocity � Bracket", "NVelocity � Bracket", COLORINDEX.CI_SYSPLAINTEXT_FG, COLORINDEX.CI_USERTEXT_BK, Color.Empty, Color.Empty, FONTFLAGS.FF_DEFAULT),
                // NVDictionaryDelimiter
                new ColorableItem("NVelocity � Dictionary Delimiter", "NVelocity � Dictionary Delimiter", COLORINDEX.CI_PURPLE, COLORINDEX.CI_USERTEXT_BK, Color.Empty, Color.Empty, FONTFLAGS.FF_DEFAULT),
                // NVDictionaryKey
                new ColorableItem("NVelocity � Dictionary Key", "NVelocity � Dictionary Key", COLORINDEX.CI_RED, COLORINDEX.CI_USERTEXT_BK, Color.Empty, Color.Empty, FONTFLAGS.FF_DEFAULT),
                // NVDictionaryEquals
                new ColorableItem("NVelocity � Dictionary Equals", "NVelocity � Dictionary Equals", COLORINDEX.CI_BLUE, COLORINDEX.CI_USERTEXT_BK, Color.Empty, Color.Empty, FONTFLAGS.FF_DEFAULT),
                // XmlText
                new ColorableItem("NVelocity � XML Text", "NVelocity � XML Text", COLORINDEX.CI_SYSPLAINTEXT_FG, COLORINDEX.CI_USERTEXT_BK, Color.Empty, Color.Empty, FONTFLAGS.FF_DEFAULT),
                // XmlComment
                new ColorableItem("NVelocity � XML Comment", "NVelocity � XML Comment", COLORINDEX.CI_DARKGREEN, COLORINDEX.CI_USERTEXT_BK, Color.Empty, Color.Empty, FONTFLAGS.FF_DEFAULT),
                // XmlTagName
                new ColorableItem("NVelocity � XML Tag Name", "NVelocity � XML Tag Name", COLORINDEX.CI_MAROON, COLORINDEX.CI_USERTEXT_BK, Color.Empty, Color.Empty, FONTFLAGS.FF_DEFAULT),
                // XmlAttributeName
                new ColorableItem("NVelocity � XML Attribute Name", "NVelocity � XML Attribute Name", COLORINDEX.CI_RED, COLORINDEX.CI_USERTEXT_BK, Color.Empty, Color.Empty, FONTFLAGS.FF_DEFAULT),
                // XmlAttributeValue
                new ColorableItem("NVelocity � XML Attribute Value", "NVelocity � XML Attribute Value", COLORINDEX.CI_BLUE, COLORINDEX.CI_USERTEXT_BK, Color.Empty, Color.Empty, FONTFLAGS.FF_DEFAULT),
                // XmlTagDelimiter
                new ColorableItem("NVelocity � XML Tag Delimiter", "NVelocity � XML Tag Delimiter", COLORINDEX.CI_BLUE, COLORINDEX.CI_USERTEXT_BK, Color.Empty, Color.Empty, FONTFLAGS.FF_DEFAULT),
                // XmlOperator
                new ColorableItem("NVelocity � XML Operator", "NVelocity � XML Operator", COLORINDEX.CI_BLUE, COLORINDEX.CI_USERTEXT_BK, Color.Empty, Color.Empty, FONTFLAGS.FF_DEFAULT),
                // XmlEntity
                new ColorableItem("NVelocity � XML Entity", "NVelocity � XML Entity", COLORINDEX.CI_RED, COLORINDEX.CI_USERTEXT_BK, Color.Empty, Color.Empty, FONTFLAGS.FF_DEFAULT),
                // XmlCDataSection
                new ColorableItem("NVelocity � XML CData Section", "NVelocity � XML CData Section", COLORINDEX.CI_DARKGRAY, COLORINDEX.CI_USERTEXT_BK, Color.Empty, Color.Empty, FONTFLAGS.FF_DEFAULT)
                // XmlProcessingInstruction
                // ===== not done
            };
            #endregion
        }

        public override void Dispose()
        {
            try
            {
                // Dispose the preferences
                if (preferences != null)
                {
                    preferences.Dispose();
                    preferences = null;
                }
            }
            finally
            {
                base.Dispose();
            }
        }

        public override LanguagePreferences GetLanguagePreferences()
        {
            if (preferences == null)
            {
                preferences = new LanguagePreferences(Site, typeof(NVelocityLanguage).GUID, Name);
                preferences.Init();
                preferences.LineNumbers = true;
                preferences.Apply();
            }
            return preferences;
        }

        public override Source CreateSource(IVsTextLines buffer)
        {
            return new Source(this, buffer, GetColorizer(buffer));
        }

        public override IScanner GetScanner(IVsTextLines buffer)
        {
            // Return a new scanner for every file because Visual Studio calls this method
            // for every file that is opened.
            return new NVelocityScanner();
        }

        public override string Name
        {
            get { return "NVelocity"; }
        }

        public override void OnIdle(bool periodic)
        {
            Source src = GetSource(LastActiveTextView);
            if (src != null && src.LastParseTime == Int32.MaxValue)
            {
                src.LastParseTime = 0;
            }
            base.OnIdle(periodic);
        }

        private TemplateNode _templateNode;

        public override AuthoringScope ParseSource(ParseRequest req)
        {
            if (req == null)
            {
                throw new ArgumentNullException("req");
            }

            Trace.WriteLine(string.Format("NVelocityLanguage.ParseSource(). Reason:{0}", req.Reason));

            if (req.Reason == ParseReason.Check ||
                req.Reason == ParseReason.DisplayMemberList ||
                req.Reason == ParseReason.MemberSelect ||
                req.Reason == ParseReason.MethodTip)
            {
                Position finalPosition = null;

                Thread thread = new Thread(new ThreadStart(delegate
                {
                    ScannerOptions scannerOptions = new ScannerOptions();
                    scannerOptions.EnableIntelliSenseTriggerTokens = true;

                    Scanner scanner = new Scanner();

                    try
                    {
                        scanner.Options = scannerOptions;
                        scanner.SetSource(req.Text);

                        Parser parser = new Parser(scanner);

                        _templateNode = parser.ParseTemplate();

                        // Prepare the template node so that all the helpers are available
                        PrepareTemplateNode(req.FileName);

                        _templateNode.DoSemanticChecks(parser.Errors);

                        for (int i = 0; i < parser.Errors.Count; i++)
                        {
                            Error error = parser.Errors[i];

                            TextSpan textSpan = new TextSpan();
                            textSpan.iStartLine = error.Position.StartLine - 1;
                            textSpan.iStartIndex = error.Position.StartPos;
                            textSpan.iEndLine = error.Position.EndLine - 1;
                            textSpan.iEndIndex = error.Position.EndPos;

                            Severity severity = Severity.Fatal;
                            if (error.Severity == ErrorSeverity.Error)
                                severity = Severity.Error;
                            else if (error.Severity == ErrorSeverity.Warning)
                                severity = Severity.Warning;
                            else if (error.Severity == ErrorSeverity.Message)
                                severity = Severity.Hint;

                            req.Sink.AddError(req.FileName, error.Description, textSpan, severity);
                        }
                    }
                    catch (ScannerError se)
                    {
                        req.Sink.AddError(req.FileName, se.Message, new TextSpan(), Severity.Error);
                    }
                    catch (ThreadAbortException)
                    {
                        // Do nothing
                    }
                    catch (Exception ex)
                    {
                        req.Sink.AddError(req.FileName, "FATAL: " + ex, new TextSpan(), Severity.Error);
                    }
                    finally
                    {
                        finalPosition = scanner.CurrentPos;
                    }
                }));
                thread.Start();

                int timeout = 0;
                while (timeout < 1000 && thread.IsAlive)
                {
                    Thread.Sleep(50);
                    timeout += 50;
                }

                if (thread.IsAlive)
                {
                    thread.Abort();

                    thread.Join(100);

                    TextSpan textSpan = new TextSpan();
                    if (finalPosition != null)
                    {
                        textSpan.iStartLine = finalPosition.StartLine - 1;
                        textSpan.iStartIndex = finalPosition.StartPos;
                        textSpan.iEndLine = finalPosition.EndLine - 1;
                        textSpan.iEndIndex = finalPosition.EndPos;
                    }

                    req.Sink.AddError(req.FileName,
                        "Castle Visual Studio Integration has detected that the Castle NVelocity " +
                        "parser running in the background has stopped responding. The parser's current action " +
                        "has been terminated.", textSpan, Severity.Fatal);
                }
            }
            else
            {
                //MessageBox.Show("Unparsed ParseReason: " + req.Reason);
            }
            
            if (req.Reason == ParseReason.MethodTip)
            {
                TextSpan textSpan = new TextSpan();
                textSpan.iStartLine = req.Line;
                textSpan.iStartIndex = req.Col - 1;
                textSpan.iEndLine = req.Line;
                textSpan.iEndIndex = req.Col;

                req.Sink.StartName(textSpan, "");
                req.Sink.StartParameters(textSpan);

                Trace.WriteLine("MethodTip at line " + req.Line + " col " + req.Col);
            }

            NVelocityAuthoringScope scope = new NVelocityAuthoringScope(_templateNode, req.FileName);

            //if (req.Sink.BraceMatching && req.Col > 30)
            //{
            //    TextSpan startBrace = new TextSpan();
            //    startBrace.iStartLine = req.Line;
            //    startBrace.iStartIndex = 20;
            //    startBrace.iEndLine = req.Line;
            //    startBrace.iEndIndex = 21;

            //    TextSpan endBrace = new TextSpan();
            //    endBrace.iStartLine = req.Line;
            //    endBrace.iStartIndex = req.Col - 1;
            //    endBrace.iEndLine = req.Line;
            //    endBrace.iEndIndex = req.Col;

            //    req.Sink.MatchPair(startBrace, endBrace, 0);
            //}

            return scope;
        }

        private void PrepareTemplateNode(string fileName)
        {
            string binDirectory = IntelliSenseProvider.FindBinaryDirectory(fileName);
            if (string.IsNullOrEmpty(binDirectory))
            {
                return;
            }
            
            IntelliSenseProvider intelliSenseProvider = new IntelliSenseProvider(binDirectory);

            // Get all available helpers and add them to the template node
            foreach (NVClassNode classNode in intelliSenseProvider.GetHelpers())
            {
                _templateNode.AddClass(classNode);

                // Add a localnode/variable to the scope for each helper
                string varName = classNode.Name;
                if (classNode.Name.EndsWith("Helper"))
                {
                    varName = varName.Substring(0, varName.Length - 6);
                }
                _templateNode.AddVariable(new NVLocalNode(varName, classNode));
            }

            // Get all available view components and add them to the template node
            foreach (NVClassNode viewComponentClassNode in intelliSenseProvider.GetViewComponents())
            {
                _templateNode.AddClass(viewComponentClassNode);
            }
        }

        public override int GetItemCount(out int count)
        {
            count = _colorableItems.Length;
            return VSConstants.S_OK;
        }

        public override int GetColorableItem(int index, out IVsColorableItem item)
        {
            if (index < 1 || index > _colorableItems.Length)
            {
                item = null;
                return VSConstants.S_FALSE;
            }
            item = _colorableItems[index - 1];
            return VSConstants.S_OK;
        }
    }
}