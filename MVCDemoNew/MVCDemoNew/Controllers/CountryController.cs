using MVCDemoNew.DI;
using MVCDemoNew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemoNew.Controllers
{
    public class CountryController : Controller
    {
        private ICountry _country;
        public CountryController(ICountry country)
        {
            _country = country;
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return PartialView("~/Views/Country/_CreateEdit.cshtml",new Country());
        }
        [HttpPost]
        public ActionResult Create(Country country)
        {
            bool hasError = false;
            string errorMessage = string.Empty;
            try
            {
                hasError = _country.Create(out errorMessage);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                hasError = true;
            }
            return Json(new { error = hasError, message = errorMessage },JsonRequestBehavior.AllowGet);
        }
    }
}