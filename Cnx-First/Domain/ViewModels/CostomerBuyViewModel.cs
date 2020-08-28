using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModels
{
    public class CostomerBuyViewModel
    {
        public int CustomerId { get; set; }

        public string CustomerName { get; set; }
        public DateTime? BuyDate { get; set; }
    }
}
