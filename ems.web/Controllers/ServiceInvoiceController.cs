using ems.domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ems.web.Controllers
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
            model.ItemsModel = new List<domain.ServiceIncomeDT>();
            for (int i = 0; i < 50; i++)
            {
                model.ItemsModel.Add(new domain.ServiceIncomeDT() { slNo = i+1});
            }
            fillDropdowns();
            return View(model);
        }
        private void fillDropdowns()
        {
            fillCustomer();
        }
        private void fillCustomer()
        {

        }
    }
}