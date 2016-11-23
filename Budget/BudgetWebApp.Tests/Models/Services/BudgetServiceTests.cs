//using Microsoft.VisualStudio.TestTools.UnitTesting;
using BudgetWebApp.Tests.DataModels;
using ExpectedObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//using NUnit.Framework;

namespace BudgetWebApp.Models.Services.Tests
{
    [TestClass]
    public class BudgetServiceTests
    {
        //private static BudgetWebApp.Tests.DataModels.NorthwindEntities dbcontext = new BudgetWebApp.Tests.DataModels.NorthwindEntities();

        [TestInitialize]
        public void TestInit()
        {
            using (var dbcontext = new NorthwindEntities())
            {
                dbcontext.Budgets.RemoveRange(dbcontext.Budgets);
                dbcontext.SaveChanges();
            }
        }

        [TestCleanup]
        public void TestCleanup()
        {
            using (var dbcontext = new NorthwindEntities())
            {
                dbcontext.Budgets.RemoveRange(dbcontext.Budgets);
                dbcontext.SaveChanges();
            }
        }

        [TestMethod]
        [Ignore]
        public void SaveTest_for_integration_test()
        {
            var model = new BudgetModels() { Amount = 100, Month = "2017-11" };
            var target = new BudgetService();

            target.Save(model);

            using (var dbcontext = new NorthwindEntities())
            {
                var o = dbcontext.Budgets
                    .Find("2017-11");
                var expected = new BudgetWebApp.Tests.DataModels.Budgets { Amount = 100, YearMonth = "2017-11" };
                expected.ToExpectedObject().ShouldEqual(o);
            }
        }
    }
}