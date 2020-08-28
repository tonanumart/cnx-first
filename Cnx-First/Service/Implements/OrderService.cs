using Domain.Database;
using Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implements
{
    public class OrderService : IOrderService
    {
        public ExamsEntities entities { get; set; }

        public void EditOrderDetailQuantity(string orderId, int productId, int newQuantity)
        {
            var orderDetail = entities.OrderDetails
                .Where(w => w.OrderID == orderId
                    && w.ProductID == productId)
                .FirstOrDefault();
            if (orderDetail == null) return;


            orderDetail.Quantity = newQuantity;
            if(orderDetail.Quantity == 0)
            {
                entities.OrderDetails.Remove(orderDetail);
                var zeroOrderDetails = entities.Orders
                .Select(s => s.OrderDetails.ToList())
                .ToList();

                var order = entities.Orders
                    .Where(w => w.OrderID == orderId)
                    .FirstOrDefault();
                var isZeroOrderDetail = order.OrderDetails.ToList().Count == 0;
                if(isZeroOrderDetail)
                {
                    entities.Orders.Remove(order);
                }
            }
            
            entities.SaveChanges();
        }
    }
}
