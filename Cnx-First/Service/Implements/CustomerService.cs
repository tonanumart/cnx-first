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
    public class CustomerService : ICustomerService
    {
        public ExamsEntities entities { get; set; }

        public List<CustomerViewModel> GetCustomers()
        {
            return entities.Customers.Select(s => new CustomerViewModel()
            { 
                Name = s.Name,
                Age = s.Age,
                Orders = s.Orders.Count()
            }).ToList();
        }

        public CustomerViewModel GetCustomerById(int id)
        {
            return entities.Customers.Where(w => w.CustomerID == id).Select(s => new CustomerViewModel()
            {
                Name = s.Name,
                Age = s.Age,
                Orders = s.Orders.Count
            }).FirstOrDefault();
        }

        public void CreateCustomer(Customers newCustomer)
        {
            bool existName = entities.Customers.Where(w => w.Name == newCustomer.Name).FirstOrDefault() != null;
            if (!existName)
            {
                var lastestId = entities.Customers.Max(m => m.CustomerID);
                newCustomer.CustomerID = lastestId + 1;
                entities.Customers.Add(newCustomer);
                entities.SaveChanges();
            }
        }

        public void UpdateCustomer(Customers customer)
        {
            entities.Entry(customer).State = System.Data.Entity.EntityState.Modified;
            entities.SaveChanges();
        }

        public void DeleteCustomer(int id)
        {
            var customer = entities.Customers.Find(id);
            entities.Customers.Remove(customer);
        }
    }
}
