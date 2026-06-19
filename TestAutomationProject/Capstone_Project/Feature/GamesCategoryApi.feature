Feature: Games Category

Scenario: Bearer Token
    When user generates the bearer token.This REST API endpoint is secured and requires 'Authentication' for access.
    Then Response should be successful for the get request for bearer token

Scenario: Get All games
    When Retrieves the list of all the games available on AccenSportz
    Then Response should be successful for the get request related to all the games

Scenario: Specific Category
    When Retrieve the list of games associated with a specific category
    Then Response should be successful for the post request for specific category
