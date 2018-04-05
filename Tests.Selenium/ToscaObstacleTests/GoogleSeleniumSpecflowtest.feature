#This is the default step class name
Feature: Basic Google Search
	In order to find stuff on the web
	As a google user
	I want to to search for stuff

Scenario: Search for Something with Google
	Given I want to search with Google
	When When I search for "freemansoft"
	Then That should be in the title bar

Scenario: Search for Something with Microsoft
	Given I want to search with Bing
	When When I search for "freemansoft"
	Then That should be in the title bar




Scenario: Complete Obstacle 81121 AGAIN AND AGAIN AND AGAIN
	Given I navigate to obstacle 81121 on tricentis
	When I click on the click me button until it changes to enough
	And I click on enough when displayed
	Then I see the good job success message


	Scenario: Complete Obstacle 87361 SMART BUTTON
	Given I navigate to obstacle 87361 on tricentis
	When I click on the click me first button
	And I click on then click me button
	Then I see the good job success message

	