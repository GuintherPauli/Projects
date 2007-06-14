// Copyright 2004-2005 Castle Project - http://www.castleproject.org/
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


namespace Castle.MonoRail.Views.AspView.Tests
{
    using System;
    using Castle.MonoRail.TestSupport;
    using NUnit.Framework;
    using System.Diagnostics;

    [TestFixture]
    public class PropertiesTestCases : AbstractMRTestCase
    {
        [Test]
        public void DefaultValuesAreParsedAndsetCorrectly()
        {
            #region expected
            string expected = @"default1True";
            #endregion
            DoGet("home/DefaultValues.rails");
            AssertReplyEqualTo(expected);
        }

		[Test]
		public void NullableValueTypesWithDefaultValue()
		{
			#region expected
			string expected = @"0";
			#endregion
			DoGet("home/NullableValueTypesWithDefaultValue.rails");
			AssertReplyEqualTo(expected);
		}
    }
}
