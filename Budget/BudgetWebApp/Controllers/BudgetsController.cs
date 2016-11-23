using BudgetWebApp.Models;
using BudgetWebApp.Models.Services;
using System.Web.Mvc;

namespace BudgetWebApp.Controllers
{
    public class BudgetsController : Controller
    {
        private IBudgetService service;

        public BudgetsController()
        {
            this.service = new BudgetService();
        }

        public BudgetsController(IBudgetService service)
        {
            this.service = service;
        }

        // GET: Budgets
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(BudgetModels model)
        {
            //todo, model沒有內容
            this.service.Save(model);
            return View(model);
        }
    }
}