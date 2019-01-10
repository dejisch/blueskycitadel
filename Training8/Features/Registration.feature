Feature: Registration
	As a user of the site
	I want to register
	So that I can use the site

@mytag
Scenario: Navigating to Registration Page
	Given I navigate to the site
	When I click on register button
	Then I am on the registration page


Scenario: Registration of users
	Given I navigate to the site
	When I click on register button
	And I am on the registration page
	And I fill the form
	Then I am registered