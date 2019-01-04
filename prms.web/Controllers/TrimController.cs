using ems.core;
using ems.domain;
using Syncfusion.JavaScript.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prms.web.Controllers
{
    public class TrimController : Controller
    {
        // GET: Trim
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            fillDropdowns();
            return View();
        }
        private void fillDropdowns()
        {
            fillCustomer();
        }
        private void fillCustomer()
        {
            VendorRepository _vendorRepo = new VendorRepository();
            List<Vendor> vendor = _vendorRepo.GetVendorList();

            DropDownListProperties DropdownProperties = new DropDownListProperties();
            DropdownProperties.DataSource = vendor;
            DropdownProperties.Width = "100%";
            DropDownListFields DropdownFields = new DropDownListFields();
            DropdownFields.Text = "VendorName";
            DropdownFields.Id = "VendorId";
            DropdownFields.Value = "VendorId";
            DropdownProperties.DropDownListFields = DropdownFields;
            ViewData["VendorDropdownModel"] = DropdownProperties;
        }
    }
}