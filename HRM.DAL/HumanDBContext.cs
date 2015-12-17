using HRM.DAL.Entities;
using System;
using System.Data.Entity;
using System.Data.SqlTypes;

namespace HRM.DAL
{
    public class HumanDBContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<WorkType> WorkTypes { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<SalaryType> SalaryTypes { get; set; }
        public DbSet<StatusType> StatusTypes { get; set; }
        public DbSet<LanguageType> Languages { get; set; }
        public DbSet<KnowledgeLevelType> KnowledgeTypes {get; set;}
        public HumanDBContext():base("HumanDBContext")
        {
        }

        public override int SaveChanges()
        {
            UpdateDates();
            return base.SaveChanges();
        }

        private void UpdateDates()
        {
            foreach (var change in ChangeTracker.Entries<Entity>())
            {
                if (change.State == EntityState.Deleted) { return; }
                var values = change.CurrentValues;
                foreach (var name in values.PropertyNames)
                {
                    var value = values[name];
                    if (value is DateTime)
                    {
                        var date = (DateTime)value;
                        if (date < SqlDateTime.MinValue.Value)
                        {
                            values[name] = SqlDateTime.MinValue.Value;
                        }
                        else if (date > SqlDateTime.MaxValue.Value)
                        {
                            values[name] = SqlDateTime.MaxValue.Value;
                        }
                    }
                }
            }
        }
    }
}
