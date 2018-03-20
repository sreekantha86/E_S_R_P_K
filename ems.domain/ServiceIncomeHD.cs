using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required(ErrorMessage = "Invoice Date is required")]
        [Display(Name = "Invoice Date")]
        public DateTime SerInvDate { get; set; }
        [Display(Name = "Job No")]
        public string SerinvJobNo { get; set; }
        [Display(Name = "Invoice Items")]
        public string SerInvItems { get; set; }
        [Display(Name = "")]
        public string SerInvSEBENo { get; set; }
        [Display(Name = "")]
        public DateTime SerInvSEBEDate { get; set; }
        [Display(Name = "No. Of Containters")]
        public string SerInvNoContaier { get; set; }
        [Display(Name = "")]
        public string SerInvInvoiceNo { get; set; }
        [Display(Name = "")]
        public DateTime? SerInvInvoiceDate { get; set; }
        [Display(Name = "")]
        public string SerInvNoPackages { get; set; }
        [Display(Name = "BL No.")]
        public string SerInvBLNo { get; set; }
        [Display(Name = "BL Date")]
        public DateTime? SerInvBLDate { get; set; }
        [Display(Name = "Remarks")]
        public string SerDescription { get; set; }
        [Display(Name = "Customer")]
        public int CusId { get; set; }
        [Display(Name = "Total Amount")]
        public decimal SerInvTotalAmount { get; set; }
        [Display(Name = "Total CGST")]
        public decimal SerInvTotalCGST { get; set; }
        [Display(Name = "Total SGST")]
        public decimal SerInvTotalSGST { get; set; }
        [Display(Name = "Total IGST")]
        public decimal SerInvTotalIGST { get; set; }
        [Display(Name = "Deduction")]
        public decimal SerInvDeduction { get; set; }
        [Display(Name = "Deduction Remarks")]
        public string SerInvDeductionRemark { get; set; }
        [Display(Name = "Net Amount")]
        public decimal SerInvNetPayable { get; set; }
        [Display(Name = "Special Remarks")]
        public string SerInvRemarks { get; set; }
        [Display(Name = "Due Date")]
        public DateTime SerInvDueDate { get; set; }
        public int ComanyId { get; set; }
        public int FyID { get; set; }
    }
}
