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
                   new Post { Id = Guid.NewGuid().ToString(), Name = "��������" },
                   new Post { Id = Guid.NewGuid().ToString(), Name = "�������" }
               );

            context.Departments.AddOrUpdate(
                p => p.Name,
                   new Department { Id = Guid.NewGuid().ToString(), Name = "D001" },
                   new Department { Id = Guid.NewGuid().ToString(), Name = "D002" },
                   new Department { Id = Guid.NewGuid().ToString(), Name = "D003" }
               );

            context.SalaryTypes.AddOrUpdate(
                st => st.Name,
                    new SalaryType { Id = Guid.NewGuid().ToString(), Name = "����������" },
                    new SalaryType { Id = Guid.NewGuid().ToString(), Name = "���������" }
                );

            context.Persons.AddOrUpdate(
               p => new { p.FirstName, p.SecondName, p.ThirdName },
               new Person
               {
                   Id = Guid.NewGuid().ToString(),
                   FirstName = "������",
                   SecondName = "������",
                   ThirdName = "³��������",
                   Sex = "�������"
               },
               new Person
               {
                   Id = Guid.NewGuid().ToString(),
                   FirstName = "³����",
                   SecondName = "��������",
                   ThirdName = "³��������",
                   Sex = "�������"
               },
               new Person
               {
                   Id = Guid.NewGuid().ToString(),
                   FirstName = "������",
                   SecondName = "�����",
                   ThirdName = "����������",
                   Sex = "�������"
               }
                );

            context.StatusTypes.AddOrUpdate(
                st => st.Name,
                new StatusType { Id = Guid.NewGuid().ToString(), Name = "������" },
                new StatusType { Id = Guid.NewGuid().ToString(), Name = "� ��������" },
                new StatusType { Id = Guid.NewGuid().ToString(), Name = "� �������� �� ������� �������" }
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
