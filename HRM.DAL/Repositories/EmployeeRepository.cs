using HRM.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.DAL.Repositories
{
    public class EmployeeRepository
    {
        private readonly HumanDBContext context;

        public EmployeeRepository(HumanDBContext context)
        {
            this.context = context;
        }

        public void Add(Employee employee)
        {
            this.context.Employees.Add(employee);
            this.context.SaveChanges();
        }

        public Employee Get(string id)
        {
            return this.context.Employees.Find(id);
        }

        public void Update(Employee employee)
        {
            this.context.Employees.Attach(employee);
            this.context.Entry(employee).State = EntityState.Modified;
            this.context.SaveChanges();
        }

        public IEnumerable<Employee> GetAll()
        {
            return this.context.Employees;
        }
    }
}
