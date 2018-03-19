using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ems.domain
{
    public class GST
    {
        public int gstId { get; set; }
        [Required(ErrorMessage = "GST Name is required")]
        [StringLength(150, MinimumLength = 5)]
        [Display(Name = "GST Name")]
        public string gstName {get;set;}
        [Display(Name = "GST Rate")]
        [Required(ErrorMessage = "GST Rate is required")]
        [Range(0, 100, ErrorMessage = "Rate must be between 0 and 100")]
        public decimal gstRate { get; set; }
        [Display(Name = "SGST Rate")]
        [Required(ErrorMessage = "SGST Rate is required")]
        [Range(0, 100, ErrorMessage = "Rate must be between 0 and 100")]
        public decimal gstSgstRate { get; set; }
        [Display(Name = "CGST Rate")]
        [Required(ErrorMessage = "CGST Rate is required")]
        [Range(0, 100, ErrorMessage = "Rate must be between 0 and 100")]
        public decimal gstCgstRate { get; set; }
        [Display(Name = "Special Rate")]
        [StringLength(500, MinimumLength = 0)]
        public string gstSpRemarks {get;set;}
    }
}
