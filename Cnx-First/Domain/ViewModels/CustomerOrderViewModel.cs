using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModels
{
    public class CustomerOrderViewModel
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public List<OrderViewModel> Orders { get; set; }
    }
}
