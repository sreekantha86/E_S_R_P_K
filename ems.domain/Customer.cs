using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ems.domain
{
    public class Customer
    {
        public int? CusId { get; set; }
        [StringLength(50, MinimumLength = 2)]
        [Display(Name = "Code")]
        public string CusCode { get; set; }
        [Required(ErrorMessage = "Customer Name is required")]
        [StringLength(250, MinimumLength = 2)]
        [Display(Name = "Name")]
        public string CusName { get; set; }
        [StringLength(50, MinimumLength = 10)]
        [Display(Name = "Tel. Phone")]
        public string Phone { get; set; }
        [StringLength(50, MinimumLength = 2)]
        [Display(Name = "Fax")]
        public string Fax { get; set; }
        [StringLength(50, MinimumLength = 2)]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [StringLength(150, MinimumLength = 2)]
        [Display(Name = "Contact Person")]
        public string ContactPerson { get; set; }
        [StringLength(5000, MinimumLength = 2)]
        [Display(Name = "Address")]
        public string Address { get; set; }
        [StringLength(50, MinimumLength = 2)]
        [Display(Name = "GST No.")]
        public string GSTNo { get; set; }
    }
}
