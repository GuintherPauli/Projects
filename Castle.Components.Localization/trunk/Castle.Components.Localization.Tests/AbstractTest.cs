
#region License

// Copyright 2004-2007 Castle Project - http://www.castleproject.org/
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
// See the License for the specific culture governing permissions and
// limitations under the License.

#endregion License

namespace Castle.Components.Localization.Tests
{
	#region Using Directives

	using System;

	using NUnit.Framework;

	#endregion Using Directives

	public abstract class AbstractTest
	{

		#region�Public�Methods�

		[TearDown]
		public virtual void Drop()
		{
		}

		[SetUp]
		public virtual void Init()
		{
		}

		#endregion�Public�Methods�

	}
}
