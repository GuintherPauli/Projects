#region License
//  Copyright 2004-2010 Castle Project - http:www.castleproject.org/
//  
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//  
//      http:www.apache.org/licenses/LICENSE-2.0
//  
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
// 
#endregion

namespace ICSharpCode.NRefactory.Parser.CSharp
{
	public static class Keywords
	{
		static readonly string[] keywordList = {
			"abstract",
			"as",
			"base",
			"bool",
			"break",
			"byte",
			"case",
			"catch",
			"char",
			"checked",
			"class",
			"const",
			"continue",
			"decimal",
			"default",
			"delegate",
			"do",
			"double",
			"else",
			"enum",
			"event",
			"explicit",
			"extern",
			"false",
			"finally",
			"fixed",
			"float",
			"for",
			"foreach",
			"goto",
			"if",
			"implicit",
			"in",
			"int",
			"interface",
			"internal",
			"is",
			"lock",
			"long",
			"namespace",
			"new",
			"null",
			"object",
			"operator",
			"out",
			"override",
			"params",
			"private",
			"protected",
			"public",
			"readonly",
			"ref",
			"return",
			"sbyte",
			"sealed",
			"short",
			"sizeof",
			"stackalloc",
			"static",
			"string",
			"struct",
			"switch",
			"this",
			"throw",
			"true",
			"try",
			"typeof",
			"uint",
			"ulong",
			"unchecked",
			"unsafe",
			"ushort",
			"using",
			"virtual",
			"void",
			"volatile",
			"while",
			"partial",
			"where",
			"get",
			"set",
			"add",
			"remove",
			"yield",
			"select",
			"group",
			"by",
			"into",
			"from",
			"ascending",
			"descending",
			"orderby",
			"let",
			"join",
			"on",
			"equals"
		};
		
		static LookupTable keywords = new LookupTable(true);
		
		static Keywords()
		{
			for (int i = 0; i < keywordList.Length; ++i) {
				keywords[keywordList[i]] = i + Tokens.Abstract;
			}
		}
		
		public static int GetToken(string keyword)
		{
			return keywords[keyword];
		}
		
		public static bool IsNonIdentifierKeyword(string word)
		{
			int token = GetToken(word);
			if (token < 0)
				return false;
			return !Tokens.IdentifierTokens[token];
		}
	}
}
