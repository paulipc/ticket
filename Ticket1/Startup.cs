using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ticket1.Startup))]
namespace Ticket1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
