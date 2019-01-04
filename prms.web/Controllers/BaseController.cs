using prms.web.Helpers;
using Syncfusion.EJ.Export;
using Syncfusion.JavaScript.Models;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prms.web.Controllers
{
    [AuthorizeUser]
    public class BaseController : Controller
    {
        protected override IAsyncResult BeginExecuteCore(AsyncCallback callback, object state)
        {
            return base.BeginExecuteCore(callback, state);
        }
        public int UserID
        {
            get
            {
                HttpCookie usr = (HttpCookie)Session["user"];
                int Id = Convert.ToInt32(usr["UserId"]);
                return Id;
            }
            set
            {
            }
        }
        public string UserName
        {
            get
            {
                HttpCookie usr = (HttpCookie)Session["user"];
                return usr["UserName"].ToString();
            }
            set
            {

            }
        }
        public int OrganizationId
        {
            get
            {
                HttpCookie usr = (HttpCookie)Session["user"];
                int Id = Convert.ToInt32(usr["Organization"]);
                return Id;
            }
            set
            {

            }
        }
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