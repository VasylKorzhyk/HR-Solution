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
    public partial class AddEmployeeForm : Form
    {
        private readonly HumanDBContext context;
        private readonly EmployeeService employeeService;
        private readonly PersonService personService;

        public AddEmployeeForm(HumanDBContext context)
        {
            InitializeComponent();

            this.context = context;
            this.employeeService = new EmployeeService(new EmployeeRepository(context));
            this.personService = new PersonService(new PersonRepository(context));
            this.LoadDataOnForm();
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            employeeService.Add(ReadDataFromForm());
            this.Close();
        }

        private Employee ReadDataFromForm()
        {
            double salary = Double.TryParse(salaryBox.Text, out salary) ? salary : 0;
            return new Employee()
            {
                Id = Guid.NewGuid().ToString(),
                Person = (Person)personBox.SelectedItem,
                ContractID = this.GetHashCode(),
                //ContractType = ContractTypeBox.SelectedItem.ToString(),
                Hiredate = hireDatePicker.Value,
                Firedate = fireDatePicker.Value,
                SalaryType = (SalaryType)salaryTypeBox.SelectedItem,
                Salary = salary,
                Post = (Post)postBox.SelectedItem
            };
        }

        private void LoadDataOnForm()
        {
            this.personBox.DataSource = this.personService.GetAll().ToList();
            this.salaryTypeBox.DataSource = this.context.SalaryTypes.ToList();
            this.postBox.DataSource =  this.context.Posts.ToList();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
