using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ems.domain;
using ems.core;
using Syncfusion.EJ.Export;
using Syncfusion.JavaScript.Models;
using Syncfusion.XlsIO;
using ems.domain.ViewModels;

namespace prms.web.Controllers
{
    public class ServiceExpenseController : BaseController
    {
        ServiceExpenseRepository repo = new ServiceExpenseRepository();
        DropDownRepository ddrepo = new DropDownRepository();
        public ActionResult Index()
        {
            List<ServiceExpenseViewModel> model = repo.GetSeviceExpenseList();
            TempData["ExportData"] = model;
            ViewBag.datasource = model;
            return View();
        }
        public ActionResult Create()
        {
            ServiceExpense model = new ServiceExpense();
            FillDropDowns();
            return View(model);
        }
        public ActionResult Edit(int? Id)
        {
            FillDropDowns();
            ServiceExpense model = repo.GetServiceExpense(Id ?? 0);            
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(ServiceExpense model)
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
                    FillDropDowns();
                    return View(model);
                }
            }
            FillDropDowns();
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(ServiceExpense model)
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
                    FillDropDowns();
                    return View(model);
                }
            }
            return View(model);
        }
        public void FillDropDowns()
        {
            FillGSTRates();
            FillServiceExpenseType();
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
        private void FillServiceExpenseType()
        {
            DropDownListProperties DropdownProperties = new DropDownListProperties();
            DropdownProperties.DataSource = new List<DropdownViewModel>()
            {
                new DropdownViewModel() {shortValue="SER", DisplayText = "Service"},
                new DropdownViewModel() {shortValue="EXP", DisplayText = "Expense" },
                new DropdownViewModel() {shortValue="BOTH", DisplayText="Both" }
            };
            DropdownProperties.Width = "100%";
            DropDownListFields DropdownFields = new DropDownListFields();
            DropdownFields.Text = "DisplayText";
            DropdownFields.Id = "shortValue";
            DropdownFields.Value = "shortValue";
            DropdownProperties.DropDownListFields = DropdownFields;
            ViewData["SerExpTypeDropdownModel"] = DropdownProperties;
        }
    }
}