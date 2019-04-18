using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataModel
{
   public static class StudentDAL
    {
        static NitishEntities1 DbContext;
        static StudentDAL()
        {
            DbContext = new NitishEntities1();
        }
        public static List<Student> GetAllStudents()
        {
            return DbContext.Students.ToList();
        }
    }

}
