using Domain.Interfaces.Service;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Web.Controllers
{

    [RoutePrefix("api/orders")]
    public class OrderApiController : ApiController
    {
        public IOrderService OrderService { get; set; }
        public ISimpleService Service { get; set; }


        [HttpPost]
        [Route("saveorder")]
        public IHttpActionResult Post([FromBody] SaveOrderViewModel customerOrders)
        {
            Service.SaveOrder(customerOrders);
            return Ok();
        }



        [HttpPost]
        [Route("EditOrderDetail")]
        public IHttpActionResult Edit([FromBody] EditOrderDetailQuantityViewModel orderDetail)
        {
            OrderService.EditOrderDetailQuantity(
                orderDetail.OrderId,
                orderDetail.ProductId,
                orderDetail.NewQuantity
            );
            return Ok();
        }
    }
}