using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemoNew.App_Start
{
    public class Constant
    {
        public const int Size_Of_Page = 10;
    }
    public class StoredProcedure
    {
        public const string USPAddCountry = "USPAddCountry";
    }
    public class StoredProcedureParameters
    {
        public const string CountryName = "@p_CountryName";
    }
    public class PartialViews
    {
        public const string CountryCreateEditView = "~/Views/Country/_CreateEdit.cshtml";
        public const string CountryListView = "~/Views/Country/_List.cshtml";
    }
}