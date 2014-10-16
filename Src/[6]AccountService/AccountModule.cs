
namespace AccountService
{
    using Nancy;

    public class AccountModule : NancyModule
    {
        public AccountModule()
        {
            this.Get["/login"] = _ => this.View["login"];
        }
    }
}