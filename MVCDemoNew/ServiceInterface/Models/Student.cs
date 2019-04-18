using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataModel;
namespace ServiceInterface.Models
{
    public class Student
    {
        NitishEntities _db = new NitishEntities();
        public List<Student> GetStudents()
        {
            return _db.Students.ToList();
        }
    }
}