using BudgetWebApp.Tests.DataModels;
using FluentAutomation;
using TechTalk.SpecFlow;

namespace BudgetWebApp.Tests.cucumber.steps
{
    //[TestClass]
    //public sealed class MsTestEventHook
    //{
    //    [AssemblyInitialize]
    //    public static void AssemblyInit(TestContext context)
    //    {
    //        //ContextInfo.dbcontext = new NorthwindEntities();
    //        SeleniumWebDriver.Bootstrap(
    //           SeleniumWebDriver.Browser.Firefox
    //       );
    //    }

    //    //[AssemblyCleanup]
    //    //public static void AssemblyCleanup()
    //    //{
    //    //    ContextInfo.dbcontext.Dispose();
    //    //}
    //}

    [Binding]
    public sealed class Hook
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            //ContextInfo.dbcontext = new NorthwindEntities();
            SeleniumWebDriver.Bootstrap(
               SeleniumWebDriver.Browser.Firefox
           );
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //ContextInfo.dbcontext.Dispose();
        }

        [BeforeScenario("RemoveBudgets")]
        public void RemoveBudgets()
        {
            ContextInfo.dbcontext.Budgets.RemoveRange(ContextInfo.dbcontext.Budgets);
            ContextInfo.dbcontext.SaveChanges();
        }

        //[AfterFeature("RemoveBudgets")]
        //public static void RemoveBudgetsAfterFeature()
        //{
        //    ContextInfo.dbcontext.Budgets.RemoveRange(ContextInfo.dbcontext.Budgets);
        //    ContextInfo.dbcontext.SaveChanges();
        //}
    }
}