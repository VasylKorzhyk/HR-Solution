using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.DAL.Entities
{
    public class Person : Entity
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public DateTime BirthdayDate { get; set; }
        public string Sex { get; set; }
        public string RegistrationAddress { get; set; }
        public Army Army { get; set; }
        public string PassportID { get; set; }
        public string TaxID { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public string LivingAddress { get; set; }
        public string WorkPhone { get; set; }
        public string PersonalPhone { get; set; }
        public string Citizenship { get; set; }
        public string Disablement { get; set; }
        public string Photo { get; set; }
        public string CV { get; set; }
        public Promotion Promotion { get; set; }
        public WorkerStatus WorkerStatus { get; set; }
        public ICollection<Family> Families { get; set; }
        public ICollection<Language> Languages { get; set; }
        public ICollection<Education> Educations { get; set; }

        public override string ToString()
        {
            return SecondName + " " + FirstName + " " + ThirdName;
        }
    }
}
