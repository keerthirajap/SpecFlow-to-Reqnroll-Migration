Feature: Examples -> IP Address Type Check

@API
Scenario Outline: Examples -> Verify IP address type with RestSharpAPI 
	Given I send a request to check the IP address "<ip_address>"
	Then the response should indicate that the IP address is of type "<expected_type>"

Examples:
	| ip_address                              | expected_type |
	| 24.48.0.1                               | IPv4          |
	| 2401:4900:1c29:6e64:f56f:78c1:95d5:a48d | IPv6          |
	| 8.8.8.8                                 | IPv4          |
	| 2001:4860:4860::8888                    | IPv6          |
	| 172.217.14.206                          | IPv4          |
