using HRM.BLL.Services;
using HRM.DAL;
using HRM.DAL.Entities;
using HRM.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRM
{
    public partial class AddPersonForm : Form
    {
        private readonly HumanDBContext context;
        private readonly PersonService personService;
        public AddPersonForm(HumanDBContext context)
        {
            InitializeComponent();

            this.context = context;
            this.personService = new PersonService(new PersonRepository(this.context));
            this.LoadDataOnForm();
        }

        private void LoadDataOnForm()
        {

            DataGridViewComboBoxColumn languages = new DataGridViewComboBoxColumn();
            languages.HeaderText = "Мова";
            languages.DataSource = this.context.Languages.Select(x => x.Name).ToList();
            languages.Width = 150;

            DataGridViewComboBoxColumn knowledgeLevel = new DataGridViewComboBoxColumn();
            knowledgeLevel.HeaderText = "Рівень знання";
            knowledgeLevel.DataSource = this.context.KnowledgeTypes.Select(x => x.Name).ToList();
            knowledgeLevel.Width = 150;

            this.languageDataGrid.Columns.Clear();
            this.languageDataGrid.Columns.Add(languages);
            this.languageDataGrid.Columns.Add(knowledgeLevel);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Person person = ReadDataFromForm();
            if (IsCorrectData(person))
            {
                this.personService.Add(person);
                this.Close();
            }
            else
            {
                MessageBox.Show("Необхідно ввести повне ім'я");
            }
        }

        private Person ReadDataFromForm()
        {

            var person = new Person
            {
                Id = Guid.NewGuid().ToString(),
                FirstName = firstName.Text,
                SecondName = secondName.Text,
                ThirdName = thirdName.Text,
                BirthdayDate = birthDayPicker.Value,
                RegistrationAddress = registrationLocation.Text,
                Sex = sexBox.SelectedItem.ToString(),
                PassportID = passportID.Text,
                TaxID = taxID.Text,
                LivingAddress = livingLocation.Text,
                PersonalPhone = phone.Text,
                WorkPhone = workPhone.Text,
                Citizenship = Nationality.Text,
                Army = new Army { Id = Guid.NewGuid().ToString(), Registration = Military.Text },
                Disablement = Invalidity.Text
            };

            savePhoto(person);
            saveCV(person);

            return person;
        }

        private void savePhoto(Person person)
        {
            if (photoBox.Image != null)
            {
                person.Photo = String.Format("{0}\\{1}.jpg", Application.StartupPath, person.Id);
                photoBox.Image.Save(person.Photo);
            }
        }

        private void saveCV(Person person)
        {
            if (cvLabel.Text != String.Empty && cvLabel.Text != "Не знайдено...")
            {
                person.CV = String.Format("{0}\\{1}.{2}", Application.StartupPath, person.Id, cvLabel.Text.Split('.').Last());
                File.Copy(cvLabel.Text, person.CV);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void photoBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "picture files (*.jpg)|*.jpg|All files (*.*)|*.*";
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                photoBox.SizeMode = PictureBoxSizeMode.Zoom;
                photoBox.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void cvButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.cvLabel.Text = openFileDialog1.FileName;
            }
            else
            {
                this.cvLabel.Text = String.Empty;
            }
        }

        private void languageDataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void languageDataGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex > -1 && this.languageDataGrid.Rows[e.RowIndex].Cells[1].Value == null)
            {
                this.languageDataGrid.Rows[e.RowIndex].Cells[1].Value = "Beginner";
            }
            if (e.RowIndex > -1 && this.languageDataGrid.Rows[e.RowIndex].Cells[0].Value == null && this.languageDataGrid.Rows[e.RowIndex].Cells[1].Value != null)
            {
                this.languageDataGrid.Rows.Remove(this.languageDataGrid.Rows[e.RowIndex]);
            }
        }

        private static bool IsCorrectData(Person person)
        {
            return IsCorrectName(person) &&
                IsCorrectPersInfo(person) &&
                IsCorrectGenInfo(person) &&
                IsCorrectDate(person);
        }

        private static bool IsCorrectName(Person person)
        {
            return person.FirstName != String.Empty && person.SecondName != String.Empty && person.ThirdName != String.Empty;
        }
        private static bool IsCorrectGenInfo(Person person)
        {
            return person.RegistrationAddress != String.Empty && person.PassportID != String.Empty && person.TaxID != String.Empty
                    && person.LivingAddress != String.Empty;
        }
        private static bool IsCorrectDate(Person person)
        {
            return person.BirthdayDate < DateTime.Now && person.BirthdayDate > new DateTime(1940, 1, 1);
        }

        private static bool IsCorrectPersInfo(Person person)
        {
            return person.Citizenship != String.Empty && ((person.Sex == "жіноча" && person.Army == null) || person.Army != null) && person.Disablement != String.Empty
                && person.Languages != null;
        }
    }
}
