using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.DAL.Entities
{
    public class Army : Entity
    {
        public DateTime Hiredate {get; set;}
        public DateTime Firedate { get; set; }
        public string Registration { get; set; }
    }
}
