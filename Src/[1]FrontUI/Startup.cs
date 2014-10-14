
using Microsoft.Owin;

[assembly: OwinStartup(typeof(FrontUI.Startup))] 
namespace FrontUI
{
    using Owin;

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseNancy();
        }
    }
}