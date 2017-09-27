Feature: As a user, I enter testsuite and testcase and will test the REST API	

@mytag
Scenario: Test Rest Api
	Given I am using testsuite as "TestSuite 1"  
	And I am using testcase as  "TestCase 2"  
	When I submit the request
	Then the result would capture any error messages 
	
