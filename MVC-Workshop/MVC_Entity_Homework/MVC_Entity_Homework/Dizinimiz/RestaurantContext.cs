using MVC_Entity_Homework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MVC_Entity_Homework.Dizinimiz
{
    public class RestaurantContext : DbContext
    {
        public RestaurantContext() : base("RestaurantDatabase") { }
        public DbSet<Restaurant> Restaurants { get; set; }

        /*
         *  This is used to remove 's' which adds to the database tables' name.
         *  
         * protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }*/
    }
}