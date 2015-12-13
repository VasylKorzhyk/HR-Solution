using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.DAL.Entities
{
    public class Promotion : Entity
    {
        public string Name { get; set; }
        public PromotionType PromotionType { get; set; }
    }
}
