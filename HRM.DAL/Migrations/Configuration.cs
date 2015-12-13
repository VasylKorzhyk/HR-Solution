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
                    new Post() {Id = Guid.NewGuid().ToString(), Name = "��������"},
                    new Post() {Id = Guid.NewGuid().ToString(), Name = "�������"}
                );
            context.SalaryTypes.AddOrUpdate(
                    new SalaryType() { Id = Guid.NewGuid().ToString(), Name = "���������" },
                    new SalaryType() { Id = Guid.NewGuid().ToString(), Name = "��������" }
                );

            context.Persons.AddOrUpdate(
               new Person() 
                {
                    Id = Guid.NewGuid().ToString(),
                    FirstName = "������",
                    SecondName = "������",
                    ThirdName = "³��������",
                    Sex = "�������"
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
