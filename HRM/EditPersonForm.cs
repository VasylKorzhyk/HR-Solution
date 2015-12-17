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
    public partial class EditPersonForm : Form
    {
        private readonly HumanDBContext context;
        private readonly PersonService personService;
        private Person person;
        public EditPersonForm(HumanDBContext context, string id)
        {
            InitializeComponent();

            this.context = context;
            this.personService = new PersonService(new PersonRepository(this.context));

            this.person = this.personService.Get(id);

            firstName.Text = person.FirstName;
            secondName.Text = person.SecondName;
            thirdName.Text = person.ThirdName;
            birthDayPicker.Value = person.BirthdayDate;
            registrationLocation.Text = person.RegistrationAddress;
            sexBox.SelectedItem = person.Sex;
            passportID.Text = person.PassportID;
            taxID.Text = person.TaxID;
            livingLocation.Text = person.LivingAddress;
            phone.Text = person.PersonalPhone;
            workPhone.Text = person.WorkPhone;
            Nationality.Text = person.Citizenship;
            Military.Text = person.Army != null ? person.Army.Registration : "";
            Invalidity.Text = person.Disablement;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ReadDataFromForm();
            if (IsCorrectName(person))
            {
                this.personService.Update(person);
                this.Close();
            }
            else
            {
                MessageBox.Show("Необхідно ввести повне ім'я");
            }
        }

        private static bool IsCorrectName(Person person)
        {
            return person.FirstName != String.Empty && person.SecondName != String.Empty && person.ThirdName != String.Empty;
        }

        private void ReadDataFromForm()
        {
            person.FirstName = firstName.Text;
            person.SecondName = secondName.Text;
            person.ThirdName = thirdName.Text;
            person.BirthdayDate = birthDayPicker.Value;
            person.RegistrationAddress = registrationLocation.Text;
            person.Sex = sexBox.SelectedItem.ToString();
            person.PassportID = passportID.Text;
            person.TaxID = taxID.Text;
            person.LivingAddress = livingLocation.Text;
            person.PersonalPhone = phone.Text;
            person.WorkPhone = workPhone.Text;
            person.Citizenship = Nationality.Text;
            person.Army = new Army { Id = Guid.NewGuid().ToString(), Registration = Military.Text };
            person.Disablement = Invalidity.Text;

            savePhoto(person);
            saveCV(person);
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
    }
}
