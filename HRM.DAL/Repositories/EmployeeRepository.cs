using HRM.DAL.Entities;
using System;
using System.Collections.Generic;
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

        public IEnumerable<Employee> GetAll()
        {
            return this.context.Employees;
        }
    }
}
