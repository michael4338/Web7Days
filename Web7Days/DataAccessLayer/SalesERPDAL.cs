using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
using Web7Days.Models;

namespace Web7Days.DataAccessLayer
{
    public class SalesERPDAL : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<SalesERPDAL>(null);
            modelBuilder.Entity<Employee>().ToTable("Tbl_Employee");
            base.OnModelCreating(modelBuilder);
        }
    }
}