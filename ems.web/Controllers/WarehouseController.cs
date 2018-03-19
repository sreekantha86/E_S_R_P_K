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

namespace ems.web.Controllers
{
    public class WarehouseController : BaseController
    {
        WarehouseRepository repo = new WarehouseRepository();       
        public ActionResult Index()
        {
            List<Warehouse> model = repo.GetWarehouseList();
            TempData["ExportData"] = model;
            ViewBag.datasource = model;
            return View();
        }
        public ActionResult Create()
        {
            Warehouse model = new Warehouse();
            return View(model);
        }
        public ActionResult Edit(int? Id)
        {
            Warehouse model = repo.GetWarehouse(Id ?? 0);
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(Warehouse model)
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
        [HttpPost]
        public ActionResult Edit(Warehouse model)
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