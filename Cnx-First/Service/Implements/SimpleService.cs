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
        public List<OrderViewModel> GetOrders()
        {
            var entity = new ExamsEntities();
            var orderList = entity.Orders.Select(s => new OrderViewModel
            {
                OrderId = s.OrderID,
                OrderDate = s.OrderDate,
                CustomerId = s.CustomerID,
                CustomerName = s.Customers.Name
            }).ToList();

            return orderList;
        }
    }
}
