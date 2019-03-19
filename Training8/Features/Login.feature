Feature: Login
	As a registered user of Giftrete
	I would like to log in
	So that I can use the site

@mytag
Scenario:Invalid Login to the site
	Given I navigate to the site
	When I click on Login link
	And I enter username
	And I enter password
	And I click on login button
	Then I am not logged in to the site
