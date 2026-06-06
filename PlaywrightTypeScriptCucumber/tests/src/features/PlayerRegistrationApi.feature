Feature: Player Registration

Scenario: Post User Details
    When Register a new user with AccenSportz.
    Then Response should be successful for the post request

Scenario: Get User Details
    When Retrieve user details from AccenSportz.
    Then Response should be successful for the get request

Scenario: Update user Details
    When Update the user with AccenSportz.
    Then Response should be successful for the put request

Scenario: Delete user
    When Delete the user associated with AccenSportz.
    Then Response should be successful for the delete request
