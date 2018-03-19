using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ems.domain
{
    public class ServiceExpense
    {
        public int SerId { get; set; }
        [Required(ErrorMessage = "SAC is required")]
        [StringLength(50, MinimumLength = 2)]
        [Display(Name = "SAC")]
        public string SerSAC { get; set; }
        [Required(ErrorMessage = "Service/Expense is required")]
        [StringLength(250, MinimumLength = 2)]
        [Display(Name = "Service/Expense")]
        public string SerName { get; set; }
        [Required(ErrorMessage = "GST Rate is required")]
        [Display(Name = "GST Rate")]
        public int? gstId { get; set; }
        [Required(ErrorMessage = "Type is required")]
        [StringLength(250, MinimumLength = 2)]
        [Display(Name = "Type")]
        public string SerOrExp { get; set; }
        [StringLength(5000, MinimumLength = 2)]
        [Display(Name = "Special Remarks")]
        public string SerRemarks { get; set; }
    }
}
