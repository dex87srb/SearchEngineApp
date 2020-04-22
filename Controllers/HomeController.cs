using SearchEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace SearchEngine.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
           

            return View();
        }

        [HttpPost]
        public ActionResult Index(RecordsModel model)
        {
            ViewBag.ErrorValidation = "Insert value!";
            try
            {
                AccountEntities db = new AccountEntities();

                Record record = new Record();

                var userDetails = Session["UserID"];

                if (model.Record != null)
                {
                    record.RecordQuery = model.Record;

                    record.Id = (int?)userDetails;

                    db.Records.Add(record);

                    db.SaveChanges();
                }

            }
            catch
            {

                throw;
            }

            if (model.Record != null)
            {
                ViewBag.JavaScriptFunction = string.Format("SiteSearch();");
            }
                  
            return View();

        }
    }
}
