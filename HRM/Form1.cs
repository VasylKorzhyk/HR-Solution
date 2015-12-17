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
using Word = Microsoft.Office.Interop.Word;

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

            this.searchEmployeeParametrs.DataSource = new[] { "П.І.Б.", "Відділення", "Посада", "Вид договору" };
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
            var request = searchEmployeeParametrs.Text + ": " + searchEmployeeValue.Text;
            employeeParameters.Add(request);
            this.employeeRequestList.Items.Add(request);
        }

        private void searchEmployeeButton_Click(object sender, EventArgs e)
        {
            try
            {
                SearchEmployee(employeeParameters);
            }
            catch { }
        }

        private void SearchEmployee(List<string> employeeParameters)
        {
            if (employeeParameters.Count == 0) { return; }
            IEnumerable<Employee> employee = employeeService.GetAll();
            foreach (var param in employeeParameters)
            {
                if (employee == null) { return; };
                switch (param.Split(' ')[0])
                {
                    case "П.І.Б.:":
                        employee = employee.Where(x => (String.Format("{0} {1} {2}", x.Person.SecondName, x.Person.FirstName, x.Person.ThirdName)) == param.Split(' ')[1]).ToList();
                        break;
                    case "Відділення:":
                        employee = employee.Where(x => x.Post.Department.Name == param.Split(' ')[1]).ToList();
                        break;
                    case "Посада:":
                        employee = employee.Where(x => x.Post.Name == param.Split(' ')[1]).ToList();
                        break;
                    case "Вид_договору:":
                        employee = employee.Where(x => x.ContractType == param.Split(' ')[1]).ToList();
                        break;

                }
                this.EmployeeDataGrid.Rows.Clear();
                if (employee.Count() != 0)
                {
                    employee.ToList()
                        .Select(p => EmployeeDataGrid.Rows.Add(p.Id, p.Person, p.Post.Department, p.Post, p.ContractType, p.Hiredate)).ToList();
                }
                else
                {
                    employeeParameters.Clear();
                    this.employeeRequestList.Items.Clear();
                    searchEmployeeParametrs.Text = "";
                    MessageBox.Show("Результат відсутній!");
                }
            }
        }

        private void FindAndReplace(Microsoft.Office.Interop.Word.Application WordApp, object findText, object replaceWithText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundsLike = false;
            object nmatchAllWordForms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiacritics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            WordApp.Selection.Find.Execute(ref findText,
                ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundsLike,
                ref nmatchAllWordForms, ref forward,
                ref wrap, ref format, ref replaceWithText,
                ref replace, ref matchKashida,
                ref matchDiacritics, ref matchAlefHamza,
                ref matchControl);
        }
        private void monthWorkReport_Click(object sender, EventArgs e)
        {
            Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
            Word.Document newDoc = null;
            DateTime now = DateTime.Now;
            newDoc = wordApp.Documents.Add(Application.StartupPath+"\\monthWorkReport.doc");
            newDoc.Activate();
            IEnumerable<Employee> employees = this.employeeService.GetAll();
            //date
            this.FindAndReplace(wordApp, "<day>", now.Day);
            this.FindAndReplace(wordApp, "<month>", now.ToString("MMMM"));
            this.FindAndReplace(wordApp, "<year>", now.Year);
            //codes
            this.FindAndReplace(wordApp, "<orgName>", orgName.Text);
            this.FindAndReplace(wordApp, "<adr>", orgAdr.Text);
            this.FindAndReplace(wordApp, "<edprou>", EDPROU.Text);
            this.FindAndReplace(wordApp, "<coatuu>", COATUU.Text);
            this.FindAndReplace(wordApp, "<qved>", QVED.Text);
            this.FindAndReplace(wordApp, "<kfv>", KFV.Text);
            this.FindAndReplace(wordApp, "<kopfg>", KOPFG.Text);
            this.FindAndReplace(wordApp, "<kodu>", KODU.Text);
            //topEDPROU
            this.FindAndReplace(wordApp, "<e>", EDPROU.Text[0]);
            this.FindAndReplace(wordApp, "<d>", EDPROU.Text[1]);
            this.FindAndReplace(wordApp, "<p>", EDPROU.Text[2]);
            this.FindAndReplace(wordApp, "<r>", EDPROU.Text[3]);
            this.FindAndReplace(wordApp, "<o>", EDPROU.Text[4]);
            this.FindAndReplace(wordApp, "<u>", EDPROU.Text[5]);
            this.FindAndReplace(wordApp, "<nu>", EDPROU.Text[6]);
            this.FindAndReplace(wordApp, "<m>", EDPROU.Text[7]);

            this.FindAndReplace(wordApp, "<rmAvCount>", employees.Where(x => x.WorkType.WorkTime == "Повна зайнятість" && (x.Hiredate.Month < DateTime.Now.Month)).Count());
            this.FindAndReplace(wordApp, "<AvCount>", employees.Where(x => x.WorkType.WorkTime == "Повна зайнятість" && (x.Hiredate.Month < DateTime.Now.Year)).Count());
            this.FindAndReplace(wordApp, "<rmAvStCount>", employees.Where(x => (x.Hiredate.Month < DateTime.Now.Year) && (x.Hiredate.Month < DateTime.Now.Month)).Count());
            this.FindAndReplace(wordApp, "<AvStCount>", employees.Where(x => (x.Hiredate.Month < DateTime.Now.Year)));

            wordApp.Visible = true;
        }
        //private void vacancyReport_Click(object sender, EventArgs e)
        //{
        //    Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
        //    Microsoft.Office.Interop.Word.Document newDoc = null;
        //    DateTime now = DateTime.Now;
        //    newDoc = wordApp.Documents.Add(@"F:\vacancyAvailabilityReport.rtf");
        //    newDoc.Activate();
        //    //date
        //    this.FindAndReplace(wordApp, "<day>", now.Day);
        //    this.FindAndReplace(wordApp, "<month>", now.ToString("MMMM"));
        //    this.FindAndReplace(wordApp, "<year>", now.Year);
        //    //codes
        //    this.FindAndReplace(wordApp, "<orgName>", orgName.Text);
        //    this.FindAndReplace(wordApp, "<adr>", orgAdr.Text);
        //    this.FindAndReplace(wordApp, "<edprou>", EDPROU.Text);
        //    this.FindAndReplace(wordApp, "<coatuu>", COATUU.Text);
        //    this.FindAndReplace(wordApp, "<qved>", QVED.Text);
        //    this.FindAndReplace(wordApp, "<kfv>", KFV.Text);
        //    this.FindAndReplace(wordApp, "<kopfg>", KOPFG.Text);
        //    this.FindAndReplace(wordApp, "<kodu>", KODU.Text);

        //    //queries here
        //    /*for(int i=0;i<res.Count;i++)
        //    {
        //        this.FindAndReplace(wordApp, "<prof"+i+">", result);
        //        this.FindAndReplace(wordApp, "<code"+i+">", result);
        //        this.FindAndReplace(wordApp, "<typ"+i+">", result);
        //        this.FindAndReplace(wordApp, "<reg"+i+">", result);
        //        this.FindAndReplace(wordApp, "<wc"+i+">", result);
        //        this.FindAndReplace(wordApp, "<sc"+i+">", result);
        //        this.FindAndReplace(wordApp, "<sal"+i+">", result);
        //        this.FindAndReplace(wordApp, "<not"+i+">", result);
        //        this.FindAndReplace(wordApp, "<exp"+i+">", result);
        //        this.FindAndReplace(wordApp, "<edul"+i+">", result);
        //        this.FindAndReplace(wordApp, "<spec"+i+">", result);
        //        this.FindAndReplace(wordApp, "<lev"+i+">", result);
        //        this.FindAndReplace(wordApp, "<lad"+i+">", result);
        //        this.FindAndReplace(wordApp, "<add"+i+">", result);
        //        this.FindAndReplace(wordApp, "<dis"+i+">", result);
        //    }*/

        //    wordApp.Visible = true;
        //}

        //private void releaseReport_Click(object sender, EventArgs e)
        //{
        //    Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
        //    Microsoft.Office.Interop.Word.Document newDoc = null;
        //    DateTime now = DateTime.Now;
        //    newDoc = wordApp.Documents.Add(@"F:\workerReleaseReport.rtf");
        //    newDoc.Activate();
        //    //date
        //    this.FindAndReplace(wordApp, "<day>", now.Day);
        //    this.FindAndReplace(wordApp, "<mon>", now.Month);
        //    this.FindAndReplace(wordApp, "<month>", now.ToString("MMMM"));
        //    this.FindAndReplace(wordApp, "<year>", now.Year);
        //    //codes
        //    this.FindAndReplace(wordApp, "<orgName>", orgName.Text);
        //    this.FindAndReplace(wordApp, "<adr>", orgAdr.Text);
        //    this.FindAndReplace(wordApp, "<edprou>", EDPROU.Text);
        //    this.FindAndReplace(wordApp, "<coatuu>", COATUU.Text);
        //    this.FindAndReplace(wordApp, "<qved>", QVED.Text);
        //    this.FindAndReplace(wordApp, "<kfv>", KFV.Text);
        //    this.FindAndReplace(wordApp, "<kopfg>", KOPFG.Text);
        //    this.FindAndReplace(wordApp, "<kodu>", KODU.Text);

        //    //queries here
        //    /*for(int i=0;i<res.Count;i++)
        //    {
        //        this.FindAndReplace(wordApp, "<name"+i+">", result);
        //        this.FindAndReplace(wordApp, "<ID"+i+">", result);
        //        this.FindAndReplace(wordApp, "<prn"+i+">", result);
        //        this.FindAndReplace(wordApp, "<pid"+i+">", result);
        //        this.FindAndReplace(wordApp, "<qual"+i+">", result);
        //        this.FindAndReplace(wordApp, "<sal"+i+">", result);
        //        this.FindAndReplace(wordApp, "<dat"+i+">", result);
        //        this.FindAndReplace(wordApp, "<wp"+i+">", result);
        //        this.FindAndReplace(wordApp, "<s"+i+">", result);
        //        this.FindAndReplace(wordApp, "<bd"+i+">", result);
        //        this.FindAndReplace(wordApp, "<edu"+i+">", result);
        //        this.FindAndReplace(wordApp, "<dis"+i+">", result);
        //        this.FindAndReplace(wordApp, "<nd"+i+">", result);
        //        this.FindAndReplace(wordApp, "<pd"+i+">", result);
        //        this.FindAndReplace(wordApp, "<ladr"+i+">", result);
        //    }*/

        //    wordApp.Visible = true;
        //}

        //private void wCountReport_Click(object sender, EventArgs e)
        //{
        //    Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
        //    Microsoft.Office.Interop.Word.Document newDoc = null;
        //    DateTime now = DateTime.Now;
        //    newDoc = wordApp.Documents.Add(@"F:\workerCountReport.rtf");
        //    newDoc.Activate();
        //    //date
        //    this.FindAndReplace(wordApp, "<day>", now.Day);
        //    this.FindAndReplace(wordApp, "<month>", now.ToString("MMMM"));
        //    this.FindAndReplace(wordApp, "<year>", now.Year);
        //    //codes
        //    this.FindAndReplace(wordApp, "<orgName>", orgName.Text);
        //    this.FindAndReplace(wordApp, "<adr>", orgAdr.Text);
        //    this.FindAndReplace(wordApp, "<edprou>", EDPROU.Text);
        //    this.FindAndReplace(wordApp, "<coatuu>", COATUU.Text);
        //    this.FindAndReplace(wordApp, "<qved>", QVED.Text);
        //    this.FindAndReplace(wordApp, "<kfv>", KFV.Text);
        //    this.FindAndReplace(wordApp, "<kopfg>", KOPFG.Text);
        //    this.FindAndReplace(wordApp, "<kodu>", KODU.Text);
        //    //topEDPROU
        //    this.FindAndReplace(wordApp, "<e>", EDPROU.Text[0]);
        //    this.FindAndReplace(wordApp, "<d>", EDPROU.Text[1]);
        //    this.FindAndReplace(wordApp, "<p>", EDPROU.Text[2]);
        //    this.FindAndReplace(wordApp, "<r>", EDPROU.Text[3]);
        //    this.FindAndReplace(wordApp, "<o>", EDPROU.Text[4]);
        //    this.FindAndReplace(wordApp, "<u>", EDPROU.Text[5]);
        //    this.FindAndReplace(wordApp, "<nu>", EDPROU.Text[6]);
        //    this.FindAndReplace(wordApp, "<m>", EDPROU.Text[7]);

        //    //queries here
        //    /*this.FindAndReplace(wordApp, "<wCount>", queryresult);
        //    this.FindAndReplace(wordApp, "<fwCount>", queryresult);
        //    this.FindAndReplace(wordApp, "<nfCount>", queryresult);
        //    this.FindAndReplace(wordApp, "<fnfCount>", queryresult);
        //    this.FindAndReplace(wordApp, "<34Count>", queryresult);
        //    this.FindAndReplace(wordApp, "<f34Count>", queryresult);
        //    this.FindAndReplace(wordApp, "<24Count>", queryresult);
        //    this.FindAndReplace(wordApp, "<f24Count>", queryresult);
        //    this.FindAndReplace(wordApp, "<54Count>", queryresult);
        //    this.FindAndReplace(wordApp, "<f54Count>", queryresult);
        //    this.FindAndReplace(wordApp, "<59Count>", queryresult);
        //    this.FindAndReplace(wordApp, "<f59Count>", queryresult);
        //    this.FindAndReplace(wordApp, "<nfedu>", queryresult);
        //    this.FindAndReplace(wordApp, "<fnfedu>", queryresult);
        //    this.FindAndReplace(wordApp, "<fedu>", queryresult);
        //    this.FindAndReplace(wordApp, "<ffedu>", queryresult);
        //    this.FindAndReplace(wordApp, "<preg>", queryresult);
        //    this.FindAndReplace(wordApp, "<decret>", queryresult);
        //    this.FindAndReplace(wordApp, "<fdecret>", queryresult);
        //    this.FindAndReplace(wordApp, "<up>", queryresult);
        //    this.FindAndReplace(wordApp, "<fup>", queryresult);
        //    this.FindAndReplace(wordApp, "<wup>", queryresult);
        //    this.FindAndReplace(wordApp, "<fwup>", queryresult);
        //    this.FindAndReplace(wordApp, "<sup>", queryresult);
        //    this.FindAndReplace(wordApp, "<fsup>", queryresult);
        //    this.FindAndReplace(wordApp, "<fup>", queryresult);
        //    this.FindAndReplace(wordApp, "<ffup>", queryresult);*/

        //    wordApp.Visible = true;
        //}
    }
}
