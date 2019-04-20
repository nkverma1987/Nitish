using MVCDemoNew.Entity;
using MVCDemoNew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDemoNew.DI
{
   public interface ICountry
    {
        List<tblCountry> GetCountries();
        List<Country> GetCountryList();
        bool Create(Country country,out string message);
    }
}
