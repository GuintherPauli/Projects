﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using NUnit.Framework;

namespace SolutionTransform.Tests {
    [TestFixture]
    public class TargetTests {
        string iocTests = @"
<Project DefaultTargets=""Build"" xmlns=""http://schemas.microsoft.com/developer/msbuild/2003"" ToolsVersion=""3.5"">
  <PropertyGroup>
    <ProjectType>Local</ProjectType>
    <ProductVersion>9.0.30729</ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{CB3A30A6-56D4-4F4F-9AEF-DA55E1FF6D74}</ProjectGuid>
    <Configuration Condition="" '$(Configuration)' == '' "">Debug</Configuration>
    <Platform Condition="" '$(Platform)' == '' "">AnyCPU</Platform>
    <ApplicationIcon>
    </ApplicationIcon>
    <AssemblyKeyContainerName>
    </AssemblyKeyContainerName>
    <AssemblyName>Castle.Windsor.Tests</AssemblyName>
    <AssemblyOriginatorKeyFile>
    </AssemblyOriginatorKeyFile>
    <DefaultClientScript>JScript</DefaultClientScript>
    <DefaultHTMLPageLayout>Grid</DefaultHTMLPageLayout>
    <DefaultTargetSchema>IE50</DefaultTargetSchema>
    <DelaySign>false</DelaySign>
    <OutputType>Library</OutputType>
    <RootNamespace>Castle.Windsor.Tests</RootNamespace>
    <RunPostBuildEvent>OnBuildSuccess</RunPostBuildEvent>
    <StartupObject>
    </StartupObject>
    <FileUpgradeFlags>
    </FileUpgradeFlags>
    <UpgradeBackupLocation>
    </UpgradeBackupLocation>
    <OldToolsVersion>2.0</OldToolsVersion>
    <PublishUrl>http://localhost/Castle.Windsor.Tests/</PublishUrl>
    <Install>true</Install>
    <InstallFrom>Web</InstallFrom>
    <UpdateEnabled>true</UpdateEnabled>
    <UpdateMode>Foreground</UpdateMode>
    <UpdateInterval>7</UpdateInterval>
    <UpdateIntervalUnits>Days</UpdateIntervalUnits>
    <UpdatePeriodically>false</UpdatePeriodically>
    <UpdateRequired>false</UpdateRequired>
    <MapFileExtensions>true</MapFileExtensions>
    <ApplicationRevision>0</ApplicationRevision>
    <ApplicationVersion>1.0.0.%2a</ApplicationVersion>
    <IsWebBootstrapper>true</IsWebBootstrapper>
    <UseApplicationTrust>false</UseApplicationTrust>
    <BootstrapperEnabled>true</BootstrapperEnabled>
    <TargetFrameworkVersion>v3.5</TargetFrameworkVersion>
  </PropertyGroup>
  <PropertyGroup Condition="" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' "">
    <OutputPath>..\bin\</OutputPath>
    <AllowUnsafeBlocks>false</AllowUnsafeBlocks>
    <BaseAddress>285212672</BaseAddress>
    <CheckForOverflowUnderflow>false</CheckForOverflowUnderflow>
    <ConfigurationOverrideFile>
    </ConfigurationOverrideFile>
    <DefineConstants>TRACE;DEBUG</DefineConstants>
    <DocumentationFile>
    </DocumentationFile>
    <DebugSymbols>true</DebugSymbols>
    <FileAlignment>4096</FileAlignment>
    <NoStdLib>false</NoStdLib>
    <NoWarn>
    </NoWarn>
    <Optimize>false</Optimize>
    <RegisterForComInterop>false</RegisterForComInterop>
    <RemoveIntegerChecks>false</RemoveIntegerChecks>
    <TreatWarningsAsErrors>true</TreatWarningsAsErrors>
    <WarningLevel>4</WarningLevel>
    <DebugType>full</DebugType>
    <ErrorReport>prompt</ErrorReport>
    <UseVSHostingProcess>false</UseVSHostingProcess>
  </PropertyGroup>
  <PropertyGroup Condition="" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' "">
    <OutputPath>bin\Release\</OutputPath>
    <AllowUnsafeBlocks>false</AllowUnsafeBlocks>
    <BaseAddress>285212672</BaseAddress>
    <CheckForOverflowUnderflow>false</CheckForOverflowUnderflow>
    <ConfigurationOverrideFile>
    </ConfigurationOverrideFile>
    <DefineConstants>TRACE</DefineConstants>
    <DocumentationFile>
    </DocumentationFile>
    <DebugSymbols>false</DebugSymbols>
    <FileAlignment>4096</FileAlignment>
    <NoStdLib>false</NoStdLib>
    <NoWarn>
    </NoWarn>
    <Optimize>true</Optimize>
    <RegisterForComInterop>false</RegisterForComInterop>
    <RemoveIntegerChecks>false</RemoveIntegerChecks>
    <TreatWarningsAsErrors>true</TreatWarningsAsErrors>
    <WarningLevel>4</WarningLevel>
    <DebugType>none</DebugType>
    <ErrorReport>prompt</ErrorReport>
    <UseVSHostingProcess>true</UseVSHostingProcess>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include=""Castle.Core, Version=1.2.0.0, Culture=neutral, PublicKeyToken=407dd0808d44fbdc, processorArchitecture=MSIL"">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>..\..\lib\net-3.5\Castle.Core.dll</HintPath>
    </Reference>
    <Reference Include=""Castle.DynamicProxy2, Version=2.2.0.0, Culture=neutral, PublicKeyToken=407dd0808d44fbdc, processorArchitecture=MSIL"">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>..\..\lib\net-3.5\Castle.DynamicProxy2.dll</HintPath>
    </Reference>
    <Reference Include=""nunit.framework, Version=2.5.0.9122, Culture=neutral, PublicKeyToken=96d09a1eb7f44a77, processorArchitecture=MSIL"">
      <SpecificVersion>False</SpecificVersion>
      <HintPath>..\..\lib\nunit.framework.dll</HintPath>
    </Reference>
    <Reference Include=""System"">
      <Name>System</Name>
    </Reference>
    <Reference Include=""System.configuration"" />
    <Reference Include=""System.Core"">
      <RequiredTargetFramework>3.5</RequiredTargetFramework>
    </Reference>
    <Reference Include=""System.Data"">
      <Name>System.Data</Name>
    </Reference>
    <Reference Include=""System.Xml"">
      <Name>System.XML</Name>
    </Reference>
    <ProjectReference Include=""..\Castle.MicroKernel.Tests\Castle.MicroKernel.Tests-vs2008.csproj"">
      <Project>{EF9313A4-C6E0-40F7-9E3F-530D547D3AEF}</Project>
      <Name>Castle.MicroKernel.Tests-vs2008</Name>
    </ProjectReference>
    <ProjectReference Include=""..\Castle.MicroKernel\Castle.MicroKernel-vs2008.csproj"">
      <Name>Castle.MicroKernel-vs2008</Name>
      <Project>{8C6AADEB-D099-4D2A-8F5B-4EBC12AC9159}</Project>
      <Package>{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}</Package>
    </ProjectReference>
    <ProjectReference Include=""..\Castle.Windsor\Castle.Windsor-vs2008.csproj"">
      <Name>Castle.Windsor-vs2008</Name>
      <Project>{60EFCB9B-E3FF-46A5-A2D2-D9F0EF75D5FE}</Project>
      <Package>{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}</Package>
      <Private>True</Private>
    </ProjectReference>
  </ItemGroup>
  <ItemGroup>
    <Compile Include=""Adapters\ComponentModel\ContainerAdapterTestCase.cs"">
      <SubType>Code</SubType>
    </Compile>
    <Compile Include=""Adapters\ComponentModel\TestComponent.cs"">
      <SubType>Component</SubType>
    </Compile>
    <Compile Include=""Bugs\FACILITIES-ISSUE-111\Components\A_Facilities_Issue_111.cs"" />
    <Compile Include=""Bugs\FACILITIES-ISSUE-111\Components\B_Facilities_Issue_111.cs"" />
    <Compile Include=""Bugs\FACILITIES-ISSUE-111\Components\IA_Facilities_Issue_111.cs"" />
    <Compile Include=""Bugs\FACILITIES-ISSUE-111\Components\IB_Facilities_Issue_111.cs"" />
    <Compile Include=""Bugs\FACILITIES-ISSUE-111\FACILITIES_ISSUE_111.cs"" />
    <Compile Include=""Bugs\IoC-102.cs"" />
    <Compile Include=""Bugs\IoC-115.cs"" />
    <Compile Include=""Bugs\IoC-127.cs"" />
    <Compile Include=""Bugs\IoC-138.cs"" />
    <Compile Include=""Bugs\IoC-73\ClassUser.cs"" />
    <Compile Include=""Bugs\IoC-73\IMyClass.cs"" />
    <Compile Include=""Bugs\IoC-73\MyClass.cs"" />
    <Compile Include=""Bugs\IoC-73\IoC73.cs"" />
    <Compile Include=""Bugs\IoC-73\Proxy.cs"" />
    <Compile Include=""Bugs\IoC-78\IoC-78.cs"" />
    <Compile Include=""Bugs\IoC_103\IoC_103.cs"" />
    <Compile Include=""Bugs\IoC_120.cs"" />
    <Compile Include=""Bugs\IoC_142.cs"" />
    <Compile Include=""Bugs\IoC_147.cs"" />
    <Compile Include=""Bugs\IoC_155.cs"" />
    <Compile Include=""Bugs\IoC_169\IoC_169.cs"" />
    <Compile Include=""Bugs\IoC_92.cs"" />
    <Compile Include=""ChildContainerSupportTestCase.cs"">
      <SubType>Code</SubType>
    </Compile>
    <Compile Include=""CircularDependencyTests.cs"" />
    <Compile Include=""Components\CalculatorService.cs"">
      <SubType>Code</SubType>
    </Compile>
    <Compile Include=""Components\CalculatorServiceWithAttributes.cs"">
      <SubType>Code</SubType>
    </Compile>
    <Compile Include=""Components\CalculatorServiceWithInternalInterface.cs"" />
    <Compile Include=""Components\CalculatorServiceWithLifecycle.cs"">
      <SubType>Code</SubType>
    </Compile>
    <Compile Include=""Components\Camera.cs"" />
    <Compile Include=""Components\CircularDependencyComponents.cs"" />
    <Compile Include=""Components\ComponentWithConfigs.cs"" />
    <Compile Include=""Components\ComponentWithProperties.cs"" />
    <Compile Include=""Components\ComponentWithStringProperty.cs"" />
    <Compile Include=""Components\CalculatorServiceWithProxyBehavior.cs"" />
    <Compile Include=""Components\DotNet2Components.cs"" />
    <Compile Include=""Components\Employee.cs"">
      <SubType>Code</SubType>
    </Compile>
    <Compile Include=""Components\ICalcService.cs"">
      <SubType>Code</SubType>
    </Compile>
    <Compile Include=""Components\IEmployee.cs"">
      <SubType>Code</SubType>
    </Compile>
    <Compile Include=""Components\IReviewableEmployee.cs"">
      <SubType>Code</SubType>
    </Compile>
    <Compile Include=""Components\IReviewer.cs"">
      <SubType>Code</SubType>
    </Compile>
    <Compile Include=""Components\MailServer.cs"" />
    <Compile Include=""Components\MarshalCalculatorService.cs"">
      <SubType>Code</SubType>
    </Compile>
    <Compile Include=""Components\ReviewableEmployee.cs"">
      <SubType>Code</SubType>
    </Compile>
    <Compile Include=""Components\Reviewer.cs"">
      <SubType>Code</SubType>
    </Compile>
    <Compile Include=""Components\Robot.cs"">
      <SubType>Code</SubType>
    </Compile>
    <Compile Include=""Components\SimpleMixIn.cs"" />
    <Compile Include=""ConfigHelper.cs"" />
    <Compile Include=""Configuration2\ConfigurationEnvTestCase.cs"" />
    <Compile Include=""Configuration2\ConfigurationForwardedTypesTestCase.cs"" />
    <Compile Include=""Configuration2\ConfigWithStatementsTestCase.cs"">
      <SubType>Code</SubType>
    </Compile>
    <Compile Include=""Configuration2\EvalSupportTestCase.cs"" />
    <Compile Include=""Configuration2\IncludesTestCase.cs"">
      <SubType>Code</SubType>
    </Compile>
    <Compile Include=""Configuration2\Properties\PropertiesTestCase.cs"">
      <SubType>Code</SubType>
    </Compile>
    <Compile Include=""Configuration2\SynchronizationProblemTestCase.cs"" />
    <Compile Include=""Configuration\AppDomainConfigurationStoreTestCase.cs"">
      <SubType>Code</SubType>
    </Compile>
    <Compile Include=""Configuration\ConfigXmlInterpreterTestCase.cs"">
      <SubType>Code</SubType>
    </Compile>
    <Compile Include=""ConfigureDecoratorsTestCase.cs"" />
    <Compile Include=""ContainerProblem.cs"">
      <SubType>Code</SubType>
    </Compile>
    <Compile Include=""ContainerProblem2.cs"" />
    <Compile Include=""Facilities\EventWiring\InvalidConfigTestCase.cs"" />
    <Compile Include=""Facilities\EventWiring\Model\GenericService.cs"" />
    <Compile Include=""Facilities\EventWiring\Model\Handlers.cs"" />
    <Compile Include=""Facilities\EventWiring\Model\MultiListener.cs"" />
    <Compile Include=""Facilities\EventWiring\Model\MultiPublisher.cs"" />
    <Compile Include=""Facilities\EventWiring\Model\MyInterceptor.cs"" />
    <Compile Include=""Facilities\EventWiring\Model\PublisherListener.cs"" />
    <Compile Include=""Facilities\EventWiring\Model\SimpleListener.cs"" />
    <Compile Include=""Facilities\EventWiring\Model\SimplePublisher.cs"" />
    <Compile Include=""Facilities\EventWiring\Model\SimpleService.cs"" />
    <Compile Include=""Facilities\EventWiring\Model\SubscriberWithDependency.cs"" />
    <Compile Include=""Facilities\EventWiring\Model\SubscriberWithGenericDependency.cs"" />
    <Compile Include=""Facilities\EventWiring\ProxiedSubscriberTestCase.cs"" />
    <Compile Include=""Facilities\EventWiring\SingletonComponentsTestCase.cs"" />
    <Compile Include=""Facilities\EventWiring\SingletonStartableTestCase.cs"" />
    <Compile Include=""Facilities\EventWiring\SubscriberWithDependenciesTestCase.cs"" />
    <Compile Include=""Facilities\EventWiring\WiringTestBase.cs"" />
    <Compile Include=""Facilities\Remoting\AbstractRemoteTestCase.cs"" />
    <Compile Include=""Facilities\Remoting\AppDomainFactory.cs"" />
    <Compile Include=""Facilities\Remoting\CalcServiceImpl.cs"" />
    <Compile Include=""Facilities\Remoting\ChangeResultInterceptor.cs"" />
    <Compile Include=""Facilities\Remoting\ConfigurableRegistrationTestCase.cs"" />
    <Compile Include=""Facilities\Remoting\ConsumerComp.cs"" />
    <Compile Include=""Facilities\Remoting\CustomToStringService.cs"" />
    <Compile Include=""Facilities\Remoting\FacilityLifeCycleTestCase.cs"" />
    <Compile Include=""Facilities\Remoting\GenericToStringServiceImpl.cs"" />
    <Compile Include=""Facilities\Remoting\ICalcService.cs"" />
    <Compile Include=""Facilities\Remoting\IGenericHashService.cs"" />
    <Compile Include=""Facilities\Remoting\InterceptableCalcService.cs"" />
    <Compile Include=""Facilities\Remoting\RemoteClientActivatedTestCase.cs"" />
    <Compile Include=""Facilities\Remoting\RemoteComponentTestCase.cs"" />
    <Compile Include=""Facilities\Remoting\RemoteComponentWithInterceptorTestCase.cs"" />
    <Compile Include=""Facilities\Remoting\RemoteGenericComponentTestCase.cs"" />
    <Compile Include=""Facilities\Remoting\RemoteRecoverableCpntTestCase.cs"" />
    <Compile Include=""Facilities\Remoting\RemoteSingletonTestCase.cs"" />
    <Compile Include=""Facilities\Remoting\ServerClientContainerTestCase.cs"" />
    <Compile Include=""Facilities\TypedFactory\Components\Component1.cs"" />
    <Compile Include=""Facilities\TypedFactory\Components\Component2.cs"" />
    <Compile Include=""Facilities\TypedFactory\Components\IDummyComponent.cs"" />
    <Compile Include=""Facilities\TypedFactory\Components\IProtocolHandler.cs"" />
    <Compile Include=""Facilities\TypedFactory\Components\MessengerProtocolHandler.cs"" />
    <Compile Include=""Facilities\TypedFactory\Components\MirandaProtocolHandler.cs"" />
    <Compile Include=""Facilities\TypedFactory\ExternalConfigurationTestCase.cs"" />
    <Compile Include=""Facilities\TypedFactory\Factories\IComponentFactory.cs"" />
    <Compile Include=""Facilities\TypedFactory\Factories\IProtocolHandlerFactory.cs"" />
    <Compile Include=""Facilities\TypedFactory\TypedFactoryTestCase.cs"" />
    <Compile Include=""InterceptorSelectorTestCase.cs"" />
    <Compile Include=""OpenGenericsTestCase.cs"" />
    <Compile Include=""RegisteringTwoServicesForSameType.cs"" />
    <Compile Include=""SubResolversShouldNotBeTrustedToBeCorrect.cs"" />
    <Compile Include=""ModelInterceptorsSelectorTestCase.cs"" />
    <Compile Include=""DependencyProblem.cs"">
      <SubType>Code</SubType>
    </Compile>
    <Content Include=""ignoreprop.xml"" />
    <Content Include=""DotNet2Config\ComplexGenericConfig.xml"" />
    <Content Include=""DotNet2Config\GenericDecoratorConfig.xml"" />
    <Content Include=""DotNet2Config\MissingDecoratorConfig.xml"" />
    <Content Include=""DotNet2Config\RecursiveDecoratorConfig.xml"" />
    <Content Include=""DotNet2Config\DecoratorConfig.xml"">
      <SubType>
      </SubType>
    </Content>
    <Compile Include=""Facilities\SlowlyInitFacility.cs"">
      <SubType>Code</SubType>
    </Compile>
    <Compile Include=""HandlerSelectorsTestCase.cs"" />
    <Compile Include=""IgnoreWireTestCase.cs"" />
    <Compile Include=""Installer\ConfigurationInstallerTestCase.cs"" />
    <Compile Include=""Installer\InstallerTestCase.cs"">
      <SubType>Code</SubType>
    </Compile>
    <Compile Include=""InterceptorsTestCase.cs"">
      <SubType>Code</SubType>
    </Compile>
    <Compile Include=""MultiResolveTests.cs"" />
    <Compile Include=""PropertiesInspectionBehaviorTestCase.cs"" />
    <Compile Include=""Proxy\MixInTestCase.cs"" />
    <Compile Include=""Proxy\FactorySupportTestCase.cs"" />
    <Compile Include=""Proxy\TypedFactoryFacilityTestCase.cs"" />
    <Compile Include=""Proxy\ProxyBehaviorInvalidTestCase.cs"" />
    <Compile Include=""Proxy\ProxyBehaviorTestCase.cs"" />
    <Compile Include=""ReportedProblemTestCase.cs"">
      <SubType>Code</SubType>
    </Compile>
    <Compile Include=""RobotWireTestCase.cs"">
      <SubType>Code</SubType>
    </Compile>
    <Compile Include=""SmartProxyTestCase.cs"">
      <SubType>Code</SubType>
    </Compile>
    <Compile Include=""WindsorDotNet2Tests.cs"" />
    <Compile Include=""XmlProcessor\XmlProcessorTestCase.cs"">
      <SubType>Code</SubType>
    </Compile>
    <Content Include=""Configuration2\Properties\config_with_missing_properties.xml"" />
    <Content Include=""Configuration2\Properties\config_with_properties.xml"" />
    <Content Include=""Configuration2\Properties\config_with_properties_and_defines.xml"" />
    <Content Include=""Configuration2\Properties\config_with_properties_and_defines2.xml"" />
    <Content Include=""Configuration2\Properties\config_with_properties_and_includes.xml"" />
    <Content Include=""Configuration2\Properties\config_with_silent_properties.xml"" />
    <Content Include=""Configuration2\Properties\properties.xml"" />
    <Content Include=""Configuration2\Properties\properties_using_properties.xml"" />
    <Content Include=""DotNet2Config\GenericsConfig.xml"" />
    <Content Include=""installerconfig.xml"" />
    <Content Include=""propertyInspectionBehavior.xml"" />
    <Content Include=""propertyInspectionBehaviorInvalid.xml"" />
    <Content Include=""robotwireconfig.xml"" />
    <Content Include=""sample_config.xml"" />
    <Content Include=""XmlProcessor\TestFiles\AssemblyIncludeTestDisabled.xml"" />
    <Content Include=""XmlProcessor\TestFiles\AssemblyIncludeTestResult.xml"" />
    <Content Include=""XmlProcessor\TestFiles\ChooseStatement2Test.xml"" />
    <Content Include=""XmlProcessor\TestFiles\ChooseStatement2TestResult.xml"" />
    <Content Include=""XmlProcessor\TestFiles\ChooseStatementTest.xml"" />
    <Content Include=""XmlProcessor\TestFiles\ChooseStatementTestResult.xml"" />
    <Content Include=""XmlProcessor\TestFiles\ComplexPropertiesTest.xml"" />
    <Content Include=""XmlProcessor\TestFiles\ComplexPropertiesTestResult.xml"" />
    <Content Include=""XmlProcessor\TestFiles\DefineDebugTestDisabled.xml"" />
    <Content Include=""XmlProcessor\TestFiles\DefineDebugTestResult.xml"" />
    <Content Include=""XmlProcessor\TestFiles\DefineDefaultTest.xml"" />
    <Content Include=""XmlProcessor\TestFiles\DefineDefaultTestResult.xml"" />
    <Content Include=""XmlProcessor\TestFiles\IfStatementTest.xml"" />
    <Content Include=""XmlProcessor\TestFiles\IfStatementTestResult.xml"" />
    <Content Include=""XmlProcessor\TestFiles\InvalidElseWithFlag.xml"" />
    <Content Include=""XmlProcessor\TestFiles\InvalidElsifWithNoFlag.xml"" />
    <Content Include=""XmlProcessor\TestFiles\InvalidFlag.xml"" />
    <Content Include=""XmlProcessor\TestFiles\InvalidIfWithNoFlag.xml"" />
    <Content Include=""XmlProcessor\TestFiles\InvalidPropertiesMissing.xml"" />
    <Content Include=""XmlProcessor\TestFiles\InvalidUnbalancedIfStatement.xml"" />
    <Content Include=""XmlProcessor\TestFiles\MultiInclude2Test.xml"" />
    <Content Include=""XmlProcessor\TestFiles\MultiInclude2TestResult.xml"" />
    <Content Include=""XmlProcessor\TestFiles\MultiIncludeTest.xml"" />
    <Content Include=""XmlProcessor\TestFiles\MultiIncludeTestResult.xml"" />
    <Content Include=""XmlProcessor\TestFiles\Pi-ChooseStatement2Test.xml"" />
    <Content Include=""XmlProcessor\TestFiles\Pi-ChooseStatement2TestResult.xml"" />
    <Content Include=""XmlProcessor\TestFiles\Pi-ChooseStatementTest.xml"" />
    <Content Include=""XmlProcessor\TestFiles\Pi-ChooseStatementTestResult.xml"" />
    <Content Include=""XmlProcessor\TestFiles\Pi-ComplexChooseStatementTest.xml"" />
    <Content Include=""XmlProcessor\TestFiles\Pi-ComplexChooseStatementTestResult.xml"" />
    <Content Include=""XmlProcessor\TestFiles\Pi-ComplexDefineDefaultTest.xml"" />
    <Content Include=""XmlProcessor\TestFiles\Pi-ComplexDefineDefaultTestResult.xml"" />
    <Content Include=""XmlProcessor\TestFiles\Pi-DefineDebugTest.xml"" />
    <Content Include=""XmlProcessor\TestFiles\Pi-DefineDebugTestResult.xml"" />
    <Content Include=""XmlProcessor\TestFiles\Pi-DefineDefaultTest.xml"" />
    <Content Include=""XmlProcessor\TestFiles\Pi-DefineDefaultTestResult.xml"" />
    <Content Include=""XmlProcessor\TestFiles\PI-IfStatementTest.xml"" />
    <Content Include=""XmlProcessor\TestFiles\PI-IfStatementTestResult.xml"" />
    <Content Include=""XmlProcessor\TestFiles\PropertiesMissingSilentTest.xml"" />
    <Content Include=""XmlProcessor\TestFiles\PropertiesMissingSilentTestResult.xml"" />
    <Content Include=""XmlProcessor\TestFiles\PropertiesWithAttributesTest.xml"" />
    <Content Include=""XmlProcessor\TestFiles\PropertiesWithAttributesTestResult.xml"" />
    <Content Include=""XmlProcessor\TestFiles\RelativeTest\Include1.xml"" />
    <Content Include=""XmlProcessor\TestFiles\RelativeTest\Include2.xml"" />
    <Content Include=""XmlProcessor\TestFiles\SimpleInclude.xml"" />
    <Content Include=""XmlProcessor\TestFiles\SimplePropertiesTest.xml"" />
    <Content Include=""XmlProcessor\TestFiles\SimplePropertiesTestResult.xml"" />
    <Content Include=""XmlProcessor\TestFiles\SimpleTest.xml"" />
    <Content Include=""XmlProcessor\TestFiles\SimpleTestResult.xml"" />
    <EmbeddedResource Include=""Adapters\ComponentModel\TestComponent.resx"">
      <DependentUpon>TestComponent.cs</DependentUpon>
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <EmbeddedResource Include=""Configuration2\config_with_choose_stmt.xml"" />
    <EmbeddedResource Include=""Configuration2\config_with_define_debug.xml"" />
    <EmbeddedResource Include=""Configuration2\config_with_define_default.xml"" />
    <EmbeddedResource Include=""Configuration2\config_with_define_prod.xml"" />
    <EmbeddedResource Include=""Configuration2\config_with_define_qa.xml"" />
    <EmbeddedResource Include=""Configuration2\config_with_if_stmt.xml"" />
    <EmbeddedResource Include=""Configuration2\config_with_include.xml"" />
    <EmbeddedResource Include=""Configuration2\config_with_include_relative.xml"" />
    <EmbeddedResource Include=""Configuration2\config_with_include_relative2.xml"" />
    <EmbeddedResource Include=""Configuration2\include1.xml"" />
    <EmbeddedResource Include=""Configuration2\include2.xml"" />
    <EmbeddedResource Include=""Configuration2\RelativeTest\rel_include1.xml"" />
    <EmbeddedResource Include=""Configuration2\RelativeTest\rel_include2.xml"" />
    <EmbeddedResource Include=""Configuration2\resource_config_with_include.xml"" />
    <EmbeddedResource Include=""XmlProcessor\TestFiles\AssemblyInclude1.xml"" />
    <EmbeddedResource Include=""XmlProcessor\TestFiles\AssemblyInclude2.xml"" />
    <EmbeddedResource Include=""XmlProcessor\TestFiles\include1.xml"" />
    <EmbeddedResource Include=""XmlProcessor\TestFiles\include2.xml"" />
  </ItemGroup>
  <ItemGroup>
    <None Include=""App.config"" />
    <None Include=""DotNet2Config\chainOfRespnsability.config"" />
    <None Include=""DotNet2Config\chainOfRespnsability_smart.config"" />
    <None Include=""Facilities\EventWiring\App.config"" />
    <Content Include=""RemotingTcpConfig2.config"">
      <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
    </Content>
    <Content Include=""RemotingTcpConfigClient.config"">
      <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
    </Content>
    <Content Include=""RemotingTcpConfig.config"">
      <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
    </Content>
    <EmbeddedResource Include=""Facilities\EventWiring\Config\dependencies.config"" />
    <EmbeddedResource Include=""Facilities\EventWiring\Config\invalid.config"" />
    <EmbeddedResource Include=""Facilities\EventWiring\Config\singleton.config"" />
    <EmbeddedResource Include=""Facilities\EventWiring\Config\startable.config"" />
    <EmbeddedResource Include=""Configuration2\env_config.xml"" />
    <EmbeddedResource Include=""Configuration2\eval_config.xml"" />
    <Content Include=""Configuration2\config_with_forwarded_types.xml"" />
    <Content Include=""Configuration2\synchtest_config.xml"" />
    <EmbeddedResource Include=""sample_config_with_spaces.xml"" />
    <EmbeddedResource Include=""Configuration\sample_config.xml"" />
    <EmbeddedResource Include=""Facilities\Remoting\Configs\client_12134_kernelcomponent.xml"" />
    <EmbeddedResource Include=""Facilities\Remoting\Configs\client_clientactivated.xml"" />
    <EmbeddedResource Include=""Facilities\Remoting\Configs\client_confreg_clientactivated.xml"" />
    <EmbeddedResource Include=""Facilities\Remoting\Configs\client_kernelcomponent.xml"" />
    <EmbeddedResource Include=""Facilities\Remoting\Configs\client_kernelcomponent_recover.xml"" />
    <EmbeddedResource Include=""Facilities\Remoting\Configs\client_kernelgenericcomponent.xml"" />
    <EmbeddedResource Include=""Facilities\Remoting\Configs\client_simple_scenario.xml"" />
    <EmbeddedResource Include=""Facilities\Remoting\Configs\server_clientactivated.xml"" />
    <EmbeddedResource Include=""Facilities\Remoting\Configs\server_client_kernelcomponent.xml"" />
    <EmbeddedResource Include=""Facilities\Remoting\Configs\server_confreg_clientactivated.xml"" />
    <EmbeddedResource Include=""Facilities\Remoting\Configs\server_kernelcomponent.xml"" />
    <EmbeddedResource Include=""Facilities\Remoting\Configs\server_kernelcomponent_inter1.xml"" />
    <EmbeddedResource Include=""Facilities\Remoting\Configs\server_kernelcomponent_recover.xml"" />
    <EmbeddedResource Include=""Facilities\Remoting\Configs\server_kernelgenericcomponent.xml"" />
    <EmbeddedResource Include=""Facilities\Remoting\Configs\server_simple_scenario.xml"" />
    <EmbeddedResource Include=""Facilities\TypedFactory\typedFactory_castle_config.xml"" />
    <Content Include=""IOC-51.xml"" />
    <Content Include=""Proxy\typedFactory.xml"" />
    <Content Include=""Proxy\proxyBehaviorInvalidConfig.xml"" />
    <Content Include=""Proxy\proxyBehavior.xml"" />
    <Content Include=""Proxy\typedFactoryCreateWithoutId.xml"" />
  </ItemGroup>
  <ItemGroup>
    <Service Include=""{B4F97281-0DBD-4835-9ED8-7DFB966E87FF}"" />
  </ItemGroup>
  <ItemGroup>
    <BootstrapperPackage Include=""Microsoft.Net.Framework.2.0"">
      <Visible>False</Visible>
      <ProductName>.NET Framework 2.0 %28x86%29</ProductName>
      <Install>true</Install>
    </BootstrapperPackage>
    <BootstrapperPackage Include=""Microsoft.Net.Framework.3.0"">
      <Visible>False</Visible>
      <ProductName>.NET Framework 3.0 %28x86%29</ProductName>
      <Install>false</Install>
    </BootstrapperPackage>
    <BootstrapperPackage Include=""Microsoft.Net.Framework.3.5"">
      <Visible>False</Visible>
      <ProductName>.NET Framework 3.5</ProductName>
      <Install>false</Install>
    </BootstrapperPackage>
  </ItemGroup>
  <ItemGroup>
    <Folder Include=""Bugs\UnregisteringWithFactorySupport\"" />
  </ItemGroup>
  <Import Project=""$(MSBuildBinPath)\Microsoft.CSharp.targets"" />
  <PropertyGroup>
    <PreBuildEvent>
    </PreBuildEvent>
    <PostBuildEvent>
    </PostBuildEvent>
  </PropertyGroup>
</Project>";

        public void CanRemoveTargets()
        {
            var document = new XmlDocument();
            document.LoadXml(this.iocTests);
            var remove = StandardTransforms.RemoveFlavourTargetsAndDefines();
            remove.ApplyTransform(new XmlFile(document));
            Assert.IsFalse(document.OuterXml.Contains(".targets"), "Targets were not removed.");
        }
    }
}