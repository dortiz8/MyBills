using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyBills.Startup))]
namespace MyBills
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
