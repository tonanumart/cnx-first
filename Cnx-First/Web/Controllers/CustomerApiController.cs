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
    [Route("api/Customers")]
    public class CustomerApiController : ApiController
    {
        public ICustomerService customerService { get; set; }
        // GET api/<controller>
        public IHttpActionResult Get()
        {
            List<CustomerViewModel> customers = customerService.GetCustomers();
            return Ok(customers);
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            CustomerViewModel customer = customerService.GetCustomerById(id);
            return Ok(customer);
        }

        // POST api/<controller>
        public void Post([FromBody] Customers customers)
        {
            customerService.CreateCustomer(customers);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}