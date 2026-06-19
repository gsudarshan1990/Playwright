Feature: Player Registration

Scenario: Register on the Accen Sportz
    Given user is on the Accen SportsPage "https://lkmdemoaut.accenture.com/AccenSportz/#/"
    When user clicks the register button 
    And user enters the details like "Ramesh", "kumar", "01/02/1982","8746489876", "Male","Hockey", "Basketball","Hyderabad India", "800082"
    Then user should be able to register