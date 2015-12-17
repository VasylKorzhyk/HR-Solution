using HRM.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public void Add(Person person)
        {
            this.context.Persons.Add(person);
            this.context.SaveChanges();
        }

        public IEnumerable<Person> GetAll()
        {
            return context.Persons;
        }

        public Person Get(string id)
        {
            return context.Persons.Find(id);
        }

        public void Update(Person person)
        {
            this.context.Entry(person).State = EntityState.Modified;
            this.context.SaveChanges();
        }
    }
}
