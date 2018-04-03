using ems.core;
using ems.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prms.web.Controllers
{
    public class CompanyController : BaseController
    {
        CompanyRepository Repo = new CompanyRepository();
        // GET: Company
        public ActionResult Edit()
        {
            Company model = Repo.GetCompanyDetails();
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(Company model)
        {
            if(ModelState.IsValid)
            {
                int i = Repo.Edit(model);
                if(i>0)
                {
                    TempData["message"] = "Successfully Updated";
                }
            }
            else
            {
                return View(model);
            }
            return RedirectToAction("Edit");
        }
    }
}