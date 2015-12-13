using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.DAL.Entities
{
    public class Post : Entity
    {
        public string Name { get; set; }
        public virtual Department Department { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
