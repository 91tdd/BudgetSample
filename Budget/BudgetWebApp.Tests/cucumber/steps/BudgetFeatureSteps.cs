using System;
using TechTalk.SpecFlow;

namespace BudgetWebApp.Tests.cucumber.steps
{
    [Binding]
    public class BudgetFeatureSteps
    {
        [When(@"I add a buget (.*) for ""(.*)""")]
        public void WhenIAddABugetFor(int p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"there should be a existed record with budget (.*) for ""(.*)""")]
        public void ThenThereShouldBeAExistedRecordWithBudgetFor(int p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
