﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ems.domain.ViewModels
{
    public class ServiceExpenseViewModel: ServiceExpense
    {
        public string gstName { get; set; }
        public string SerExpTypeDesc { get; set; }
    }
}
