using Domain.Interfaces.Service;
using Service.Implements;
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
        public ISimpleService Service { get; set; }

        [Route("")]
        public IHttpActionResult Get()
        {
            Service = new SimpleService();
            var orders = Service.GetOrders();
            return Ok(orders);
        }
    }
}
