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

namespace prms.web.Controllers
{
    public class GSTController : BaseController
    {
        // GET: GST
        GSTRepository repo = new GSTRepository();
        public ActionResult Index()
        {
            List<GST> model = repo.GetGSTList();
            TempData["ExportData"] = model;
            ViewBag.datasource = model;
            return View();
        }
        public ActionResult Create()
        {
            GST model = new GST();
            return View(model);
        }
        public ActionResult Edit(int? Id)
        {
            GST model = repo.GetGSTRate(Id ?? 0);
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(GST model)
        {
            if(ModelState.IsValid)
            {
                int rowsAffected = repo.Create(model);
                if(rowsAffected > 0)
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
        public ActionResult Edit(GST model)
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