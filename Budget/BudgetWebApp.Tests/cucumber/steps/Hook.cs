using BudgetWebApp.Tests.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BudgetWebApp.Tests.cucumber.steps
{
    [Binding]
    public sealed class Hook
    {
        public static NorthwindEntities dbcontext;

        [BeforeFeature]
        public static void BeforeFeature()
        {
            dbcontext = new NorthwindEntities();
        }

        [AfterFeature(Order = int.MaxValue)]
        public static void AfterFeature()
        {
            dbcontext.Dispose();
        }

        [BeforeScenario("RemoveBudgets")]
        public void RemoveBudgets()
        {
            dbcontext.Budgets.RemoveRange(dbcontext.Budgets);
            dbcontext.SaveChanges();
        }

        [AfterFeature("RemoveBudgets")]
        public static void RemoveBudgetsAfterFeature()
        {
            dbcontext.Budgets.RemoveRange(dbcontext.Budgets);
            dbcontext.SaveChanges();
        }
    }
}
