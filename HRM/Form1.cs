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
using System.Collections;

namespace HRM
{
    public partial class Form1 : Form
    {
        private readonly HumanDBContext context;
        private readonly PersonService personService;
        private readonly EmployeeService employeeService;
        private readonly StatusService statusService;

        private readonly List<string> personParameters;
        private readonly List<string> employeeParameters;
        private readonly List<string> statusParameters;

        public Form1()
        {
            InitializeComponent();

            this.context = new HumanDBContext();
            this.personService = new PersonService(new PersonRepository(this.context));
            this.employeeService = new EmployeeService(new EmployeeRepository(this.context));
            this.statusService = new StatusService(new StatusRepository(this.context));

            this.searchPersonParametrs.DataSource = new[] { "Прізвище", "Ім'я", "По-батькові", "Вік" };
            this.searchPersonParametrs.SelectedIndex = 0;

            this.searchEmployeeParametrs.DataSource = new[] { "П.І.Б.", "Відділення", "Посада", "Вид договору", "Дата створення договору" };
            this.searchEmployeeParametrs.SelectedIndex = 2;

            this.searchStatusParametrs.DataSource = new[] { "П.І.Б.", "Відділення", "Посада", "Вид договору", "Статус" };
            this.searchStatusParametrs.SelectedIndex = 4;

            personParameters = new List<string>();
            employeeParameters = new List<string>();
            statusParameters = new List<string>();
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

        private void fireEmployeeButton_Click(object sender, EventArgs e)
        {
            var id = EmployeeDataGrid.SelectedRows.Count != 0 ?
                 EmployeeDataGrid.SelectedRows[0].Cells[0].Value != null ?
                 EmployeeDataGrid.SelectedRows[0].Cells[0].Value.ToString() : "" : "";
            if (id != "") { this.employeeService.Remove(id); } else { MessageBox.Show("Працівник не знайдений!"); };
        }

        private void PersonDataGrid_DoubleClick(object sender, EventArgs e)
        {
            DataGridView dg = (DataGridView)sender;
            var id = dg.CurrentRow.Cells[0].Value != null ?
                 dg.CurrentRow.Cells[0].Value.ToString() : "";

            if (id != "") { new EditPersonForm(context, id).Show(); } else { MessageBox.Show("Працівник не знайдений!"); };
        }

        private void EmployeeDataGrid_DoubleClick(object sender, EventArgs e)
        {
            DataGridView dg = (DataGridView)sender;
            var id = dg.CurrentRow.Cells[0].Value != null ?
                 dg.CurrentRow.Cells[0].Value.ToString() : "";

            if (id != "") { new EditEmployeeForm(context, id).Show(); } else { MessageBox.Show("Працівник не знайдений!"); };
        }

        private void SearchPerson(List<string> personParameters)
        {
            if (personParameters.Count == 0) { return; }
            IEnumerable<Person> persons = personService.GetAll();
            foreach (var param in personParameters)
            {
                if (persons == null) { return; };

                switch (param.Split(' ')[0])
                {
                    case "Прізвище:":
                        persons = persons.Where(x => x.SecondName == param.Split(' ')[1]).ToList();
                        break;
                    case "Ім'я:":
                        persons = persons.Where(x => x.FirstName == param.Split(' ')[1]).ToList();
                        break;
                    case "По-батькові:":
                        persons = persons.Where(x => x.ThirdName == param.Split(' ')[1]).ToList();
                        break;
                    case "Вік:":
                        persons = persons.Where(x => ((DateTime.Now.Year - x.BirthdayDate.Year).ToString() == param.Split(' ')[1])).ToList();
                        break;

                }
                this.PersonDataGrid.Rows.Clear();
                if (persons.Count() != 0)
                {
                    persons.ToList()
                        .Select(p => PersonDataGrid.Rows.Add(p.Id, p.SecondName, p.FirstName, p.ThirdName)).ToList();
                }
                else
                {
                    personParameters.Clear();
                    this.personRequestList.Items.Clear();
                    searchPersonParametrs.Text = "";
                    MessageBox.Show("Результат відсутній!");
                }
            }


        }

        private void addSearchRequestButton_Click(object sender, EventArgs e)
        {
            if (searchPersonValue.Text == "") return;
            var request = searchPersonParametrs.Text + ": " + searchPersonValue.Text;
            personParameters.Add(request);
            this.personRequestList.Items.Add(request);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchPerson(personParameters);
        }

        private void addEmployeeRequestButton_Click(object sender, EventArgs e)
        {
            if (searchEmployeeValue.Text == "") return;
            var request = searchPersonParametrs.Text + ": " + searchEmployeeValue.Text;
            personParameters.Add(request);
            this.personRequestList.Items.Add(request);
        }

        private void searchEmployeeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
