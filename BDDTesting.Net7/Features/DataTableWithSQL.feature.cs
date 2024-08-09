﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by Reqnroll (https://www.reqnroll.net/).
//      Reqnroll Version:2.0.0.0
//      Reqnroll Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace BDDTesting.Net7.Features
{
    using Reqnroll;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Reqnroll", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class DataTable_ValidateETLProcessLoadsUserDataCorrectlyFeature
    {
        
        private static global::Reqnroll.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "DataTableWithSQL.feature"
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
        public static async System.Threading.Tasks.Task FeatureSetupAsync(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = global::Reqnroll.TestRunnerManager.GetTestRunnerForAssembly(null, System.Threading.Thread.CurrentThread.ManagedThreadId.ToString());
            global::Reqnroll.FeatureInfo featureInfo = new global::Reqnroll.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "DataTable -> Validate ETL Process Loads User Data Correctly", "A short summary of the feature", global::Reqnroll.ProgrammingLanguage.CSharp, featureTags);
            await testRunner.OnFeatureStartAsync(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute(Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupBehavior.EndOfClass)]
        public static async System.Threading.Tasks.Task FeatureTearDownAsync()
        {
            await testRunner.OnFeatureEndAsync();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public async System.Threading.Tasks.Task TestInitializeAsync()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "DataTable -> Validate ETL Process Loads User Data Correctly")))
            {
                await global::BDDTesting.Net7.Features.DataTable_ValidateETLProcessLoadsUserDataCorrectlyFeature.FeatureSetupAsync(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public async System.Threading.Tasks.Task TestTearDownAsync()
        {
            await testRunner.OnScenarioEndAsync();
        }
        
        public void ScenarioInitialize(global::Reqnroll.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(_testContext);
        }
        
        public async System.Threading.Tasks.Task ScenarioStartAsync()
        {
            await testRunner.OnScenarioStartAsync();
        }
        
        public async System.Threading.Tasks.Task ScenarioCleanupAsync()
        {
            await testRunner.CollectScenarioErrorsAsync();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Validate user data against given data DataTable (CreateSet)")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DataTable -> Validate ETL Process Loads User Data Correctly")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DATA")]
        public async System.Threading.Tasks.Task ValidateUserDataAgainstGivenDataDataTableCreateSet()
        {
            string[] tagsOfScenario = new string[] {
                    "DATA"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Validate user data against given data DataTable (CreateSet)", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 6
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 7
 await testRunner.GivenAsync("Validate user data against given data", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
                global::Reqnroll.Table table1 = new global::Reqnroll.Table(new string[] {
                            "UserId",
                            "FirstName",
                            "LastName",
                            "PhoneNumber"});
                table1.AddRow(new string[] {
                            "1",
                            "John",
                            "Doe",
                            "555-0101"});
                table1.AddRow(new string[] {
                            "2",
                            "Jane",
                            "Smith",
                            "555-0102"});
#line 8
 await testRunner.WhenAsync("the user data is validated against user\'s data in SQL Database", ((string)(null)), table1, "When ");
#line hidden
#line 12
 await testRunner.ThenAsync("the database should contain a user with respective PhoneNumber", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Validate user data against given data DataTable (Rows)")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DataTable -> Validate ETL Process Loads User Data Correctly")]
        public async System.Threading.Tasks.Task ValidateUserDataAgainstGivenDataDataTableRows()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Validate user data against given data DataTable (Rows)", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 15
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 16
 await testRunner.GivenAsync("Validate user data against given data", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
                global::Reqnroll.Table table2 = new global::Reqnroll.Table(new string[] {
                            "UserId",
                            "FirstName",
                            "LastName",
                            "PhoneNumber"});
                table2.AddRow(new string[] {
                            "1",
                            "John",
                            "Doe",
                            "555-0101"});
                table2.AddRow(new string[] {
                            "2",
                            "Jane",
                            "Smith",
                            "555-0102"});
#line 17
 await testRunner.WhenAsync("the user data is validated against user\'s data in SQL Database by rows", ((string)(null)), table2, "When ");
#line hidden
#line 21
 await testRunner.ThenAsync("the database should contain a user with respective PhoneNumber", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
    }
}
#pragma warning restore
#endregion
