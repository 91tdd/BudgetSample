Feature: BudgetFeature
	


Scenario: Add a budget for unique month	
	When I add a buget 1000 for "2017-10"
	Then there should be a existed record with budget 1000 for "2017-10"
