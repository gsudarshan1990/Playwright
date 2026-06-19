Feature: Book Tickets

Scenario: Book Tickets on the Accen Sportz
    Given user is on the Accen SportsPage to book tickets "https://lkmdemoaut.accenture.com/AccenSportz/#/"
    When user click the book tickets in the homepage 
    And user tries to buy ticket by providing "Rajesh","9876831234","rajeshkumar@gmail.com","2"
    Then user buys the ticket
