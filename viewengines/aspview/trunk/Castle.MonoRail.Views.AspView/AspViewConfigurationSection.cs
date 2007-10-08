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

namespace Castle.MonoRail.Views.AspView
{
	using System;
	using System.Collections.Generic;
	using System.Configuration;
	using System.Xml;

	public class AspViewConfigurationSection : IConfigurationSectionHandler
	{
		#region IConfigurationSectionHandler Members

		public object Create(object parent, object configContext, XmlNode section)
		{
			if (section == null)
				throw new ApplicationException("AspView config section is missing or not found");

			bool? debug = null;
			bool? inMemory = null;
			bool? autoRecompilation = null;
			string temporarySourceFilesDirectory = null;
			bool? saveFiles = null;
			List<ReferencedAssembly> references = new List<ReferencedAssembly>();
			string actionExtension = null;

			if (section.Attributes["debug"] != null)
				debug = bool.Parse(section.Attributes["debug"].Value);
			if (section.Attributes["inMemory"] != null)
				inMemory = bool.Parse(section.Attributes["inMemory"].Value);
			if (section.Attributes["autoRecompilation"] != null)
				autoRecompilation = bool.Parse(section.Attributes["autoRecompilation"].Value);
			if (section.Attributes["temporarySourceFilesDirectory"] != null)
				temporarySourceFilesDirectory = section.Attributes["temporarySourceFilesDirectory"].Value;
			if (section.Attributes["saveFiles"] != null)
				saveFiles = bool.Parse(section.Attributes["saveFiles"].Value);
			foreach (XmlNode reference in section.SelectNodes("reference"))
			{
				string name = reference.Attributes["assembly"].Value;
				ReferencedAssembly.AssemblySource source = ReferencedAssembly.AssemblySource.BinDirectory;
				if (reference.Attributes["isFromGac"] != null)
					if (reference.Attributes["isFromGac"].Value.Equals("true", StringComparison.InvariantCultureIgnoreCase))
						source = ReferencedAssembly.AssemblySource.GlobalAssemblyCache;
				references.Add(new ReferencedAssembly(name, source));
			}

			AspViewCompilerOptions compilerOptions = new AspViewCompilerOptions(
				debug, inMemory, autoRecompilation, temporarySourceFilesDirectory, saveFiles, references);

			if (section.Attributes["actionExtension"] != null)
			{
				actionExtension = section.Attributes["actionExtension"].Value;
				if (actionExtension[0] != '.')
					actionExtension = "." + actionExtension;
			}

			AspViewEngineOptions options = new AspViewEngineOptions(actionExtension, compilerOptions);

			return options;
		}

		#endregion
	}
}
