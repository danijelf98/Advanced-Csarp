using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_1._Example
{
    public class Employee : IPerson, IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PIN { get; set; }

        public void PrintSection()
        {
            Console.WriteLine("Maintenance");
        }
        public void PrintManager()
        {
            Console.WriteLine("Ivan Markov");
        }
    }
}
