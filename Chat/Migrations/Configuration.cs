namespace Chat.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<Chat.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
       
        }

        protected override void Seed(Chat.Models.ApplicationDbContext context)
        {
            ApplicationUser firstUser = new ApplicationUser()
            {
                UserName = "Grigor"
            };
            ApplicationUser secondUser = new ApplicationUser()
            {
                UserName = "Karen"
            };
            ApplicationUser thirdUser = new ApplicationUser()
            {
                UserName = "Gevorg"
            };
            var store = new UserStore<ApplicationUser>(context);
            var manager = new UserManager<ApplicationUser>(store);

            manager.Create(firstUser, "grigor");
            manager.Create(secondUser, "karen");
            manager.Create(thirdUser, "gevorg");
            UserMassage firstMassage = new UserMassage
            {
                Massage = "Hello",
                DateOfCreate = DateTime.Now,
                User = firstUser
            };
            UserMassage secondMassage = new UserMassage
            {
                Massage = "Hello",
                DateOfCreate = DateTime.Now.AddHours(-5),
                User = secondUser

            };
            UserMassage thirdMassage = new UserMassage
            {
                Massage = "Hello",
                DateOfCreate = DateTime.Now.AddHours(-2),
                User = thirdUser
            };
            context.UserMassage.Add(firstMassage);
            context.UserMassage.Add(secondMassage);
            context.UserMassage.Add(thirdMassage);
         
        }
    }
}
