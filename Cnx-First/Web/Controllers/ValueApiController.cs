using Domain.Interfaces.Service;
using Domain.ViewModels;
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
            var customerOrders = Service.GetCustomerOrder();
            return Ok(customerOrders);
        }

        [Route("saveorder")]
        public IHttpActionResult Post([FromBody] SaveOrderViewModel customerOrders)
        {
            Service.SaveOrder(customerOrders);
            return Ok();
        }
    }
}
