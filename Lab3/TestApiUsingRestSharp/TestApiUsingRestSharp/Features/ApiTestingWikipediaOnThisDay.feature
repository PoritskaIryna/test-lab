Feature: Testing Web API Wikipedia on this day

  Scenario: Get a list of events that occured on this date in the past
    Given Create Get a list of events request "/2/2/events.json"
    When Send a Get a list of events request
    Then the Get a list of events response status code should be 200
    And the response should contain the list of events

  Scenario: Get a list of deaths that occured on this date in the past 
    Given create Get a list of deaths request "/2/2/deaths.json"
    When Send a Get a list of deaths request
    Then the Get a list of deaths response status code should be 200
    And the response should contain then list of deaths

  Scenario: Get a list of births that occured on this date in the past 
    Given create Get a list of births request "/2/2/births.json"
    When Send a Get a list of births request
    Then the Get a list of births response status code should be 200
    And the response should contain the list of births

