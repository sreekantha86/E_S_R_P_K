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
    public class ServiceInvoiceController : BaseController
    {
        // GET: ServiceInvoice
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            ServiceIncome model = new ServiceIncome();
            model.HeadModel = new ems.domain.ServiceIncomeHD();
            model.ItemsModel = new List<ServiceIncomeDT>();
            for (int i = 0; i < 50; i++)
            {
                model.ItemsModel.Add(new ems.domain.ServiceIncomeDT() { slNo = i+1});
            }
            fillDropdowns();
            InitSyncDatePicker();
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(ServiceIncome model)
        {
            if(ModelState.IsValid)
            {

            }
            return RedirectToAction("Create");
        }
        private void fillDropdowns()
        {
            fillCustomer();
            fillServiceDescription();
        }
        private void fillCustomer()
        {
            CustomerRepository _cusRepo = new CustomerRepository();
            List<Customer> cus = _cusRepo.GetCustomerList();

            DropDownListProperties DropdownProperties = new DropDownListProperties();
            DropdownProperties.DataSource = cus;
            DropdownProperties.Width = "100%";
            DropDownListFields DropdownFields = new DropDownListFields();
            DropdownFields.Text = "CusName";
            DropdownFields.Id = "CusId";
            DropdownFields.Value = "CusId";
            DropdownProperties.DropDownListFields = DropdownFields;
            ViewData["CustomerDropdownModel"] = DropdownProperties;
        }
        private void fillServiceDescription()
        {
            ServiceExpenseRepository _serRepo = new ServiceExpenseRepository();
            ViewData["ServiceDropdownModel"] = _serRepo.GetSeviceExpenseList();
        }
    }
}