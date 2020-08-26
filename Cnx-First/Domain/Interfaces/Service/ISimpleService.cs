﻿using Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Service
{
    public interface ISimpleService
    {
        List<OrderViewModel> GetOrders();
    }
}
