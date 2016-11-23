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
        [When(@"I add a buget (.*) for ""(.*)""")]
        public void WhenIAddABugetFor(int amount, string month)
        {
            I.Open($"{ContextInfo.baseUrl}/budgets/add")
            .Enter(amount).In("#Amount")
            .Enter(month).In("#Month")
            .Press("{Enter}");
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