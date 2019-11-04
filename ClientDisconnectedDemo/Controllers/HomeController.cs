using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace ClientDisconnectedDemo.Controllers
{
    [RoutePrefix("api/foo")]
    public class HomeController : ApiController
    {
        //[Route("")]
        //[HttpGet]
        //public IHttpActionResult Index()
        //{
        //    return Ok();
        //}

        [Route("bar")]
        [HttpPut]
        public async Task<IHttpActionResult> Put()
        {
            await Task.Delay(200);
            return Ok();
        }

        [Route("test")]
        [HttpGet]
        public async Task<IHttpActionResult> GetMethod(CancellationToken cancellationToken)
        {
            await Task.Delay(100, cancellationToken);
            return Ok("value");
        }
    }
}