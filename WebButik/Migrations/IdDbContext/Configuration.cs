namespace WebButik.Migrations.IdDbContext
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebButik.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebButik.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"Migrations\IdDbContext";
            ContextKey = "WebButik.Models.ApplicationDbContext";
        }

        protected override void Seed(WebButik.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            // only Identity Role/users here!    
            // PM> Update-Database  -ConfigurationTypeName WebButik.Migrations.IdDbContext.Configuration

            var roleStore = new RoleStore<IdentityRole>(context);
            var roleManager = new RoleManager<IdentityRole>(roleStore);

            roleManager.Create(new IdentityRole("Admin"));
            roleManager.Create(new IdentityRole("User"));


            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new UserManager<ApplicationUser>(userStore);

            userManager.Create(new ApplicationUser() { Email = "admin@admin.se", UserName = "admin@admin.se" }, "Password!1");
            userManager.Create(new ApplicationUser() { Email = "user@user.se", UserName = "user@user.se" }, "Password!1");


            ApplicationUser admin = userManager.FindByEmail("admin@admin.se");
            ApplicationUser user = userManager.FindByEmail("user@user.se");

            userManager.AddToRole(admin.Id, "Admin");
            userManager.AddToRole(user.Id, "User");
        }
    }
}
