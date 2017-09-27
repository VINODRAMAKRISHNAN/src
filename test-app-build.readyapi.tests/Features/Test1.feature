Feature: Test1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Test Student Rest Api
	Given I have provided REST API request input student entity as in the below table:
	| inputentity                                                                            |
	| {'id':1,'name':'aaa','age':11,'status':true,'stAddress':{'street':'st1','zip':'4000'}} |
	| {'id':2,'name':'aaa2','age':112,'status':true,'stAddress':{'street':'st2','zip':'5000'}} |
	| {'id':3,'name':'aaa3','age':113,'status':true,'stAddress':{'street':'st3','zip':'6000'}} |

	Then I execute POST API and the response result should be validated against the following table:
    | St-id	| St-name	  | St-age    | St-status    | Ad-street    | Ad-zip |
    | 1     | aaa         | 11        | true         | st1          | 4000   | 
	| 2     | aaa2        | 112       | true         | st2          | 5000   | 
	| 3     | aaa3        | 113       | true         | st3          | 6000   | 
	

		
