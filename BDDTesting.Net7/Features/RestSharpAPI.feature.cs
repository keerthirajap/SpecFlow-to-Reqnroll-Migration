﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace BDDTesting.Net7.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class Examples_IPAddressTypeCheckFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "RestSharpAPI.feature"
#line hidden
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this._testContext;
            }
            set
            {
                this._testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Examples -> IP Address Type Check", null, ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "Examples -> IP Address Type Check")))
            {
                global::BDDTesting.Net7.Features.Examples_IPAddressTypeCheckFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(_testContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void Examples_VerifyIPAddressTypeWithRestSharpAPI(string ip_Address, string expected_Type, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "API"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("ip_address", ip_Address);
            argumentsOfScenario.Add("expected_type", expected_Type);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Examples -> Verify IP address type with RestSharpAPI", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 4
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
 testRunner.Given(string.Format("I send a request to check the IP address \"{0}\"", ip_Address), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 6
 testRunner.Then(string.Format("the response should indicate that the IP address is of type \"{0}\"", expected_Type), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Examples -> Verify IP address type with RestSharpAPI: 24.48.0.1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Examples -> IP Address Type Check")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("API")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "24.48.0.1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:ip_address", "24.48.0.1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:expected_type", "IPv4")]
        public void Examples_VerifyIPAddressTypeWithRestSharpAPI_24_48_0_1()
        {
#line 4
this.Examples_VerifyIPAddressTypeWithRestSharpAPI("24.48.0.1", "IPv4", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Examples -> Verify IP address type with RestSharpAPI: 2401:4900:1c29:6e64:f56f:78" +
            "c1:95d5:a48d")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Examples -> IP Address Type Check")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("API")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "2401:4900:1c29:6e64:f56f:78c1:95d5:a48d")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:ip_address", "2401:4900:1c29:6e64:f56f:78c1:95d5:a48d")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:expected_type", "IPv6")]
        public void Examples_VerifyIPAddressTypeWithRestSharpAPI_240149001C296E64F56F78C195D5A48D()
        {
#line 4
this.Examples_VerifyIPAddressTypeWithRestSharpAPI("2401:4900:1c29:6e64:f56f:78c1:95d5:a48d", "IPv6", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Examples -> Verify IP address type with RestSharpAPI: 8.8.8.8")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Examples -> IP Address Type Check")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("API")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "8.8.8.8")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:ip_address", "8.8.8.8")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:expected_type", "IPv4")]
        public void Examples_VerifyIPAddressTypeWithRestSharpAPI_8_8_8_8()
        {
#line 4
this.Examples_VerifyIPAddressTypeWithRestSharpAPI("8.8.8.8", "IPv4", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Examples -> Verify IP address type with RestSharpAPI: 2001:4860:4860::8888")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Examples -> IP Address Type Check")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("API")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "2001:4860:4860::8888")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:ip_address", "2001:4860:4860::8888")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:expected_type", "IPv6")]
        public void Examples_VerifyIPAddressTypeWithRestSharpAPI_2001486048608888()
        {
#line 4
this.Examples_VerifyIPAddressTypeWithRestSharpAPI("2001:4860:4860::8888", "IPv6", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Examples -> Verify IP address type with RestSharpAPI: 172.217.14.206")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Examples -> IP Address Type Check")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("API")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "172.217.14.206")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:ip_address", "172.217.14.206")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:expected_type", "IPv4")]
        public void Examples_VerifyIPAddressTypeWithRestSharpAPI_172_217_14_206()
        {
#line 4
this.Examples_VerifyIPAddressTypeWithRestSharpAPI("172.217.14.206", "IPv4", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion
