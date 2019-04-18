using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using UI.Repository;

namespace UI.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            ServiceRepository serviceObj = new ServiceRepository();
            HttpResponseMessage response = serviceObj.GetResponse("api/student/getallstudents");
            response.EnsureSuccessStatusCode();
            List<Models.Student> students = response.Content.ReadAsAsync<List<Models.Student>>().Result;
            return View(students);

        }
    }
}