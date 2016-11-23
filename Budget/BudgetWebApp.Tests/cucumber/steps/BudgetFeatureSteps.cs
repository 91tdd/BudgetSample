using BudgetWebApp.Tests.cucumber.steps.PageObjects;
using ExpectedObjects;
using FluentAutomation;
using System.Threading;
using TechTalk.SpecFlow;

namespace BudgetWebApp.Tests.cucumber.steps
{
    [Binding]
    public class BudgetFeatureSteps : FluentTest
    {
        private BudgetPage _budgetPage;

        public BudgetFeatureSteps()
        {
            this._budgetPage = new BudgetPage(this);
        }

        [When(@"I add a buget (.*) for ""(.*)""")]
        public void WhenIAddABugetFor(int amount, string month)
        {
            this._budgetPage.Go()
                .Amount(amount)
                .Month(month)
                .AddBudget();
        }

        [Then(@"there should be a existed record with budget (.*) for ""(.*)""")]
        public void ThenThereShouldBeAExistedRecordWithBudgetFor(int amount, string month)
        {
            //System.Threading.Thread.Sleep(500);
            var dbcontext = ContextInfo.dbcontext;
            var budget = dbcontext.Budgets
            .Find(month);

            var expected = new BudgetWebApp.Tests.DataModels.Budgets { Amount = amount, YearMonth = month };
            expected.ToExpectedObject().ShouldEqual(budget);
            //}
        }
    }
}