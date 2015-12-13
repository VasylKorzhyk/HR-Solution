using HRM.DAL.Entities;
using HRM.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.BLL.Services
{
    public class PersonService
    {
        private readonly PersonRepository personRepository;

        public PersonService(PersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }

        public IEnumerable<Person> GetAll()
        {
            return this.personRepository.GetAll();
        }
    }
}
