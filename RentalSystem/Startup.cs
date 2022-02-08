using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RentalSystem.Startup))]
namespace RentalSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
