#region license
// Copyright 2008 Ken Egozi http://www.kenegozi.com/blog
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

namespace Castle.Tools.SQLQueryGenerator.Tests.GeneratedClasses
{
	public class Tables_Posts : Runtime.Model.Table.AbstractTable
	{
		public Tables_Posts(string alias) : base("dbo", "Posts", alias)
		{
			Id = new Tables_Posts_Id(this);
			BlogId = new Tables_Posts_BlogId(this);
			Title = new Tables_Posts_Title(this);
		}

		public Tables_Posts() : this(null)
		{
		}

		public readonly Tables_Posts_Id Id;
		public readonly Tables_Posts_BlogId BlogId;
		public readonly Tables_Posts_Title Title;

		public Tables_Posts As(string alias)
		{
			return new Tables_Posts(alias);
		}
	}
}
