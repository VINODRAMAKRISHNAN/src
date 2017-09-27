Feature: NF1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbersUnitTest
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	And You have entered 80 into the calculator
	When I press add
	Then the result should be 300 on the screen
