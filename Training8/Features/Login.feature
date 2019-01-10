Feature: Login
	As a registered user of Giftrete
	I would liek to log in
	So that I can use the site

@mytag
Scenario:Login to the site
	Given I navigate to the site
	When I click on Login link
	And I enter username
	And I enter password
	And I click on login button
	#Then I am logged in to the site
