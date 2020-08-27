using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModels
{
    public class CustomerViewModel
    {
        public string Name { get; set; }
        public int? Age { get; set; }
        public int Orders { get; set; }
    }
}
