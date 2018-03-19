using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ems.domain
{
    public class Warehouse
    {
        public int? whId { get; set; }
        [Required(ErrorMessage = "Code is required")]
        [StringLength(50, MinimumLength = 2)]
        [Display(Name = "Code")]
        public string whCode { get; set; }
        [Required(ErrorMessage = "Warehouse Name is required")]
        [StringLength(50, MinimumLength = 2)]
        [Display(Name = "Warehouse")]
        public string whName { get; set; }
        [StringLength(5000, MinimumLength = 0)]
        [Display(Name = "Address")]
        public string whAddress { get; set; }
        [StringLength(50, MinimumLength = 0)]
        [Display(Name = "Telephone")]
        public string whTel { get; set; }
        [StringLength(50, MinimumLength = 0)]
        [Display(Name = "Mobile")]
        public string whMob { get; set; }
        [DataType(DataType.EmailAddress)]
        [StringLength(50, MinimumLength = 0)]
        [Display(Name = "Email Address")]
        public string whEmail { get; set; }
        [StringLength(150, MinimumLength = 0)]
        [Display(Name = "Contact Person")]
        public string whContactPerson { get; set; }
    }
}
