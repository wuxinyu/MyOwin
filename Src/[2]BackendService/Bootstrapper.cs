
namespace BackendService
{
    using System.Reflection;
    using Autofac;
    using Autofac.Integration.WebApi;
    using Biz.Account;

    public class Bootstrapper
    {
        public static ContainerBuilder CreateContainerBuilder()
        {
            var builder = new ContainerBuilder();
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterType<AccountService>().As<IAccountService>();
            return builder;
        }
    }
}