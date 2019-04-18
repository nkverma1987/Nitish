using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataModel;
namespace ServiceWebApi.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Class { get; set; }
        public string EnrollYear { get; set; }
        public string City { get; set; }
        public Nullable<int> CountryId { get; set; }
        public tblCountry AssociatedCountry { get; set; }
    }
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}