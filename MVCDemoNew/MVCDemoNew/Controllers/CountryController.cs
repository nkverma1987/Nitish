using MVCDemoNew.App_Start;
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
        [HttpGet]
        public JsonResult GetCountries()
        {
            List<Country> countries = _country.GetCountryList();
            return Json(countries, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Create()
        {
            return PartialView(PartialViews.CountryCreateEditView,new Country());
        }
        public ActionResult Add()
        {
            return PartialView(PartialViews.CountryCreateEditView, new Country());
        }
        [HttpPost]
        public ActionResult Create(Country country)
        {
            bool hasError = false;
            string errorMessage = string.Empty;
            try
            {
                hasError = _country.Create(country,out errorMessage);
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