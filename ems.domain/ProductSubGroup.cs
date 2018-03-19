using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ems.domain
{
    public class ProductSubGroup
    {
        public int? prdSGId { get; set; }
        [Required(ErrorMessage = "Sub Group Code is required")]
        [StringLength(50, MinimumLength = 2)]
        [Display(Name = "Sub Group Code")]
        public string prdSGCode { get; set; }
        [Required(ErrorMessage = "Sub Group Name is required")]
        [StringLength(250, MinimumLength = 2)]
        [Display(Name = "Sub Group Name")]
        public string prdSGName { get; set; }
        [Required(ErrorMessage = "Product Group is required")]
        [Display(Name = "Product Group")]
        public int prdMGId { get; set; }
        [Required(ErrorMessage = "GST Rate is required")]
        [Display(Name = "GST Rate")]
        public int gstId { get; set; }
        [Display(Name = "Special Remarks")]
        public string prdSGRemarks { get; set; }
    }
}
