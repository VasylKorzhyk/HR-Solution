using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.DAL.Repositories
{
    public class StatusRepository
    {
        private readonly HumanDBContext context;
        public StatusRepository(HumanDBContext context)
        {
            this.context = context;
        }
    }
}
