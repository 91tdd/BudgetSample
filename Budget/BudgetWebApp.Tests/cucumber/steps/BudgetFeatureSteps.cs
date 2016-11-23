using BudgetWebApp.Tests.DataModels;
using FluentAutomation;
using NUnit.Framework;
using System.Linq;
using TechTalk.SpecFlow;

namespace BudgetWebApp.Tests.cucumber.steps
{
    //todo: 1. login tag for hook
    //todo: 2. host web application before running testing
    //todo: 3.
    [Binding]
    public class BudgetFeatureSteps : FluentTest
    {
        //[BeforeScenario]
        //public void BeforeScenario()
        //{
        //    using (var dbcontext = new NorthwindEntities())
        //    {
        //        var budgets = dbcontext.Budgets;
        //        dbcontext.Budgets.RemoveRange(budgets);

        //        dbcontext.SaveChanges();
        //    }
        //}

        public BudgetFeatureSteps()
        {
            SeleniumWebDriver.Bootstrap(
               SeleniumWebDriver.Browser.Firefox
           );
        }

        //todo, add a middle layer of driver
        [When(@"I add a buget (.*) for ""(.*)""")]
        public void WhenIAddABugetFor(int amount, string month)
        {
            var baseUrl = @"http://localhost:40298";

            I.Open($"{baseUrl}/budgets/add")
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