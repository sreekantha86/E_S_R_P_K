using ems.core;
using ems.domain;
using Syncfusion.JavaScript.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ems.web.Controllers
{
    public class VendorController : Controller
    {
        VendorRepository repo = new VendorRepository();
        public ActionResult Index()
        {
            List<Vendor> model = repo.GetVendorList();
            TempData["ExportData"] = model;
            ViewBag.datasource = model;
            return View();
        }
        public ActionResult Create()
        {
            fillDropdowns();
            return View();
        }
        [HttpPost]
        public ActionResult Create(Vendor model)
        {
            if(ModelState.IsValid)
            {
                int row = repo.Create(model);
                if(row>0)
                {
                    TempData["message"] = "Successfully Created";
                }
            }
            else
            {
                fillDropdowns();
                return View(model);
            }
            return RedirectToAction("Create");
        }
        public ActionResult Edit(int? Id)
        {
            Vendor model = repo.GetVendorDetails(Id ?? 0);
            fillDropdowns();
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(Vendor model)
        {
            if (ModelState.IsValid)
            {
                int row = repo.Edit(model);
                if (row > 0)
                {
                    TempData["message"] = "Successfully Updated";
                }
            }
            else
            {
                fillDropdowns();
                return View(model);
            }
            return RedirectToAction("Index");
        }
        private void fillDropdowns()
        {
            DropDownListProperties DropdownProperties = new DropDownListProperties();
            DropdownProperties.DataSource = repo.GetVendorTypeList();
            DropdownProperties.Width = "100%";
            DropDownListFields DropdownFields = new DropDownListFields();
            DropdownFields.Text = "VendorTypeName";
            DropdownFields.Id = "VendorTypeId";
            DropdownFields.Value = "VendorTypeId";
            DropdownProperties.DropDownListFields = DropdownFields;
            ViewData["VendorTypeDropdownModel"] = DropdownProperties;
        }
    }
}