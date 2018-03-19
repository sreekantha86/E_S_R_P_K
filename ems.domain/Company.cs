using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ems.domain
{
    public class Company
    {
        public int ComanyId { get; set; }
        [StringLength(50, MinimumLength = 2)]
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }
        [StringLength(50, MinimumLength = 2)]
        [Display(Name = "Website")]
        public string CompanyWebsite { get; set; }
        [StringLength(50, MinimumLength = 2)]
        [Display(Name = "Contact Numbers")]
        public string ContactNumbers { get; set; }
        [StringLength(50, MinimumLength = 2)]
        [Display(Name = "E-Mail")]
        public string CompanyMailId { get; set; }
        [StringLength(500, MinimumLength = 2)]
        [Display(Name = "Address Line 1")]
        public string CompanyAddress1 { get; set; }
        [StringLength(500, MinimumLength = 2)]
        [Display(Name = "Address Line 2")]
        public string CompanyAddress2 { get; set; }
        [StringLength(500, MinimumLength = 2)]
        [Display(Name = "Address Line 3")]
        public string CompanyAddress3 { get; set; }
        [StringLength(50, MinimumLength = 2)]
        [Display(Name = "TIN")]
        public string TIN { get; set; }
        [StringLength(50, MinimumLength = 2)]
        [Display(Name = "PAN")]
        public string PAN { get; set; }
        [StringLength(50, MinimumLength = 2)]
        [Display(Name = "IE Code")]
        public string IECode { get; set; }
        [Display(Name = "GST Restered/Not")]
        public bool GSTRegistered { get; set; }
        [StringLength(25, MinimumLength = 2)]
        [Display(Name = "GST Reg. No")]
        public string GSTNo { get; set; }
    }
}
