using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataModel;
using System.Web.Http.Results;
using ServiceWebApi.Models;

namespace ServiceWebApi.Controllers
{
    public class StudentController : ApiController
    {
       
        [HttpGet]
        public JsonResult<List<Models.Student>> GetAllStudents()
        {
            List<DataModel.Student> dStudents = StudentDAL.GetAllStudents();
            List<Models.Student> students = new List<Models.Student>();
            foreach(var item in dStudents)
            {
                Models.Student student = new Models.Student
                {
                    City = item.City,
                    Class = item.Class,
                    CountryId = Convert.ToInt32(item.Country),
                    Email = item.Email,
                    EnrollYear = item.EnrollYear,
                    Id = item.StudentID,
                    Name = item.Name,
                    AssociatedCountry=CountryDAL.GetCountry(Convert.ToInt32(item.Country))
                };
                students.Add(student);
            }
            return Json<List<Models.Student>>(students);
        }

    }
}
