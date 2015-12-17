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
                p => p.Name,
                   new Post { Id = Guid.NewGuid().ToString(), Name = "Менеджер" },
                   new Post { Id = Guid.NewGuid().ToString(), Name = "Інженер" }
               );

            context.Departments.AddOrUpdate(
                p => p.Name,
                   new Department { Id = Guid.NewGuid().ToString(), Name = "D001" },
                   new Department { Id = Guid.NewGuid().ToString(), Name = "D002" },
                   new Department { Id = Guid.NewGuid().ToString(), Name = "D003" }
               );

            context.SalaryTypes.AddOrUpdate(
                st => st.Name,
                    new SalaryType { Id = Guid.NewGuid().ToString(), Name = "Погодинний" },
                    new SalaryType { Id = Guid.NewGuid().ToString(), Name = "Помісячний" }
                );

            context.Persons.AddOrUpdate(
               p => new { p.FirstName, p.SecondName, p.ThirdName },
               new Person
               {
                   Id = Guid.NewGuid().ToString(),
                   FirstName = "Микола",
                   SecondName = "Петров",
                   ThirdName = "Вікторович",
                   Sex = "чоловіча"
               },
               new Person
               {
                   Id = Guid.NewGuid().ToString(),
                   FirstName = "Віктор",
                   SecondName = "Сидорчук",
                   ThirdName = "Вікторович",
                   Sex = "чоловіча"
               },
               new Person
               {
                   Id = Guid.NewGuid().ToString(),
                   FirstName = "Максим",
                   SecondName = "Бойко",
                   ThirdName = "Григорович",
                   Sex = "чоловіча"
               }
                );

            context.StatusTypes.AddOrUpdate(
                st => st.Name,
                new StatusType { Id = Guid.NewGuid().ToString(), Name = "Хворий" },
                new StatusType { Id = Guid.NewGuid().ToString(), Name = "У відпустці" },
                new StatusType { Id = Guid.NewGuid().ToString(), Name = "У відпустці за власний рахунок" }
                );

            context.Languages.AddOrUpdate(
                l => l.Name,
                new LanguageType { Id = Guid.NewGuid().ToString(), Name = "English" },
                new LanguageType { Id = Guid.NewGuid().ToString(), Name = "German" }
                );

            context.KnowledgeTypes.AddOrUpdate(
                k => k.Name,
                new KnowledgeLevelType { Id = Guid.NewGuid().ToString(), Name = "Beginner" },
                new KnowledgeLevelType { Id = Guid.NewGuid().ToString(), Name = "Pre-Intermediate" },
                new KnowledgeLevelType { Id = Guid.NewGuid().ToString(), Name = "Intermediate" },
                new KnowledgeLevelType { Id = Guid.NewGuid().ToString(), Name = "Upper-Intermediate" },
                new KnowledgeLevelType { Id = Guid.NewGuid().ToString(), Name = "Advanced" },
                new KnowledgeLevelType { Id = Guid.NewGuid().ToString(), Name = "Proficiency" }
                );
        }
    }
}
