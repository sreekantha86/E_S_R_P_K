using ems.core;
using ems.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ems.web.Controllers
{
    public class CustomerController : BaseController
    {
        CustomerRepository repo = new CustomerRepository();
        public ActionResult Index()
        {
            List<Customer> model = repo.GetCustomerList();
            TempData["ExportData"] = model;
            ViewBag.datasource = model;
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Customer model)
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
                    return View(model);
                }
            }
            return View(model);
        }
        public ActionResult Edit(int? Id)
        {
            Customer model = repo.GetCustomer(Id ?? 0);
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(Customer model)
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
                    return View(model);
                }
            }
            return View(model);
        }
    }
}