using BudgetWebApp.Tests.DataModels;
using FluentAutomation;
using TechTalk.SpecFlow;
using System.Linq;
using NUnit.Framework;

namespace BudgetWebApp.Tests.cucumber.steps
{
    //todo: 1. login tag for hook
    //todo: 2. host web application before running testing
    //todo: 3. 
    [Binding]
    public class BudgetFeatureSteps : FluentTest
    {
        public BudgetFeatureSteps()
        {
            //System.setProperty("webdriver.chrome.driver", "D:\\chromedriver.exe");
            //ChromeOptions options = new ChromeOptions();
            //options.addArguments("--disable-extensions");
            //driver = new ChromeDriver(options);
            
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
            .Enter(amount).In("#amount")
            .Enter(month).In("#month")
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