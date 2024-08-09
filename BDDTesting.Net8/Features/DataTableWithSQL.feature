Feature: DataTable -> Validate ETL Process Loads User Data Correctly

A short summary of the feature

@DATA
Scenario: Validate user data against given data DataTable (CreateSet)
	Given Validate user data against given data		
	When the user data is validated against user's data in SQL Database
		| UserId | FirstName | LastName | PhoneNumber |
		| 1      | John      | Doe      | 555-0101    |
		| 2      | Jane      | Smith    | 555-0102    |
	Then the database should contain a user with respective PhoneNumber
 

 Scenario: Validate user data against given data DataTable (Rows)
	Given Validate user data against given data		
	When the user data is validated against user's data in SQL Database by rows
		| UserId | FirstName | LastName | PhoneNumber |
		| 1      | John      | Doe      | 555-0101    |
		| 2      | Jane      | Smith    | 555-0102    |
	Then the database should contain a user with respective PhoneNumber