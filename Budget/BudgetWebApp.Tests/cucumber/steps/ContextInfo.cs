using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudgetWebApp.Tests.DataModels;

namespace BudgetWebApp.Tests.cucumber.steps
{
    public static class ContextInfo
    {
        public static readonly string baseUrl = @"http://localhost:40298";
        internal static NorthwindEntities dbcontext = new NorthwindEntities();
    }
}
