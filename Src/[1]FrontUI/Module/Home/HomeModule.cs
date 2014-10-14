
namespace FrontUI.Module.Home
{
    using Nancy;

    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            this.Get["/"] = _ =>
            {
                var model = new { title = "We've Got Issues..." };
                return this.View["home", model];
            };
        }
    }
}