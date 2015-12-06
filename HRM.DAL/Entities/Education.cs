using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.DAL.Entities
{
    public class Education : Entity
    {
        public EducationType EducationType { get; set; }
        public string EducationPlace { get; set; }

        public string Specialization { get; set; }
        public string Qualification { get; set; }
        public DateTime EndingDate { get; set; }

        public string DiplomID { get; set; }

    }
}
