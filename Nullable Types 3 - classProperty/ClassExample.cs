using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable_Types_3___classProperty
{
    public class Address
    {
        public Address(string street, int num)
        {
            Street = street;
            Num = num;
        }

        public string Street { get; set; }
        public int Num { get; set; }
    }
    public class Workplace
    {
        public Workplace(Address address)
        {
            Address = address;
        }

        public Address Address { get; set; }
    }
    public class Person
    {
        public Person(Workplace workplace)
        {
            Workplace = workplace;
        }

        public Workplace Workplace { get; set; }
    }
    public class People
    {
        public People()
        {
        }

        public People(Person person)
        {
            Person = person;
        }

        public Person Person { get; set; }
    }
}
