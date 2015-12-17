using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.DAL.Entities
{
    public class Language : Entity
    {
        public virtual LanguageType LanguageType { get; set; }
        public virtual KnowledgeLevelType KnowledgeLevelType { get; set; }
    }
}
