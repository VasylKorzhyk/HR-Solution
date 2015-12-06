using HRM.DAL.Entities;
using System.Data.Entity;

namespace HRM.DAL
{
    public class HumanDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public HumanDBContext():base("HumanDBContext")
        {
            
        }
    }
}
