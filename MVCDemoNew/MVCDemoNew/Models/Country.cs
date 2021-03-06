﻿using MVCDemoNew.App_Start;
using MVCDemoNew.DI;
using MVCDemoNew.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MVCDemoNew.Models
{
    public class Country : ICountry
    {
        public int Id { get; set; }
        public string Name { get; set; }

        NitisDBDataContext db = new NitisDBDataContext();
        public List<tblCountry> GetCountries()
        {
            return (from c in db.tblCountries select c).ToList();
        }
        public List<Country> GetCountryList()
        {
            List<Country> countries = new List<Models.Country>();
            var countryItems = from c in db.tblCountries select c;
            foreach (var item in countryItems)
            {
                countries.Add(new Country
                {
                    Id = item.Id,
                    Name = item.Name
                });
            }
            return countries;
        }
        public bool Create(Country country,out string message)
        {
            var hasError = false;
            message = string.Empty;
            SqlConnection con = null;
            try
            {
                using (con = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(StoredProcedure.USPAddCountry, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter paramName = new SqlParameter
                    {
                        ParameterName = StoredProcedureParameters.CountryName,
                        Direction = ParameterDirection.Input,
                        Value = country.Name,
                        SqlDbType = SqlDbType.VarChar
                    };
                    cmd.Parameters.Add(paramName);
                    cmd.ExecuteNonQuery();
                    message = "Saved";
                }
            }
            catch (Exception ex)
            {
                message = ex.Message;
                hasError = true;
            }
            finally
            {
                con.Close();
            }
            return hasError;
        }
    }
}