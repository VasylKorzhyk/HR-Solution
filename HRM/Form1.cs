using HRM.DAL;
using HRM.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRM.BLL.Services;
using HRM.DAL.Entities;

namespace HRM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var context = new HumanDBContext();
            EmployeeService employeeService = new EmployeeService(new EmployeeRepository(context));
            employeeService.Add(new Employee() {
                Id = Guid.NewGuid().ToString(),
                FirstName = "First",
                SecondName = "Second"
            });
            IEnumerable<Employee> All = employeeService.GetAll();

            new AddPerson().Show();
        }
    }
}
