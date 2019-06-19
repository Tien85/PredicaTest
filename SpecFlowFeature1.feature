Feature:Google  Key word search

@mytag

Scenario: search Spec Flow in Google search bar
Given I have entered the Google Home page
And I have entered spec flow into google search bar
When I press search button
Then the result should be a new pages with results for spec flow