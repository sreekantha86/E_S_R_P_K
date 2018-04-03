using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ems.domain
{
    public class ServiceIncomeDT
    {
        public int SerInvRowId { get; set; }
        public int slNo { get; set; }
        public string SAC { get; set; }
        public int? SerInvId { get; set; }
        public int? SerId { get; set; }
        public string RowRemarks { get; set; }
        public decimal Amount { get; set; }
        public decimal GSTPer { get; set; }
        public decimal SGSTPer { get; set; }
        public decimal SGSTAmount { get; set; }
        public decimal CGSTPer { get; set; }
        public decimal CGSTAmount { get; set; }
        public decimal IGSTAmount { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
