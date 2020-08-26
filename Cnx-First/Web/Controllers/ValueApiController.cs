using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Web.Controllers
{
    [RoutePrefix("api/value")]
    public class ValueApiController : ApiController
    {
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(new string[]
            {
               "test","test2"
            });
        }
    }
}
