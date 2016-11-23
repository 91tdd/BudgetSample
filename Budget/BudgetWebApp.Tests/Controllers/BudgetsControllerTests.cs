using BudgetWebApp.Models;
using BudgetWebApp.Models.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System.Linq;

namespace BudgetWebApp.Controllers.Tests
{
    [TestClass()]
    public class BudgetsControllerTests
    {        
        [TestMethod()]
        public void AddTest_should_add_a_budget_record()
        {
            var service = Substitute.For<IBudgetService>();
            var target = new BudgetsController(service);

            var model = new BudgetModels();
            target.Add(model);

            service.Received().Save(model);
        }

        //[TestCategory("integration")]
        //[TestMethod]
        //public void AddTest_should_add_a_budget_record_by_BudgetService()
        //{
        //    var service = new BudgetService();
        //    var target = new BudgetsController(service);

        //    var model = new BudgetModels() { Amount = 100, Month = "2017-03" };
        //    target.Add(model);

        //    using (var dbcontext = new BudgetWebApp.Tests.DataModels.NorthwindEntities())
        //    {
        //        var budget = dbcontext.Budgets.Where(x => x.YearMonth == "2017-03").SingleOrDefault();
        //        Assert.IsNotNull(budget);
        //    }
        //}
    }
}