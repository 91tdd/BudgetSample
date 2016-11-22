using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BudgetWebApp.Startup))]
namespace BudgetWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
