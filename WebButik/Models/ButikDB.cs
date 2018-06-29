using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebButik.Models
{
    public class ButikDB : DbContext
    {
        public ButikDB() : base("MyButikDb")
        {
                  
        }

        public DbSet<Product> Product { get; set; }
        public DbSet<Customer> Cusomer { get; set; }
  
    }
}