using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.DAL.Entities
{
    public class Work : Entity
    {
        public string WorkPlace { get; set; }
        public DateTime Hiredate { get; set; }
        public DateTime Firedate { get; set; }
        public string Post { get; set; }
    }
}
