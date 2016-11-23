using BudgetWebApp.Tests.cucumber.steps.PageObjects;
using BudgetWebApp.Tests.DataModels;
using FluentAutomation;
using NUnit.Framework;
using System.Linq;
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
            using (var dbcontext = new NorthwindEntities())
            {
                var count = dbcontext.Budgets.Count();
                Assert.AreEqual(1, count);
            }
        }
    }
}