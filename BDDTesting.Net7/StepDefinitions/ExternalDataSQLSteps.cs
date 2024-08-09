using BDDTesting.Net7.Models;
using BDDTesting.Net7.Repositories;
using System;
using System.Data.Common;
using System.Data.SqlClient;
using Reqnroll;
using Insight.Database;

namespace BDDTesting.Net7.StepDefinitions
{
    [Binding]
    public class ExternalDataSQLSteps
    {
        private int UserID;
        private readonly IUserRepository _userRepository;

        private User _userActual;
        private User _userExpected;

        public ExternalDataSQLSteps()
        {
            string absoluteProjectFolderPath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, @"..\..\..\Database\"));
            string sqlConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=__ReplaceWithProjectFolder__SampleDB.mdf;Integrated Security=True;Connect Timeout=30";

            sqlConnectionString = sqlConnectionString.Replace("__ReplaceWithProjectFolder__", absoluteProjectFolderPath);
            DbConnection sqlConnection = new SqlConnection(sqlConnectionString);

            this._userRepository = sqlConnection.As<IUserRepository>();
        }

        [Given(@"the Excel file contains user data for user (.*)")]
        public async Task GivenTheExcelFileContainsUserDataForUser(int userId)
        {
            this.UserID = userId;
        }

        [When(@"the user data is validated against the Excel file with SQL Database")]
        public async Task WhenTheUserDataIsValidatedAgainstTheExcelFileWithSQLDatabase()
        {
            // Fetch the user from the database
            _userExpected = await _userRepository.GetUserByIdAsync(this.UserID);
            Assert.IsNotNull(_userExpected, "User data not found in the database");
        }

        [Then(@"the database should contain a user with UserId (.*) and correct PhoneNumber (.*)")]
        public void ThenTheDatabaseShouldContainAUserWithUserIdUserIdAndCorrectPhoneNumberPhoneNumber(int userId, string phoneNumber)
        {
            Assert.AreEqual(userId, _userExpected.UserId, "UserId does not match.");
            Assert.AreEqual(phoneNumber, _userExpected.PhoneNumber, "PhoneNumber does not match.");
        }
    }
}