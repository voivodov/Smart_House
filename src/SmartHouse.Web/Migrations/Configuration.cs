using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SmartHouse.Web.Models;

namespace SmartHouse.Web.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SmartHouse.Web.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SmartHouse.Web.Models.ApplicationDbContext context)
        {
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            #region Roles

            if (!roleManager.RoleExists("Administrator"))
            {
                var role = new ApplicationRole();
                role.Name = "Administrator";
                roleManager.Create(role);
            }

            if (!roleManager.RoleExists("Client"))
            {
                var role = new ApplicationRole();
                role.Name = "Client";
                roleManager.Create(role);
            }

            if (!roleManager.RoleExists("Guest"))
            {
                var role = new ApplicationRole();
                role.Name = "Guest";
                roleManager.Create(role);
            }

            #endregion

            if (!(context.Users.Any(u => u.UserName == "svetlin.krastanov90@gmail.com")))
            {
                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);
                var userToInsert = new ApplicationUser { UserName = "svetlin.krastanov90@gmail.com", PhoneNumber = "0888017004", Email = "svetlin.krastanov90@gmail.com"};
                userManager.Create(userToInsert, "svetlin90");
                userManager.AddToRole(userToInsert.Id, "Administrator");
            }

            if (!(context.Users.Any(u => u.UserName == "a.voivodov@gmail.com")))
            {
                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);
                var userToInsert = new ApplicationUser { UserName = "a.voivodov@gmail.com", Email = "a.voivodov@gmail.com" };
                userManager.Create(userToInsert, "plovdev");
                userManager.AddToRole(userToInsert.Id, "Administrator");
            }
        }
    }
}
