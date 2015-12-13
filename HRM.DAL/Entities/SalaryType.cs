using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.DAL.Entities
{
    public class SalaryType : Entity
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
    
}
