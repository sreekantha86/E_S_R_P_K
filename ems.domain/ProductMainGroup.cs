using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ems.domain
{
    public class ProductMainGroup
    {
        public int? prdMGId { get; set; }
        [StringLength(250, MinimumLength = 2)]
        [Display(Name = "HSN Code")]
        public string prdMGHSN { get; set; }
        [Required(ErrorMessage = "Product Group Name is required")]
        [StringLength(250, MinimumLength = 2)]
        [Display(Name = "Product Main Group")]
        public string prdMGName { get; set; }
        [Required(ErrorMessage = "Product Type is required")]
        [Display(Name = "Product Type")]
        public int prdTypeId { get; set; }
        [StringLength(5000, MinimumLength = 0)]
        [Display(Name = "Special Remarks")]
        public string prdMGRemarks { get; set; }

    }
}
