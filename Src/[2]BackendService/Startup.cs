
using System.Web.Http;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(BackendService.Startup))]
namespace BackendService
{
    using System.Reflection;

    using Autofac;
    using Autofac.Integration.WebApi;

    using Microsoft.Owin.Logging;

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseErrorPage();
            app.UseWelcomePage("/");
            var config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();
            var builder = Bootstrapper.CreateContainerBuilder();
            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
            app.UseAutofacMiddleware(container);
            app.UseAutofacWebApi(GlobalConfiguration.Configuration);            
            app.UseWebApi(config);
        }
    }
}