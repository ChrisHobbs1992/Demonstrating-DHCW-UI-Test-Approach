Feature: DHCWTabNavigation

A short summary of the feature

@US_Example
Scenario: Navigate between tabs on DHCW site
	Given I am on the DHCW Website
	Then I should be on the 'home' page
	When I click the 'home' upper ribbon tab
	Then I can see the DHCW Motto