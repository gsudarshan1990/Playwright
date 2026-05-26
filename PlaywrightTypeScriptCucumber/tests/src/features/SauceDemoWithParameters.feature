Feature: Sauce Demo Implementation with Parameters

Scenario: Login to the applicaiton
    Given User Navigates to the url "https://www.saucedemo.com"
    When User enters the username "standard_user"
    And User enters the password "secret_sauce"
    Then user logins to the application
