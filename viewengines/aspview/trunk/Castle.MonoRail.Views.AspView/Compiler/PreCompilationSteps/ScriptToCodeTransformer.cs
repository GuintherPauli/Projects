#region license
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
#endregion

using System.Text;
using System.Text.RegularExpressions;

namespace Castle.MonoRail.Views.AspView.Compiler.PreCompilationSteps
{
	public class ScriptToCodeTransformer
	{
		public string Transform(string mixed)
		{
			StringBuilder sb = new StringBuilder(mixed.Length);
			foreach (Match match in Internal.RegularExpressions.Script.Matches(mixed))
			{
				string markup = match.Groups["markup"].Value;
				string code = match.Groups["code"].Value.Trim();
				if (!string.IsNullOrEmpty(markup))
					AppendMarkup(sb, markup);
				if (!string.IsNullOrEmpty(code))
					AppendCode(sb, code);
			}

			return sb.ToString();
		}

		private static void AppendMarkup(StringBuilder sb, string markup)
		{
			markup = markup.Replace("\"", "\"\"");
			sb.AppendFormat("Output(@\"{0}\");", markup)
				.AppendLine();
		}

		private static void AppendCode(StringBuilder sb, string code)
		{
			if (code.StartsWith("="))
				code = "Output(" + code.Substring(1) + ");";
			if (code.StartsWith("#"))
				code = "OutputEncoded(" + code.Substring(1) + ");";
			sb.AppendLine(code);
		}

	}
}
