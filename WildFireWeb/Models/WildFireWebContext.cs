using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using WildFireWeb.Models;

namespace WildFireWeb.Models
{
    public class WildFireWebContext : DbContext
    {
        public WildFireWebContext() : base("WildFireWebContext")
        {
            
        }

        public DbSet<WildFireConfig> WildFireConfig { get; set; }
        public DbSet<FireEventModel> FireEventModel { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}