using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EqipmentAdmin.Startup))]
namespace EqipmentAdmin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
