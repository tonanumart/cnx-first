using Domain.Database;
using Domain.Interfaces.Service;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implements
{
    public class SimpleService : ISimpleService
    {
        ExamsEntities entities { get; set; }
        public List<OrderViewModel> GetOrders()
        {
            var orderList = entities.Orders.Select(s => new OrderViewModel()
            {
                OrderId = s.OrderID,
                OrderDate = s.OrderDate
            }).ToList();

            return orderList;
        }



        public List<CustomerOrderViewModel> GetCustomerOrder() 
        {
            var customerOrderList = entities.Customers.Select(s => new CustomerOrderViewModel()
            {
                CustomerId = s.CustomerID,
                CustomerName = s.Name,
                Orders = s.Orders.Select(se => new OrderViewModel()
                {
                    OrderId = se.OrderID,
                    OrderDate = se.OrderDate,
                    TotalItem = se.OrderDetails.Sum(item => item.Quantity),
                    TotalPrice = se.OrderDetails.Sum(item => item.Products.Price * item.Quantity),
                    Details = se.OrderDetails.Select(sel => new OrderDetailViewModel()
                    {
                        ProductName = sel.Products.Name,
                        Quantity = sel.Quantity,
                        UnitPrice = sel.Products.Price
                    }).ToList()
                }).ToList(),
            }).ToList();

            return customerOrderList;
        }



        public void SaveOrder(SaveOrderViewModel customerOrders)
        {
            var test = new ExamsEntities();
            var customer = test.Customers.Find(int.Parse(customerOrders.CustomerId));
            if (customer == null)
            {
                int lastestId = entities.Customers.Max(m => m.CustomerID);
                customer = new Customers()
                {
                    CustomerID = lastestId + 1
                };
                entities.Customers.Add(customer);
            }

            var order = new Orders()
            {
                OrderID = OrderIdGenerate(),
                CustomerID = customer.CustomerID,
                OrderDate = System.DateTime.Now
            };

            var orderDetailList = new List<OrderDetails>();
            for(int index = 0; index < customerOrders.BuyItems.Count; index++)
            {
                var buyItems = customerOrders.BuyItems[index];
                var orderDetail = new OrderDetails()
                {
                    OrderID = order.OrderID,
                    Quantity = buyItems.Qty,
                    ProductID = buyItems.ProductId
                };
                orderDetailList.Add(orderDetail);
            }

            order.OrderDetails = orderDetailList;
            customer.Orders.Add(order);
            entities.SaveChanges();
        }




        private string OrderIdGenerate()
        {
            var lastestOrderId = entities.Orders.OrderByDescending(o => o.OrderDate).Select(s => s.OrderID).FirstOrDefault();
            if (lastestOrderId == null) lastestOrderId = "B000";
            var prefixOrderId = lastestOrderId.Substring(0, lastestOrderId.Length - 1);
            var orderIdConcatNumber = int.Parse(lastestOrderId.Substring(lastestOrderId.Length - 1));
            return prefixOrderId + orderIdConcatNumber.ToString();
        }
    }
}
