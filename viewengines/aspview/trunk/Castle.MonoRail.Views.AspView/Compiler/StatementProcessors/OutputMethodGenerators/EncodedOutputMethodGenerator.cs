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

namespace Castle.MonoRail.Views.AspView.Compiler.StatementProcessors.OutputMethodGenerators
{
	using System.Text;

	public class EncodedOutputMethodGenerator : IOutputMethodGenerator
	{
		public string GenerateFrom(string content)
		{
			return "OutputEncoded(" + AddNullCheck(content) + ");";
		}

		static string AddNullCheck(string input)
		{
			if (string.IsNullOrEmpty(input))
			{
				return input;
			}

			string[] parts = input.Split('.');
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < parts.Length; i++)
			{
				string part = string.Join(".", parts, 0, i + 1);
				if (part.EndsWith("]"))
				{
					// we need to add null checking on the collection
					sb.AppendFormat("({0} == null) ? string.Empty : ", part.Substring(0, part.LastIndexOf("[")));
				}
				sb.AppendFormat("({0} == null) ? string.Empty : ", part);
			}
			sb.Append(input + ".ToString()");

			return sb.ToString();
		}
	}
}