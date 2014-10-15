using System;

namespace BackendService.Test.Common
{
    using System.Net.Http;

    using Autofac;

    using Microsoft.Owin.Testing;

    public abstract class BackServiceFact : IDisposable
    {
        public BackServiceFact()
        {
            var builder = Bootstrapper.CreateContainerBuilder();
            this.InjectResourceToContainer(builder);
            var startup = new BackendService.Startup().WithContainer(builder.Build());
            this.Server = TestServer.Create(startup.Configuration);
            this.Client = this.Server.HttpClient;
        }

        public TestServer Server { get; private set; }

        public HttpClient Client { get; private set; }


        public void Dispose()
        {
            this.Server.Dispose();
        }

        protected virtual void InjectResourceToContainer(ContainerBuilder builder)
        {
        }
    }
}
