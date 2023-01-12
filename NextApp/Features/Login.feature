Feature: Login
Login feature for Next Fire App

@tag1
Scenario: Login to the Next App
	Given I navigate to the WebApp
	And i click on login button
	And I enter email and password
		|   email               |	password	|
		|	test99@gmail.com	|   test@99     |
	And i click Submit button
	And i click on profile button
	Then i click on Logout
