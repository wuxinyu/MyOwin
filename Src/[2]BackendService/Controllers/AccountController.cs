
namespace BackendService.Controllers
{
    using System;
    using System.Threading.Tasks;
    using System.Web.Http;
    using Biz.Account;

    public class AccountController : ApiController
    {
        private readonly IAccountService accountService;

        public AccountController(IAccountService accountService)
        {
            this.accountService = accountService;
        }

        [HttpPost]
        [Route("api/register")]
        public async Task<IHttpActionResult> Register(UserModel userModel)
        {
            if (this.accountService.Register(userModel))
            {
                return this.Created("api/auth", userModel);                
            }
            else
            {
                return this.BadRequest("user can't register");
            }
        }

        [Route("api/auth")]
        public async Task<IHttpActionResult> Authentication(string resource)
        {
            return this.Ok();
        }
    }
}
