Feature: LockedOut

@mytag
Scenario: LockedOut
	Given swaglabs page
	When user logined
	Then check if user is locked out