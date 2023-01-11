Feature: Login
Login feature for Next Fire App

@tag1
Scenario: Login to the Next App
	Given I navigate to the WebApp
	And i click on login button
	And I enter email and password
		|   email    |	password	|
		|	admin	 |  password	|
	And i click Submit button
