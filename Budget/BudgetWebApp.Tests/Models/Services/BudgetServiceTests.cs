//using Microsoft.VisualStudio.TestTools.UnitTesting;
using BudgetWebApp.Tests.DataModels;
using NUnit.Framework;
using System.Linq;

namespace BudgetWebApp.Models.Services.Tests
{
    [TestFixture]
    public class BudgetServiceTests
    {
        [Test()]        
        public void SaveTest_for_integration_test()
        {
            using (var dbcontext = new NorthwindEntities())
            {
                dbcontext.Budgets.RemoveRange(dbcontext.Budgets);
                dbcontext.SaveChanges();

                var model = new BudgetModels() { Amount = 100, Month = "2017-10" };
                var target = new BudgetService();

                target.Save(model);

                var o = dbcontext.Budgets.Where(x => x.YearMonth == "2017-10").SingleOrDefault();
                Assert.IsNotNull(o);
            }
        }
    }
}