using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ems.domain
{
    public class Style
    {
        public int? StyleId { get; set; }
        [StringLength(50, MinimumLength = 2)]
        [Display(Name = "Style No")]
        [Required(ErrorMessage = "Style No is required")]
        public string StyleNo { get; set; }
        [Display(Name = "Style Price")]
        [Required(ErrorMessage = "Style Price is required")]
        public decimal StylePrice { get; set; }
        [Display(Name = "Quantity")]
        [Required(ErrorMessage = "Quantity is required")]
        public int Quantity { get; set; }
        [Display(Name = "Delivery Date")]
        [Required(ErrorMessage = "Delivery Date is required")]
        public DateTime DeliveryDate { get; set; }
        [Display(Name = "Colours")]
        [Required(ErrorMessage = "Colours is required")]
        public string Colours { get; set; }
    }
}
