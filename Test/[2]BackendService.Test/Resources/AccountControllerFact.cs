
namespace BackendService.Test.Resources
{
    using System.Net;
    using BackendService.Test.Common;
    using Biz.Account;

    using Newtonsoft.Json;

    using Xunit;

    public class AccountControllerFact : BackServiceFact
    {
        [Fact]
        public void as_anonymous_when_call_register_api_then_return_ok()
        {
            var user = new UserModel() { UserName = "wxy", Password = "111" };
            var rep = Client.PostAsync("/api/register", user.ToGeneralJsonContent()).Result;
            Assert.Equal(HttpStatusCode.Created, rep.StatusCode);
        }
    }
}
