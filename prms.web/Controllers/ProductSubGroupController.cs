using ems.core;
using ems.domain;
using ems.domain.ViewModels;
using Syncfusion.JavaScript.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prms.web.Controllers
{
    public class ProductSubGroupController : BaseController
    {
        ProductSubGroupRepository repo = new ProductSubGroupRepository();
        DropDownRepository ddrepo = new DropDownRepository();
        public ActionResult Index()
        {
            List<ProductSubGroupViewModel> model = repo.GetProductSubGroupList();
            TempData["ExportData"] = model;
            ViewBag.datasource = model;
            return View();
        }
        public ActionResult Create()
        {
            FillFropDowns();
            return View();
        }
        [HttpPost]
        public ActionResult Create(ProductSubGroup model)
        {
            if (ModelState.IsValid)
            {
                int rowsAffected = repo.Create(model);
                if (rowsAffected > 0)
                {
                    TempData["message"] = "Successfully Saved";
                    return RedirectToAction("Create");
                }
                else
                {
                    FillFropDowns();
                    return View(model);
                }
            }
            return View(model);
        }
        public ActionResult Edit(int? Id)
        {
            FillFropDowns();
            ProductSubGroup model = repo.GetProductSubGroup(Id ?? 0);
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(ProductSubGroup model)
        {
            if (ModelState.IsValid)
            {
                int rowsAffected = repo.Edit(model);
                if (rowsAffected > 0)
                {
                    TempData["message"] = "Successfully Updated";
                    return RedirectToAction("Index");
                }
                else
                {
                    FillFropDowns();
                    return View(model);
                }
            }
            return View(model);
        }
        private void FillFropDowns()
        {
            FillProductGroup();
            FillGSTRates();
        }
        private void FillProductGroup()
        {
            DropDownListProperties DropdownProperties = new DropDownListProperties();
            DropdownProperties.DataSource = ddrepo.GetProductMainGroup();
            DropdownProperties.Width = "100%";
            DropDownListFields DropdownFields = new DropDownListFields();
            DropdownFields.Text = "prdMGName";
            DropdownFields.Id = "prdMGId";
            DropdownFields.Value = "prdMGId";
            DropdownProperties.DropDownListFields = DropdownFields;
            ViewData["ProdGroupDropdownModel"] = DropdownProperties;
        }
        private void FillGSTRates()
        {
            DropDownListProperties DropdownProperties = new DropDownListProperties();
            DropdownProperties.DataSource = ddrepo.GetGSTRate();
            DropdownProperties.Width = "100%";
            DropDownListFields DropdownFields = new DropDownListFields();
            DropdownFields.Text = "gstName";
            DropdownFields.Id = "gstId";
            DropdownFields.Value = "gstId";
            DropdownProperties.DropDownListFields = DropdownFields;
            ViewData["GSTRateDropdownModel"] = DropdownProperties;
        }
    }
}