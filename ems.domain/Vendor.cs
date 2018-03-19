using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ems.domain
{
    public class Vendor
    {
        public int VendorId { get; set; }
        [StringLength(50, MinimumLength = 2)]
        [Display(Name = "Vendor Code")]
        public string VendorCode { get; set; }
        [Required(ErrorMessage = "Vendor Name is required")]
        [StringLength(50, MinimumLength = 2)]
        [Display(Name = "Vendor Name")]        
        public string VendorName { get; set; }
        [StringLength(500, MinimumLength = 2)]
        [Display(Name = "Address")]
        public string Address { get; set; }
        [StringLength(50, MinimumLength = 2)]
        [Display(Name = "Phone/Mobile")]
        public string PhoneNumber { get; set; }
        [StringLength(50, MinimumLength = 2)]
        [Display(Name = "City")]
        public string City { get; set; }
        [StringLength(50, MinimumLength = 2)]
        [Display(Name = "District")]
        public string District { get; set; }
        [StringLength(50, MinimumLength = 2)]
        [Display(Name = "PAN")]
        public string PAN { get; set; }
        [StringLength(50, MinimumLength = 2)]
        [Display(Name = "Contact Person")]
        public string ContactPerson { get; set; }
        [StringLength(50, MinimumLength = 2)]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Vendor Type is required")]
        [Display(Name = "Vendor Type")]
        public int VendorTypeId { get; set; }
        [Display(Name = "Country")]
        public int? CountryId { get; set; }
        [Display(Name = "GST Restered/Not")]
        public bool GSTRegistered { get; set; }
        [StringLength(50, MinimumLength = 2)]
        [Display(Name = "GST Reg. No")]
        public string GSTRegNo { get; set; }
    }
}
