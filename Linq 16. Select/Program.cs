using Linq_16._Select.Model;

namespace Linq_16._Select
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person { Id = 1, FullName = "Matt Nathan", Age = 12 },
                new Person { Id = 2, FullName = "Kevin Levis", Age = 27 },
                new Person { Id = 3, FullName = "George Harrison", Age = 22 },
                new Person { Id = 4, FullName = "Johnny Clarkson", Age = 20 },
                new Person { Id = 4, FullName = "Johnny Clarkson", Age = 13 },
                new Person { Id = 5, FullName = "Austin Dunham", Age = 17 },
                new Person { Id = 5, FullName = "Austin Dunham", Age = 25 },
            };

            //Linq select FullName

            var just_FullName = from p in people
                                select p.FullName;
            
            //lambda Select
            var i = people.Select(p => p.FullName);

            foreach (var person in just_FullName)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine();


            // Linq anonym. Select 
            var anonymType = from p in people
                             select new
                             {
                                 Person = p.FullName,
                                 Age = p.Age,
                             };

            Console.WriteLine("Linq Select: ");
            foreach (var person in anonymType)
            {
                Console.WriteLine($"{person.Person}: {person.Age}");
            }
            Console.WriteLine();

            // Lambda anonym Select
            Console.WriteLine("Lambda Select: ");
            var anonymLambda = people.Select(p => new
            {
                Person = p.FullName,
                Age = p.Age,
            });
            foreach (var person in anonymLambda)
            {
                Console.WriteLine($"{person.Person}: {person.Age}");
            }
            Console.WriteLine();
        }
    }
}
