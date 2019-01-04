using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ems.domain
{
    public class Trim
    {
        [StringLength(50, MinimumLength = 2)]
        [Display(Name = "Trim Decription")]
        [Required(ErrorMessage = "Trim Description is required")]
        public string TrimDescription { get; set; }

        [Display(Name = "Consumption/Garment")]
        [Required(ErrorMessage = "Consumption/Garment is required")]
        public int ConsumptionPerGarment { get; set; }

        [Display(Name = "Price")]
        [Required(ErrorMessage = "Price is required")]
        public decimal Price { get; set; }

        [Display(Name = "Vendor")]
        [Required(ErrorMessage = "Vendor is required")]
        public int VendorId { get; set; }

        [Display(Name = "Expected Delivery Date")]
        [Required(ErrorMessage = "Expected Delivery Date is required")]
        public DateTime ExpectedDeliveryDate { get; set; }
    }
}
