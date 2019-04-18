using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public static class CountryDAL
    {
       static NitishEntities1 DbContext = new NitishEntities1();
        public static tblCountry GetCountry(int cntryId)
        {
            return DbContext.tblCountries.Where(p => p.CountryID == cntryId).FirstOrDefault();
        }

    }
}
