using Domain.Database;
using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Service
{
    public interface ICustomerService
    {
        List<CustomerViewModel> GetCustomers();
        CustomerViewModel GetCustomerById(int id);
        void CreateCustomer(Customers newCustomer);
        void UpdateCustomer(Customers customer);
        void DeleteCustomer(int id);
    }
}
