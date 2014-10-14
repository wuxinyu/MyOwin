
namespace BackendService.Test.Resources
{
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Web.Http;

    using Autofac;
    using Autofac.Integration.WebApi;

    using Biz.Account;

    using Microsoft.Owin.Testing;

    using Newtonsoft.Json;

    using Owin;

    using Xunit;

    public class AccountControllerFact
    {
        [Fact]
        public void as_anonymous_when_call_register_api_then_return_ok()
        {
            using (var server = TestServer.Create<BackendService.Startup>())
            {
                var user = new UserModel() { UserName = "wxy", Password = "111" };
                var json = JsonConvert.SerializeObject(user);
                var content = new StringContent(json);
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var rep = server.HttpClient.PostAsync("/api/register", content).Result;
                Assert.Equal(HttpStatusCode.Created, rep.StatusCode);
            }
        }
    }
}
