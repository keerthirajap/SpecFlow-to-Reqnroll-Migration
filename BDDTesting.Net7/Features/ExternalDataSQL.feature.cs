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
    public partial class ValidateETLProcessLoadsUserDataCorrectlyFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "ExternalDataSQL.feature"
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
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Validate ETL Process Loads User Data Correctly", null, ProgrammingLanguage.CSharp, featureTags);
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
                        && (testRunner.FeatureContext.FeatureInfo.Title != "Validate ETL Process Loads User Data Correctly")))
            {
                global::BDDTesting.Net7.Features.ValidateETLProcessLoadsUserDataCorrectlyFeature.FeatureSetup(null);
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
        
        public virtual void FeatureBackground()
        {
#line 3
#line hidden
        }
        
        public virtual void ValidateUserDataAgainstExcelFile(
                    string userId, 
                    string firstName, 
                    string lastName, 
                    string email, 
                    string phoneNumber, 
                    string dateOfBirth, 
                    string address, 
                    string city, 
                    string state, 
                    string postalCode, 
                    string country, 
                    string createdAt, 
                    string updatedAt, 
                    string isActive, 
                    string role, 
                    string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "DATA",
                    "DataSource:ExternalDataSQL_UsersData.xlsx",
                    "DataSet:Users"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("UserId", userId);
            argumentsOfScenario.Add("FirstName", firstName);
            argumentsOfScenario.Add("LastName", lastName);
            argumentsOfScenario.Add("Email", email);
            argumentsOfScenario.Add("PhoneNumber", phoneNumber);
            argumentsOfScenario.Add("DateOfBirth", dateOfBirth);
            argumentsOfScenario.Add("Address", address);
            argumentsOfScenario.Add("City", city);
            argumentsOfScenario.Add("State", state);
            argumentsOfScenario.Add("PostalCode", postalCode);
            argumentsOfScenario.Add("Country", country);
            argumentsOfScenario.Add("CreatedAt", createdAt);
            argumentsOfScenario.Add("UpdatedAt", updatedAt);
            argumentsOfScenario.Add("IsActive", isActive);
            argumentsOfScenario.Add("Role", role);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Validate user data against Excel file", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 7
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
this.FeatureBackground();
#line hidden
#line 8
 testRunner.Given(string.Format("the Excel file contains user data for user {0}", userId), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 9
 testRunner.When("the user data is validated against the Excel file with SQL Database", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 10
 testRunner.Then(string.Format("the database should contain a user with UserId {0} and correct PhoneNumber {1}", userId, phoneNumber), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Validate user data against Excel file: 1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Validate ETL Process Loads User Data Correctly")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DATA")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DataSource:ExternalDataSQL_UsersData.xlsx")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DataSet:Users")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("ExampleSetName", "ExternalExamples")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:UserId", "1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:FirstName", "John")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:LastName", "Doe")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Email", "john.doe@example.com")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:PhoneNumber", "555-0101")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DateOfBirth", "3/25/1985 12:00:00 AM")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Address", "123 Elm St")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:City", "Springfield")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:State", "IL")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:PostalCode", "62701")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Country", "USA")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:CreatedAt", "8/9/2024 12:00:00 AM")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:UpdatedAt", "8/9/2024 12:00:00 AM")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:IsActive", "1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Role", "User")]
        public void ValidateUserDataAgainstExcelFile_ExternalExamples_1()
        {
#line 7
this.ValidateUserDataAgainstExcelFile("1", "John", "Doe", "john.doe@example.com", "555-0101", "3/25/1985 12:00:00 AM", "123 Elm St", "Springfield", "IL", "62701", "USA", "8/9/2024 12:00:00 AM", "8/9/2024 12:00:00 AM", "1", "User", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Validate user data against Excel file: 2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Validate ETL Process Loads User Data Correctly")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DATA")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DataSource:ExternalDataSQL_UsersData.xlsx")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DataSet:Users")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("ExampleSetName", "ExternalExamples")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:UserId", "2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:FirstName", "Jane")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:LastName", "Smith")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Email", "jane.smith@example.com")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:PhoneNumber", "555-0102")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DateOfBirth", "7/15/1990 12:00:00 AM")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Address", "456 Oak St")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:City", "Springfield")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:State", "IL")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:PostalCode", "62702")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Country", "USA")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:CreatedAt", "8/9/2024 12:00:00 AM")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:UpdatedAt", "8/9/2024 12:00:00 AM")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:IsActive", "1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Role", "User")]
        public void ValidateUserDataAgainstExcelFile_ExternalExamples_2()
        {
#line 7
this.ValidateUserDataAgainstExcelFile("2", "Jane", "Smith", "jane.smith@example.com", "555-0102", "7/15/1990 12:00:00 AM", "456 Oak St", "Springfield", "IL", "62702", "USA", "8/9/2024 12:00:00 AM", "8/9/2024 12:00:00 AM", "1", "User", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Validate user data against Excel file: 3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Validate ETL Process Loads User Data Correctly")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DATA")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DataSource:ExternalDataSQL_UsersData.xlsx")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DataSet:Users")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("ExampleSetName", "ExternalExamples")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:UserId", "3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:FirstName", "Michael")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:LastName", "Brown")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Email", "michael.brown@example.com")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:PhoneNumber", "555-0103")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DateOfBirth", "11/5/1982 12:00:00 AM")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Address", "789 Pine St")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:City", "Springfield")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:State", "IL")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:PostalCode", "62703")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Country", "USA")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:CreatedAt", "8/9/2024 12:00:00 AM")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:UpdatedAt", "8/9/2024 12:00:00 AM")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:IsActive", "1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Role", "User")]
        public void ValidateUserDataAgainstExcelFile_ExternalExamples_3()
        {
#line 7
this.ValidateUserDataAgainstExcelFile("3", "Michael", "Brown", "michael.brown@example.com", "555-0103", "11/5/1982 12:00:00 AM", "789 Pine St", "Springfield", "IL", "62703", "USA", "8/9/2024 12:00:00 AM", "8/9/2024 12:00:00 AM", "1", "User", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Validate user data against Excel file: 4")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Validate ETL Process Loads User Data Correctly")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DATA")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DataSource:ExternalDataSQL_UsersData.xlsx")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DataSet:Users")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("ExampleSetName", "ExternalExamples")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "4")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:UserId", "4")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:FirstName", "Emily")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:LastName", "Johnson")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Email", "emily.johnson@example.com")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:PhoneNumber", "555-0104")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DateOfBirth", "2/20/1995 12:00:00 AM")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Address", "321 Maple St")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:City", "Springfield")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:State", "IL")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:PostalCode", "62704")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Country", "USA")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:CreatedAt", "8/9/2024 12:00:00 AM")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:UpdatedAt", "8/9/2024 12:00:00 AM")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:IsActive", "1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Role", "User")]
        public void ValidateUserDataAgainstExcelFile_ExternalExamples_4()
        {
#line 7
this.ValidateUserDataAgainstExcelFile("4", "Emily", "Johnson", "emily.johnson@example.com", "555-0104", "2/20/1995 12:00:00 AM", "321 Maple St", "Springfield", "IL", "62704", "USA", "8/9/2024 12:00:00 AM", "8/9/2024 12:00:00 AM", "1", "User", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Validate user data against Excel file: 5")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Validate ETL Process Loads User Data Correctly")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DATA")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DataSource:ExternalDataSQL_UsersData.xlsx")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DataSet:Users")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("ExampleSetName", "ExternalExamples")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "5")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:UserId", "5")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:FirstName", "James")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:LastName", "Williams")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Email", "james.williams@example.com")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:PhoneNumber", "555-0105")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DateOfBirth", "9/12/1988 12:00:00 AM")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Address", "654 Cedar St")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:City", "Springfield")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:State", "IL")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:PostalCode", "62705")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Country", "USA")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:CreatedAt", "8/9/2024 12:00:00 AM")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:UpdatedAt", "8/9/2024 12:00:00 AM")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:IsActive", "1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Role", "User")]
        public void ValidateUserDataAgainstExcelFile_ExternalExamples_5()
        {
#line 7
this.ValidateUserDataAgainstExcelFile("5", "James", "Williams", "james.williams@example.com", "555-0105", "9/12/1988 12:00:00 AM", "654 Cedar St", "Springfield", "IL", "62705", "USA", "8/9/2024 12:00:00 AM", "8/9/2024 12:00:00 AM", "1", "User", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Validate user data against Excel file: 6")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Validate ETL Process Loads User Data Correctly")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DATA")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DataSource:ExternalDataSQL_UsersData.xlsx")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DataSet:Users")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("ExampleSetName", "ExternalExamples")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "6")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:UserId", "6")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:FirstName", "Olivia")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:LastName", "Davis")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Email", "olivia.davis@example.com")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:PhoneNumber", "555-0106")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DateOfBirth", "6/18/1992 12:00:00 AM")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Address", "987 Birch St")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:City", "Springfield")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:State", "IL")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:PostalCode", "62706")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Country", "USA")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:CreatedAt", "8/9/2024 12:00:00 AM")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:UpdatedAt", "8/9/2024 12:00:00 AM")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:IsActive", "1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Role", "User")]
        public void ValidateUserDataAgainstExcelFile_ExternalExamples_6()
        {
#line 7
this.ValidateUserDataAgainstExcelFile("6", "Olivia", "Davis", "olivia.davis@example.com", "555-0106", "6/18/1992 12:00:00 AM", "987 Birch St", "Springfield", "IL", "62706", "USA", "8/9/2024 12:00:00 AM", "8/9/2024 12:00:00 AM", "1", "User", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Validate user data against Excel file: 7")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Validate ETL Process Loads User Data Correctly")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DATA")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DataSource:ExternalDataSQL_UsersData.xlsx")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DataSet:Users")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("ExampleSetName", "ExternalExamples")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "7")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:UserId", "7")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:FirstName", "Liam")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:LastName", "Miller")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Email", "liam.miller@example.com")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:PhoneNumber", "555-0107")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DateOfBirth", "12/30/1989 12:00:00 AM")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Address", "159 Willow St")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:City", "Springfield")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:State", "IL")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:PostalCode", "62707")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Country", "USA")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:CreatedAt", "8/9/2024 12:00:00 AM")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:UpdatedAt", "8/9/2024 12:00:00 AM")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:IsActive", "1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Role", "User")]
        public void ValidateUserDataAgainstExcelFile_ExternalExamples_7()
        {
#line 7
this.ValidateUserDataAgainstExcelFile("7", "Liam", "Miller", "liam.miller@example.com", "555-0107", "12/30/1989 12:00:00 AM", "159 Willow St", "Springfield", "IL", "62707", "USA", "8/9/2024 12:00:00 AM", "8/9/2024 12:00:00 AM", "1", "User", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Validate user data against Excel file: 8")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Validate ETL Process Loads User Data Correctly")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DATA")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DataSource:ExternalDataSQL_UsersData.xlsx")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DataSet:Users")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("ExampleSetName", "ExternalExamples")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "8")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:UserId", "8")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:FirstName", "Sophia")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:LastName", "Wilson")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Email", "sophia.wilson@example.com")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:PhoneNumber", "555-0108")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DateOfBirth", "4/25/1994 12:00:00 AM")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Address", "753 Elm St")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:City", "Springfield")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:State", "IL")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:PostalCode", "62708")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Country", "USA")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:CreatedAt", "8/9/2024 12:00:00 AM")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:UpdatedAt", "8/9/2024 12:00:00 AM")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:IsActive", "1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Role", "User")]
        public void ValidateUserDataAgainstExcelFile_ExternalExamples_8()
        {
#line 7
this.ValidateUserDataAgainstExcelFile("8", "Sophia", "Wilson", "sophia.wilson@example.com", "555-0108", "4/25/1994 12:00:00 AM", "753 Elm St", "Springfield", "IL", "62708", "USA", "8/9/2024 12:00:00 AM", "8/9/2024 12:00:00 AM", "1", "User", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Validate user data against Excel file: 9")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Validate ETL Process Loads User Data Correctly")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DATA")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DataSource:ExternalDataSQL_UsersData.xlsx")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DataSet:Users")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("ExampleSetName", "ExternalExamples")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "9")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:UserId", "9")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:FirstName", "Benjamin")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:LastName", "Moore")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Email", "benjamin.moore@example.com")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:PhoneNumber", "555-0109")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DateOfBirth", "10/14/1986 12:00:00 AM")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Address", "852 Oak St")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:City", "Springfield")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:State", "IL")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:PostalCode", "62709")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Country", "USA")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:CreatedAt", "8/9/2024 12:00:00 AM")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:UpdatedAt", "8/9/2024 12:00:00 AM")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:IsActive", "1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Role", "User")]
        public void ValidateUserDataAgainstExcelFile_ExternalExamples_9()
        {
#line 7
this.ValidateUserDataAgainstExcelFile("9", "Benjamin", "Moore", "benjamin.moore@example.com", "555-0109", "10/14/1986 12:00:00 AM", "852 Oak St", "Springfield", "IL", "62709", "USA", "8/9/2024 12:00:00 AM", "8/9/2024 12:00:00 AM", "1", "User", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Validate user data against Excel file: 10")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Validate ETL Process Loads User Data Correctly")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DATA")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DataSource:ExternalDataSQL_UsersData.xlsx")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("DataSet:Users")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("ExampleSetName", "ExternalExamples")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "10")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:UserId", "10")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:FirstName", "Ava")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:LastName", "Taylor")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Email", "ava.taylor@example.com")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:PhoneNumber", "555-0110")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DateOfBirth", "8/9/1991 12:00:00 AM")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Address", "963 Pine St")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:City", "Springfield")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:State", "IL")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:PostalCode", "62710")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Country", "USA")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:CreatedAt", "8/9/2024 12:00:00 AM")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:UpdatedAt", "8/9/2024 12:00:00 AM")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:IsActive", "1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Role", "User")]
        public void ValidateUserDataAgainstExcelFile_ExternalExamples_10()
        {
#line 7
this.ValidateUserDataAgainstExcelFile("10", "Ava", "Taylor", "ava.taylor@example.com", "555-0110", "8/9/1991 12:00:00 AM", "963 Pine St", "Springfield", "IL", "62710", "USA", "8/9/2024 12:00:00 AM", "8/9/2024 12:00:00 AM", "1", "User", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion
