// Copyright 2004-2009 Castle Project - http://www.castleproject.org/
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

namespace SolutionTransform
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text.RegularExpressions;

	public class StandardFilters
	{
		public static Func<SolutionProject, bool> DontFilter()
		{
			return project => true;
		}

		public static Func<SolutionProject, bool> RegexFilter(IEnumerable patterns)
		{
			return RegexFilter(patterns.Cast<string>());
		}
		public static Func<SolutionProject, bool> RegexFilter(IEnumerable<string> patterns)
		{
			return project => {
								  if (project.IsFolder) {
									  return true;
								  }
								  foreach (var validProject in patterns) {
									  if (Regex.IsMatch(project.Name, Regex.Escape(validProject), RegexOptions.IgnoreCase)) {
										  return true;
									  }
								  }
								  return false;
			};
		}
	}
}
