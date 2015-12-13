using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRM.DAL.Repositories;
using HRM.DAL.Entities;

namespace HRM.BLL.Services
{
    public class EmployeeService
    {
        private readonly EmployeeRepository employeeRepository;
        public EmployeeService(EmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public void Add(Employee employee)
        {
            this.employeeRepository.Add(employee);
        }

        public void Update(Employee employee)
        {
            this.employeeRepository.Update(employee);
        }

        public Employee Get(string id)
        {
            return this.employeeRepository.Get(id);
        }

        public IEnumerable<Employee> GetAll()
        {
            return this.employeeRepository.GetAll();
        }
    }
}
