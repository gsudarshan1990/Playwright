Feature: on the Demo web shop

Scenario: Login to the Demo Web Shop
    Given user on the "https://demowebshop.tricentis.com/"
    When Navigate to the login page
    When user enters the username "yugramayan@example.com"
    When user enters the password "Test@123"
    Then user logs in