using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MVCProject1.Models;

namespace MVCProject1.DAL
{
    public class MVCProjectf : DbContext
    {
        public MVCProjectf(): base("name =MVCProjectf")
            {

            }
        public DbSet<Products> Product { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Company> Companies { get; set; }
       

    }
}