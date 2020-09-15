namespace ToDoListApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using ToDoListApp.Models;
    

    internal sealed class Configuration : DbMigrationsConfiguration<ToDoListApp.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ToDoListApp.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            AddUsers(context);
        }

        void AddUsers (ToDoListApp.Models.ApplicationDbContext context)
        {
            var user = new ApplicationUser { UserName = "test@test.com" };
            var userMang = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            userMang.Create(user, "Pwd@123");
        }
    }
}
