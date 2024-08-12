using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda5.Exercise
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public List<Person> GetPerson()
        {
            List<Person> people = new List<Person>()
            {
                new Person { Id = 1, Name = "Michael", LastName = "Anderson", BirthDate = new DateTime(1995, 03, 12) },
                new Person { Id = 2, Name = "Emily", LastName = "Carter", BirthDate = new DateTime(1988, 08, 23) },
                new Person { Id = 3, Name = "Sarah", LastName = "Johnson", BirthDate = new DateTime(1992, 12, 07) },
                new Person { Id = 4, Name = "James", LastName = "Maller", BirthDate = new DateTime(1986, 02, 18) },
                new Person { Id = 5, Name = "Olivia", LastName = "Thompson", BirthDate = new DateTime(2015, 07, 12) }
            };

            return people;
        }
    }
}
