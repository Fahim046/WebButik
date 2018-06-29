namespace WebButik.Migrations.MyDbContext
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebButik.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebButik.Models.ButikDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"Migrations\MyDbContext";
        }

        protected override void Seed(WebButik.Models.ButikDB context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            // only Product/Customer
            // PM> Update-Database  -ConfigurationTypeName WebButik.Migrations.MyDbContext.Configuration
           

        }
    }
}
