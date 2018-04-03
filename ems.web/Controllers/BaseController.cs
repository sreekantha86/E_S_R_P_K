using ems.core;
using Syncfusion.EJ.Export;
using Syncfusion.JavaScript.Models;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ems.web.Controllers
{
    public class BaseController : Controller
    {
        protected string CurrentAction { get; private set; }
        protected string CurrentController { get; private set; }

        protected override IAsyncResult BeginExecuteCore(AsyncCallback callback, object state)
        {
            InitSyncDatePicker();
            return base.BeginExecuteCore(callback, state);
        }
        //protected override void Initialize(RequestContext requestContext)
        //{
        //    CurrentController = requestContext.HttpContext.Request.RequestContext.RouteData.Values["controller"].ToString();
        //    CurrentAction = requestContext.HttpContext.Request.RequestContext.RouteData.Values["action"].ToString();
        //}
        public void ExportToExcel(string GridModel)
        {
            ExcelExport exp = new ExcelExport();
            var DataSource = TempData["ExportData"];
            TempData["ExportData"] = DataSource;
            GridProperties obj = (GridProperties)Syncfusion.JavaScript.Utils.DeserializeToModel(typeof(GridProperties), GridModel);
            exp.Export(obj, DataSource, "Export.xlsx", ExcelVersion.Excel2010, false, false, "flat-saffron");
        }
        public void ExportToWord(string GridModel)
        {
            WordExport exp = new WordExport();
            var DataSource = TempData["ExportData"];
            TempData["ExportData"] = DataSource;
            GridProperties obj = (GridProperties)Syncfusion.JavaScript.Utils.DeserializeToModel(typeof(GridProperties), GridModel);
            exp.Export(obj, DataSource, "Export.docx", false, false, "flat-saffron");
        }
        public void ExportToPdf(string GridModel)
        {
            PdfExport exp = new PdfExport();
            var DataSource = TempData["ExportData"];
            TempData["ExportData"] = DataSource;
            GridProperties obj = (GridProperties)Syncfusion.JavaScript.Utils.DeserializeToModel(typeof(GridProperties), GridModel);
            //exp.Export(obj, DataSource, "Export.pdf", false, false, "flat-saffron");
            exp.Export(gridmaodel: obj, datasource: DataSource, fileName: "Export.pdf", isHideColumnIncude: false, isTemplateColumnIclude: false, theme: "flat-saffron");

        }
        public void InitSyncDatePicker()
        {
            DatePickerProperties datemodel = new DatePickerProperties();
            datemodel.Locale = "en-US";
            datemodel.ShowOtherMonths = false;
            datemodel.DateFormat = "dd/MMM/yyyy";
            datemodel.MinDate = "01/Jan/2018";
            datemodel.MaxDate = "31/Dec/2018";
            ViewData["date"] = datemodel;
        }
    }
}