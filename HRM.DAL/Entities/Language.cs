﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.DAL.Entities
{
    public class Language : Entity
    {
        LanguageType LanguageType { get; set; }
        KnowledgeLevelType KnowledgeLevelType { get; set; }
    }
}
