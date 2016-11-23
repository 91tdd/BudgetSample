using System;
using FluentAutomation;

namespace BudgetWebApp.Tests.cucumber.steps.PageObjects
{
    public class BudgetPage : PageObject<BudgetPage>
    {
        public BudgetPage(FluentTest test) : base(test)
        {
            Url = $"{ContextInfo.baseUrl}/budgets/add";
        }

        internal BudgetPage Amount(int amount)
        {
            I.Enter(amount.ToString())
                .In("#Amount");

            return this;
        }

        internal BudgetPage Month(string month)
        {
            I.Enter(month)
                .In("#Month");

            return this;
        }

        internal BudgetPage AddBudget()
        {
            I.Press("{Enter}");

            return this;
        }
    }
}