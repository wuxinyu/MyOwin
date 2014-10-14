using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BackendService.Controllers
{
    using System.Threading.Tasks;
    using System.Web.Http.Results;

    public class EchoController : ApiController
    {

        [HttpGet]
        [Route("api/echo")]
        public async Task<IHttpActionResult> Echo()
        {
            
            return this.Ok();
        }
    }
}
