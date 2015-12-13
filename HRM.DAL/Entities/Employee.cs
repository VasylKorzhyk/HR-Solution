using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.DAL.Entities
{
    public class Employee : Entity
    {
        public Person Person { get; set; }
        public int ContractID { get; set; }
        public string ContractType { get; set; }
        public DateTime Hiredate { get; set; }
        public DateTime Firedate { get; set; }
        public Post Post { get; set; }
        public WorkType WorkType { get; set; }
        public DateTime Probation { get; set; }
        public SalaryType SalaryType { get; set; }
        public double Salary { get; set; }

        public string ToString()
        {
            return Person.SecondName + " " + Person.FirstName + " " + Person.ThirdName;
        }
    }
}
