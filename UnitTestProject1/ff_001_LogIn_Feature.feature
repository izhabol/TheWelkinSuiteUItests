Feature: LogIn_Feature
 	In order to access my account
 	As a user of TWS IDE
 	I want to log into TWS
 	 
 	@mytag
 	Scenario: Successful Login with Valid Credentials
 	Given User is at the Login Window
 	When User enter UserName and Password
 	And Click on the LogIn button
 	Then Successful LogIN message should display
 	 
 	Scenario: Successful LogOut
 	Given User is logged in
 	When User LogOut from the Application
 	Then Successful LogOut message should display