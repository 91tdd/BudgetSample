@RemoveBudgets
Feature: BudgetFeature


Scenario: Add a budget for unique month	
	When I add a buget 2000 for "2017-10"
	Then there should be a existed record with budget 2000 for "2017-10"


Scenario: Add a budget for unique month	second
	When I add a buget 2000 for "2018-10"
	Then there should be a existed record with budget 2000 for "2018-10"