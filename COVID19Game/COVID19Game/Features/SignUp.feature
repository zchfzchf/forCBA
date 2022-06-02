Feature: Sign Up

User can sign up a new account with required information

@UI
Scenario: User can sign up a new account
	Given I am on the homepage
	And I click the Register button
	When I enter the "<username>"
	And I also enter the "<password>"
	And I repeat "<rp_password>"
	And I click Sign Up button
	Then I sign up successfully to see the Login prompt
Examples:
	| username   | password | rp_password |
	| user111268 | abcdef   | abcdef      |
