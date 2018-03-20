using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ems.domain.ViewModels
{
    public class ServiceIncome
    {
        public ServiceIncomeHD HeadModel { get; set; }
        public List<ServiceIncomeDT> ItemsModel { get; set; }
    }
}
