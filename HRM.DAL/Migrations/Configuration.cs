namespace HRM.DAL.Migrations
{
    using HRM.DAL.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HRM.DAL.HumanDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "HRM.DAL.HumanDBContext";
        }

        protected override void Seed(HRM.DAL.HumanDBContext context)
        {
            context.Posts.AddOrUpdate(
                    new Post() {Id = Guid.NewGuid().ToString(), Name = "Менеджер"},
                    new Post() {Id = Guid.NewGuid().ToString(), Name = "Інженер"}
                );
            context.SalaryTypes.AddOrUpdate(
                    new SalaryType() { Id = Guid.NewGuid().ToString(), Name = "Погодинна" },
                    new SalaryType() { Id = Guid.NewGuid().ToString(), Name = "Помісячна" }
                );

            context.Persons.AddOrUpdate(
               new Person() 
                {
                    Id = Guid.NewGuid().ToString(),
                    FirstName = "Микола",
                    SecondName = "Петров",
                    ThirdName = "Вікторович",
                    Sex = "чоловіча"
                }
                );
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
