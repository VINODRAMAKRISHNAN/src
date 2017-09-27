Feature: As a user, I enter values in the first two test boxes and
	hit add button to get the result in the third test box 
	and navigate to the next page	

@mytag
Scenario: Add two numbers in home apge and navigate to about page
	Given I am using "http://localhost:97/"  to navigate to the Home page
	And I have entered 70 into the first text box
	And Then I have entered 80 into the second text box
	When I press add button
	Then the result should be 7080 on the third text box
	When I click on about link on top menu 
	Then I can see the about screen

@mytag
Scenario: Add two numbers in about page and then navigate to contact page
	Given I am using "http://localhost:97/Home/About"  to navigate to the about page
	And I entered 100 into the first text box of the about screen
	And Then I have entered 70 into the second text box of the about screen
	When I press add button  of about screen
	Then the result should be 10071 on the third text box of the about screen
	When I click on contact link on top menu 
	Then I can see the contact screen

@mytag
Scenario: Add two numbers in contact page and finish
	Given I am using "http://localhost:97/Home/Contact"  to navigate to the contact page
	And I entered 200 into the first text box of the contact screen
	And Then I have entered 70 into the second text box of the contact screen
	When I press add button  of contact screen
	Then the result should be 20070 on the third text box of the contact screen
