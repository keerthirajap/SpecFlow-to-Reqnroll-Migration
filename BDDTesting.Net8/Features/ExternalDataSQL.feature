﻿Feature: ExternalData -> Validate ETL Process Loads User Data Correctly

Background:

@DATA
@DataSource:ExternalDataSQL_UsersData.xlsx @DataSet:Users
Scenario: ExternalData -> Validate user data against Excel file
	Given the Excel file contains user data for user <UserId>
	When the user data is validated against the Excel file with SQL Database
	Then the database should contain a user with UserId <UserId> and correct PhoneNumber <PhoneNumber>


