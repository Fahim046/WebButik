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

            var roleStore = new RoleStore<IdentityRole>(context);
            var roleManager = new RoleManager<IdentityRole>(roleStore);


            if (!roleManager.RoleExists("Admin"))
            {
                roleManager.Create(new IdentityRole("Admin"));
            }
            if (!roleManager.RoleExists("User"))
            {
                roleManager.Create(new IdentityRole("User"));
            }

            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new UserManager<ApplicationUser>(userStore);


            if (userManager.FindByEmail("admin@admin.se") == null)
            {
                ApplicationUser admin = new ApplicationUser()
                {
                    Email = "admin@admin.se",
                    UserName = "admin@admin.se"
                };
                userManager.Create(admin, "Fahim046");
                userManager.AddToRole(userManager.FindByEmail("admin@admin.se").Id, "Admin");
            }

            if (userManager.FindByEmail("user@user.se") == null)
            {
                ApplicationUser user = new ApplicationUser()   
                {
                    Email = "user@user.se",
                    UserName = "user@user.se"
                };
                userManager.Create(user, "Fahim046");
                userManager.AddToRole(userManager.FindByEmail("user@user.se").Id, "User");
            }



        }
    }
}
