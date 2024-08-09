Feature: Basic -> Verify Page Elements and Click Button

@UI
Scenario: UI Testing -> Check C-Sharp Corner Article
	Given I navigate to the C-Sharp Corner article page "https://www.c-sharpcorner.com/article/insight-database-write-less-code-in-data-access-layer-using-auto-interface-imp/"
	When the page has successfully loaded
	Then I should see the header "Insight.Database , .NET Micro ORM - Write Less Code In Data Access Layer Using Auto Interface Implementation"
   

