using BudgetWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BudgetWebApp.Models.Services;

namespace BudgetWebApp.Controllers
{
    public class BudgetsController : Controller
    {
        private IBudgetService service;
        public BudgetsController()
        {

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
        public ActionResult Add( BudgetModels model)
        {
            this.service.Save(model);
            return View(model);
        }
    }
}