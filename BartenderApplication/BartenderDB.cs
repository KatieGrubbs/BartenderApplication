using BartenderApplication.Models;

namespace BartenderApplication
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BartenderDB : DbContext
    {
        // Your context has been configured to use a 'BartenderDB' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'BartenderApplication.BartenderDB' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'BartenderDB' 
        // connection string in the application configuration file.
        public BartenderDB()
            : base("name=BartenderDB")
        {
        }

        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Cocktail> Cocktails { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}