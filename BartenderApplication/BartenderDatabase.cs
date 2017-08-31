using System.Data.Entity.ModelConfiguration.Conventions;
using BartenderApplication.Models;

namespace BartenderApplication
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BartenderDatabase : DbContext
    {
        // Your context has been configured to use a 'BartenderDB' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'BartenderApplication.BartenderDB' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'BartenderDB' 
        // connection string in the application configuration file.
        public BartenderDatabase() : base("name=BartenderDatabase") { }

        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Use singular table names
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}