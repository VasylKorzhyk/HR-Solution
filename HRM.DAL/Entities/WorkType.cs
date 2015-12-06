using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.DAL.Entities
{
    public class WorkType : Entity
    {
        public string Name { get; set; }
        public int WorkCode { get; set; }
        public double WorkTime { get; set; }
    }
}
