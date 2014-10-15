
using System.Web.Http;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(BackendService.Startup))]
namespace BackendService
{
    using Autofac;
    using Autofac.Integration.WebApi;

    public class Startup
    {
        private readonly HttpConfiguration configuration;

        private IContainer container;

        public Startup()
        {
            this.configuration = new HttpConfiguration();
            this.configuration.MapHttpAttributeRoutes();
            var builder = Bootstrapper.CreateContainerBuilder();
            var defaultContainer = builder.Build();
            this.WithContainer(defaultContainer);
        }

        public Startup WithContainer(IContainer injectedContainer)
        {
            this.container = injectedContainer;
            this.configuration.DependencyResolver = new AutofacWebApiDependencyResolver(injectedContainer);
            return this;
        }

        public void Configuration(IAppBuilder app)
        {
            app.UseErrorPage();
            app.UseWelcomePage("/");
            app.UseAutofacMiddleware(this.container);
            app.UseWebApi(this.configuration);
        } 
    }
}