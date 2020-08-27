using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModels
{
    public class OrderViewModel
    {
        public string OrderId { get; set; }
        public DateTime? OrderDate { get; set; }
        public int? TotalItem { get; set; }
        public int? TotalPrice { get; set; }
        public List<OrderDetailViewModel> Details { get; set; }
    }
}
