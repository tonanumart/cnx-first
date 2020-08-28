using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Service
{
    public interface ISimpleService
    {
        List<OrderViewModel> GetOrders();
        List<CustomerOrderViewModel> GetCustomerOrder();
        void SaveOrder(SaveOrderViewModel customer);
        List<ProductCustomerViewModel> GetProducts();
        void EditOrderDetailQuantity(string orderId, int productId, int newQuantity);
    }
}
