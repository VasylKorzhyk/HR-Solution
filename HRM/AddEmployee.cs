using HRM.BLL.Services;
using HRM.DAL;
using HRM.DAL.Entities;
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

namespace HRM
{
    public partial class AddEmployee : Form
    {
        private readonly HumanDBContext context;
        private readonly EmployeeService employeeService;
        public AddEmployee(HumanDBContext context)
        {
            InitializeComponent();
            this.context = context;
            this.employeeService = new EmployeeService(new EmployeeRepository(context));
            this.LoadDataOnForm();
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {

        }

        private Employee ReadDataFromForm()
        {
            return new Employee()
            {
                Id = Guid.NewGuid().ToString()
            };
        }

        private void LoadDataOnForm()
        {
            this.personBox.DataSource = employeeService.GetAll().Select( x => x.SecondName + " " + x.FirstName + " " + x.ThirdName ).ToList();
        }
    }
}
