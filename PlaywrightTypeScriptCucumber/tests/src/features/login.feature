Feature: Login
Scenario: Standard User Login
Given User on the Sauce demo page
When User logs with username and password
Then Should see the Inventory page