using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DuyVu.Startup))]
namespace DuyVu
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
