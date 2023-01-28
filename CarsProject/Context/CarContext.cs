using CarsProject.Data;
using CarsProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CarsProject.Context
{
    public class CarContext : DbContext
    {
        public CarContext() : base("CarSystemConnection") { }
        public DbSet<Cars> cars { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
          
        }
    }
}