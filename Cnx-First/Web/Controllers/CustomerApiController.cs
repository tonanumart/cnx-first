using Domain.Database;
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
    [RoutePrefix("api/Customers")]
    public class CustomerApiController : ApiController
    {
        public ICustomerService customerService { get; set; }


        [Route("")]
        [HttpGet]
        public IHttpActionResult Get()
        {
            List<CustomerViewModel> customers = customerService.GetCustomers();
            return Ok(customers);
        }

        [Route("{id}")]
        public IHttpActionResult Get(int id)
        {
            CustomerViewModel customer = customerService.GetCustomerById(id);
            return Ok(customer);
        }


        [Route("")]
        [HttpPost]
        public void Post(Customers newCustomer)
        {
            customerService.CreateCustomer(newCustomer);
        }
    }
}