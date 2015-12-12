using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.DAL.Repositories
{
    public class PersonRepository
    {
        private readonly HumanDBContext context;
        public PersonRepository(HumanDBContext context) 
        {
            this.context = context;
        }
    }
}
