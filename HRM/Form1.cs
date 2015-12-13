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
            new AddPersonForm(this.context).ShowDialog();
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            new AddEmployeeForm(this.context).ShowDialog();
        }

        private void addStatusButton_Click(object sender, EventArgs e)
        {
            new AddStatusForm(this.context).ShowDialog();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            this.PersonDataGrid.Rows.Clear();
            this.personService.GetAll().ToList()
                .Select(p => PersonDataGrid.Rows.Add(p.Id, p.SecondName, p.FirstName, p.ThirdName)).ToList();

            this.EmployeeDataGrid.Rows.Clear();
            this.employeeService.GetAll().ToList()
                .Select(em => EmployeeDataGrid.Rows.Add(em.Id, em.Person, em.Post.Department, em.Post, em.ContractType, em.Hiredate.ToString("dd-MM-yyyy"))).ToList();

            this.StatusDataGrid.Rows.Clear();
            this.employeeService.GetAll().ToList()
                .Select(em => StatusDataGrid.Rows.Add(em.Id, em.Person, em.Post.Department, em.Post, em.Person.WorkerStatus)).ToList();

        }
    }
}
