using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ems.domain
{
    public class ServiceIncomeHD
    {
        public int SerInvId { get; set; }
        public string SerInvPrefix { get; set; }
        public int SerInvNo { get; set; }
        public DateTime SerInvDate { get; set; }
        public string SerinvJobNo { get; set; }
        public string SerInvItems { get; set; }
        public string SerInvSEBENo { get; set; }
        public DateTime SerInvSEBEDate { get; set; }
        public string SerInvNoContaier { get; set; }
        public string SerInvInvoiceNo { get; set; }
        public DateTime? SerInvInvoiceDate { get; set; }
        public string SerInvNoPackages { get; set; }
        public string SerInvBLNo { get; set; }
        public DateTime? SerInvBLDate { get; set; }
        public string SerDescription { get; set; }
        public int CusId { get; set; }
        public decimal SerInvTotalAmount { get; set; }
        public decimal SerInvTotalCGST { get; set; }
        public decimal SerInvTotalSGST { get; set; }
        public decimal SerInvDeduction { get; set; }
        public string SerInvDeductionRemark { get; set; }
        public decimal SerInvNetPayable { get; set; }
        public string SerInvRemarks { get; set; }
        public DateTime SerInvDueDate { get; set; }
        public int ComanyId { get; set; }
        public int FyID { get; set; }
    }
}
