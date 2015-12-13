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
        private readonly HumanDBContext context;
        private readonly PersonService personService;
        private readonly EmployeeService employeeService;
        private readonly StatusService statusService;

        public Form1()
        {
            InitializeComponent();

            this.context = new HumanDBContext();
            this.personService = new PersonService(new PersonRepository(this.context));
            this.employeeService = new EmployeeService(new EmployeeRepository(this.context));
            this.statusService = new StatusService(new StatusRepository(this.context));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new AddPersonForm(this.personService).Show();
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            new AddEmployeeForm(this.context).Show();
        }
    }
}
