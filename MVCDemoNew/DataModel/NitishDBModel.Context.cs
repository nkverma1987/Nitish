﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NitishEntities1 : DbContext
    {
        public NitishEntities1()
            : base("name=NitishEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<countryState> countryStates { get; set; }
        public virtual DbSet<EmployeeSalary> EmployeeSalaries { get; set; }
        public virtual DbSet<Promotion> Promotions { get; set; }
        public virtual DbSet<Salary> Salaries { get; set; }
        public virtual DbSet<stateCity> stateCities { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<tblApplicant> tblApplicants { get; set; }
        public virtual DbSet<tblContent> tblContents { get; set; }
        public virtual DbSet<tblCountry> tblCountries { get; set; }
        public virtual DbSet<tblDepartment> tblDepartments { get; set; }
        public virtual DbSet<tblEmployee> tblEmployees { get; set; }
        public virtual DbSet<tblEmployeeManager> tblEmployeeManagers { get; set; }
        public virtual DbSet<tblEmployeeRegister> tblEmployeeRegisters { get; set; }
        public virtual DbSet<tblProduct> tblProducts { get; set; }
        public virtual DbSet<tblRegisterCustomer> tblRegisterCustomers { get; set; }
        public virtual DbSet<tblStudent> tblStudents { get; set; }
        public virtual DbSet<tblTest> tblTests { get; set; }
        public virtual DbSet<tblUserLogin> tblUserLogins { get; set; }
        public virtual DbSet<tblUser> tblUsers { get; set; }
        public virtual DbSet<TestPagination> TestPaginations { get; set; }
        public virtual DbSet<tblUrl> tblUrls { get; set; }
    }
}
