using Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Web.Controllers
{
    [RoutePrefix("api/products")]
    public class ProductApiController : ApiController
    {
        public ISimpleService Service { get; set; }

        [Route("")]
        public IHttpActionResult Get()
        {
            var products = Service.GetProducts();
            return Ok(products);
        }
    }
}