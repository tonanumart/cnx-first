using Domain.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModels
{
    public class ProductCustomerViewModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public List<CostomerBuyViewModel> Customers { get; set; }
    }
}
