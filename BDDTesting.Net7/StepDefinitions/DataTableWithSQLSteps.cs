using BDDTesting.Net7.Models;
using BDDTesting.Net7.Repositories;
using Insight.Database;
using System;
using System.Data.Common;
using System.Data.SqlClient;
using Reqnroll;

namespace BDDTesting.Net7.StepDefinitions
{
    [Binding]
    public class DataTableWithSQLSteps
    {
        private int UserID;
        private readonly IUserRepository _userRepository;

        private List<User> _usersActual;
        private List<User> _usersExpected;

        public DataTableWithSQLSteps()
        {
            string absoluteProjectFolderPath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, @"..\..\..\Database\"));
            string sqlConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=__ReplaceWithProjectFolder__SampleDB.mdf;Integrated Security=True;Connect Timeout=30";

            sqlConnectionString = sqlConnectionString.Replace("__ReplaceWithProjectFolder__", absoluteProjectFolderPath);
            DbConnection sqlConnection = new SqlConnection(sqlConnectionString);

            this._userRepository = sqlConnection.As<IUserRepository>();
        }

        [Given(@"Validate user data against given data")]
        public void GivenValidateTheFollowingUserData()
        {
        }

        [When(@"the user data is validated against user's data in SQL Database")]
        public void WhenTheUserDataIsValidatedAgainstUsersDataInSQLDatabase(Table table)
        {
            //Using CreateSet Convert the DataTable into a list of User objects
            _usersExpected = table.CreateSet<User>().ToList();
        }

        [When(@"the user data is validated against user's data in SQL Database by rows")]
        public void WhenTheUserDataIsValidatedAgainstUsersDataInSQLDatabaseByRows(Table table)
        {
            _usersExpected = new List<User>();

            foreach (DataTableRow row in table.Rows)
            {
                User user = new User();

                user.UserId = int.Parse(row["UserId"]);
                user.FirstName = row["FirstName"];
                user.LastName = row["LastName"];
                user.PhoneNumber = row["PhoneNumber"];

                _usersExpected.Add(user);
            }
        }

        [Then(@"the database should contain a user with respective PhoneNumber")]
        public async Task ThenTheDatabaseShouldContainAUserWithRespectivePhoneNumber()
        {
            foreach (var user in _usersExpected)
            {
                var userExpected = await _userRepository.GetUserByIdAsync(user.UserId);
                Assert.IsNotNull(userExpected, "User data not found in the database");
                Assert.AreEqual(userExpected.PhoneNumber, user.PhoneNumber, "PhoneNumber does not match.");
            }
        }
    }
}