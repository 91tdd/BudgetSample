using BudgetWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BudgetWebApp.Controllers
{
    public class BudgetsController : Controller
    {
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
            return View(model);
        }
    }
}