Feature: Login

User can use the correct username and password to login.

@UI
Scenario: User Login
	Given I am on the homepage
	And I click the Login button
	When I enter the "<username>" on Login
	And I also enter the "<password>" on Login
	And I click Login warrior button
	Then I can start the game
Examples:
	| username   | password |
	| 1234567890 | 1        |
