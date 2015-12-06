using HRM.DAL.Entities;
using System;
using System.Data.Entity;
using System.Data.SqlTypes;

namespace HRM.DAL
{
    public class HumanDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

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
