﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.DAL.Entities
{
    public class Employee : Entity
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
    }
}
