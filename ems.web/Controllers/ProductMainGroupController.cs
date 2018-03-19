using ems.core;
using ems.domain;
using ems.domain.ViewModels;
using Syncfusion.JavaScript.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ems.web.Controllers
{
    public class ProductMainGroupController : BaseController
    {
        ProductMainGroupRepository repo = new ProductMainGroupRepository();
        
        public ActionResult Index()
        {
            List<ProductMainGroupViewModel> model = repo.GetProductMainGroupList();
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
        public ActionResult Create(ProductMainGroup model)
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
            ProductMainGroup model = repo.GetProductMainGroup(Id ?? 0);
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(ProductMainGroup model)
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
            FillProductType();
        }
        private void FillProductType()
        {
            DropDownRepository ddRepo = new DropDownRepository();
            DropDownListProperties DropdownProperties = new DropDownListProperties();
            DropdownProperties.DataSource = ddRepo.GetProductTypes();
            DropdownProperties.Width = "100%";
            DropDownListFields DropdownFields = new DropDownListFields();
            DropdownFields.Text = "prdTypeName";
            DropdownFields.Id = "prdTypeId";
            DropdownFields.Value = "prdTypeId";
            DropdownProperties.DropDownListFields = DropdownFields;
            ViewData["ProdTypeDropdownModel"] = DropdownProperties;
        }
    }
}