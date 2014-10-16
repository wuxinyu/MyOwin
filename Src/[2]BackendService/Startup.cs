
using System.Web.Http;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(BackendService.Startup))]
namespace BackendService
{
    using System;
    using System.Linq;
    using System.Net.Http.Formatting;

    using Autofac;
    using Autofac.Integration.WebApi;

    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.Owin;
    using Microsoft.Owin.Security.Cookies;

    using Newtonsoft.Json.Serialization;

    public class Startup
    {
        private readonly HttpConfiguration configuration;

        private IContainer container;

        public Startup()
        {
            this.configuration = new HttpConfiguration();
            var jsonFormat = this.configuration.Formatters.OfType<JsonMediaTypeFormatter>().First();
            jsonFormat.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
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