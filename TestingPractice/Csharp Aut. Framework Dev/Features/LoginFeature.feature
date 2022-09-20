Feature: LoginFeature

Feature to test login functionality

@tag1
Scenario: Login Scenario
	Given Login to the  Application 
	And I click on  Login Link
	When user enters username and pwd
	When user clicks the  submit
	Then it should navigates to the login page