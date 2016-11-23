using BudgetWebApp.Models.edmx;

namespace BudgetWebApp.Models.Services
{
    public class BudgetService : IBudgetService
    {
        public BudgetService()
        {
        }

        public void Save(BudgetModels model)
        {
            using (var dbcontext = new NorthwindEntitiesProd())
            {
                var budget = new Budgets { Amount = model.Amount, YearMonth = model.Month };
                dbcontext.Budgets.Add(budget);

                dbcontext.SaveChanges();
            }
        }
    }
}