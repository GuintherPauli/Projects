// Copyright 2006-2007 Ken Egozi http://www.kenegozi.com/
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

namespace Castle.MonoRail.Views.AspView.Tests.HttpBasedIntegrationTests.LegacyRegressionTests
{
    using TestSupport;
    using NUnit.Framework;

    [TestFixture]
    public class ViewFiltersTestCases : BaseHttpBasedIntegrationTestFixture
    {
        [Test]
        public void LowerAndUpperCaseViewFiltersWorks()
        {
            #region expected
			string expected = @"Outside the filter

inside the lowercaseviewfilter - this text should be viewed in lower case

Outside the filter AGain

INSIDE THE UPPERCASEVIEWFILTER - THIS TEXT SHOULD BE VIEWED IN UPPER CASE

Finally - outside the filter";
            #endregion
            DoGet("ViewFilters/LowerAndUpperCaseViewfilters.rails");
            AssertReplyEqualTo(expected);
        }

		[Test]
		public void HtmlDecodeFilterWorks()
		{
			#region expected
			string expected = @"<html>";
			#endregion
			DoGet("ViewFilters/HtmlDecodeViewFilter.rails");
			AssertReplyEqualTo(expected);
		}
		[Test]
		public void HtmlEncodeFilterWorks()
		{
			#region expected
			string expected = @"&lt;html&gt;";
			#endregion
			DoGet("ViewFilters/HtmlEncodeViewFilter.rails");
			AssertReplyEqualTo(expected);
		}
		[Test]
        public void SingleLineCustomViewFilterWorks()
        {
            #region expected
			string expected = @"outside the filter
 first line second line 
outside the filter again - first line
outside the filter again - second line";
            #endregion
            DoGet("viewfilters/SingleLineCustomViewfilter.rails");
            AssertReplyEqualTo(expected);
        }
        [Test]
        public void MixViewFiltersWorks()
        {
            #region expected
			string expected = @"outside the filter
 first line THIS TEXT SHOULD BE IN UPPER CASE AND IN THE SAME LINE AS THE SURROUNDING TEXT second line 
outside the filter again - first line
outside the filter again - second line";
            #endregion
            DoGet("viewfilters/MixViewFilters.rails");
            AssertReplyEqualTo(expected);
        }
    }
}
