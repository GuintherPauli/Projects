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

namespace Castle.MonoRail.Views.AspView.Tests.Compiler.PreCompilationSteps
{
	using AspView.Compiler.PreCompilationSteps;
	using Xunit;

	
	public class DetermineBaseClassStepTestFixture : AbstractPreCompilationStepTestFixture
	{
		protected override void CreateStep()
		{
			step = new DetermineBaseClassStep();
		}

		private static void AssertPageDirectiveHasBeenRemoved(string viewSource)
		{
			if (Internal.RegularExpressions.PageDirective.IsMatch(viewSource))
				throw new AssertException("Page directive was not removed from view source");
		}

		[Fact]
		public void Process_WhenInheritsIsMissing_SetsDefault()
		{
			file.RenderBody = @"
<%@ Page Language=""C#"" %>
view content";
			step.Process(file);

			Assert.Equal(DetermineBaseClassStep.DefaultBaseClassName, file.BaseClassName);

			AssertPageDirectiveHasBeenRemoved(file.RenderBody);
		}

		[Fact]
		public void Process_WhenUsingDefault_SetsDefault()
		{
			file.RenderBody = @"
<%@ Page Language=""C#"" Inherits=""Castle.MonoRail.Views.AspView.ViewAtDesignTime"" %>
view content";
			step.Process(file);

			Assert.Equal(DetermineBaseClassStep.DefaultBaseClassName, file.BaseClassName);

			AssertPageDirectiveHasBeenRemoved(file.RenderBody);
		}

		[Fact]
		public void Process_WhenUsingDefaultAndTypedView_SetsDefaultAndView()
		{
			file.RenderBody = @"
<%@ Page Language=""C#"" Inherits=""Castle.MonoRail.Views.AspView.ViewAtDesignTime<IView>"" %>
view content";
			step.Process(file);

			Assert.Equal(DetermineBaseClassStep.DefaultBaseClassName + "<IView>", file.BaseClassName);
			Assert.Equal("IView", file.TypedViewName);

			AssertPageDirectiveHasBeenRemoved(file.RenderBody);
		}

		[Fact]
		public void Process_WhenUsingClassName_SetsClassName()
		{
			file.RenderBody = @"
<%@ Page Language=""C#"" Inherits=""SomeClass"" %>
view content";
			step.Process(file);

			Assert.Equal("SomeClass", file.BaseClassName);

			AssertPageDirectiveHasBeenRemoved(file.RenderBody);
		}

		[Fact]
		public void Process_WhenUsingClassNameAndTypedView_SetsClassNameAndView()
		{
			file.RenderBody = @"
<%@ Page Language=""C#"" Inherits=""SomeClass<IView>"" %>
view content";
			step.Process(file);

			Assert.Equal("SomeClass<IView>", file.BaseClassName);
			Assert.Equal("IView", file.TypedViewName);

			AssertPageDirectiveHasBeenRemoved(file.RenderBody);
		}

		[Fact]
		public void Process_WhenUsingClassNameAtDesignTime_SetsClassName()
		{
			file.RenderBody = @"
<%@ Page Language=""C#"" Inherits=""SomeClassAtDesignTime"" %>
view content";
			step.Process(file);

			Assert.Equal("SomeClass", file.BaseClassName);

			AssertPageDirectiveHasBeenRemoved(file.RenderBody);
		}

		[Fact]
		public void Process_WhenUsingClassNameAtDesignTimeAndTypedView_SetsClassNameAndView()
		{
			file.RenderBody = @"
<%@ Page Language=""C#"" Inherits=""SomeClassAtDesignTime<IView>"" %>
view content";
			step.Process(file);

			Assert.Equal("SomeClass<IView>", file.BaseClassName);
			Assert.Equal("IView", file.TypedViewName);

			AssertPageDirectiveHasBeenRemoved(file.RenderBody);
		}		

	}
}
