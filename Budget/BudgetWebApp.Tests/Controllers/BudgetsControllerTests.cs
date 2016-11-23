using BudgetWebApp.Models;
using BudgetWebApp.Models.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

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
    }
}