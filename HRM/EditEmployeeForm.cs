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
    public partial class EditEmployeeForm : Form
    {
        private readonly HumanDBContext context;
        private readonly EmployeeService employeeService;
        private readonly PersonService personService;
        private Employee employee;

        public EditEmployeeForm(HumanDBContext context, string id)
        {
            InitializeComponent();

            this.context = context;
            this.employeeService = new EmployeeService(new EmployeeRepository(context));
            this.personService = new PersonService(new PersonRepository(context));
            this.employee = employeeService.Get(id);
            this.LoadDataOnForm();
        }

        private void ReadDataFromForm()
        {
            double salary = Double.TryParse(salaryBox.Text, out salary) ? salary : 0;

            this.employee.Person = (Person)personBox.SelectedItem;
            this.employee.ContractID = this.GetHashCode();
            this.employee.Post.Department = (Department)departmentBox.SelectedItem;
            this.employee.ContractType = ContractTypeBox.SelectedItem.ToString();
            this.employee.Hiredate = hireDatePicker.Value;
            this.employee.Firedate = fireDatePicker.Value;
            this.employee.SalaryType = (SalaryType)salaryTypeBox.SelectedItem;
            this.employee.Salary = salary;
            this.employee.Post = (Post)postBox.SelectedItem;
        }

        private void LoadDataOnForm()
        {
            this.personBox.DataSource = this.personService.GetAll().ToList();
            this.salaryTypeBox.DataSource = this.context.SalaryTypes.ToList();
            this.departmentBox.DataSource = this.context.Departments.ToList();
            this.postTypeBox.DataSource = new[]{"Повна зайнятість", "Часткова зайнятість" };
            this.postTypeBox.SelectedText = "Повна зайнятість";
            this.postBox.DataSource = this.context.Posts.ToList();
            this.ContractTypeBox.SelectedItem = "Короткостроковий";
            this.ContractIDBox.Text = this.GetHashCode().ToString();
            personBox.SelectedItem = employee.Person;
            hireDatePicker.Value = employee.Hiredate;
            fireDatePicker.Value = employee.Firedate;
            salaryTypeBox.SelectedItem = employee.SalaryType;
            salaryBox.Text = employee.Salary.ToString();
            postBox.SelectedItem = employee.Post;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            ReadDataFromForm();
            this.employeeService.Update(employee);
            this.Close();
        }
    }
}
