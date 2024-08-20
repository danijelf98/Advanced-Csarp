using Linq_11._ThenBy.Model;

namespace Linq_11._ThenBy
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


            //ascendind ThenBy
            var thenBy_Linq_multiple_ascending = people
                .OrderBy(p => p.FullName)
                .ThenBy(p => p.Age);

            Console.WriteLine("ThenBy multiple ascending:");
            foreach (var result in thenBy_Linq_multiple_ascending)
            {
                Console.WriteLine($"{result.FullName} {result.Age}");
            }
            Console.WriteLine();

            //descending ThenBy
            var thenBy_Linq_multiple_descending = people
                .OrderBy(p => p.FullName)
                .ThenByDescending(p => p.Age);

            Console.WriteLine("ThenBy multiple descending:");
            foreach (var result in thenBy_Linq_multiple_descending)
            {
                Console.WriteLine($"{result.FullName} {result.Age}");
            }

        }
    }
}
