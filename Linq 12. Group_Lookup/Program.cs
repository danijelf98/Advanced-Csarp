using Linq_12._Group_Lookup.Model;

namespace Linq_12._Group_Lookup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] people =
            {
                new Person { Id = 1, FullName = "Matt Nathan", Age = 15 },
                new Person { Id = 2, FullName = "Kevin Levis", Age = 27 },
                new Person { Id = 3, FullName = "George Harrison", Age = 27 },
                new Person { Id = 4, FullName = "Johnny Clarkson", Age = 20 },
                new Person { Id = 4, FullName = "Johnny Clarkson", Age = 15 },
                new Person { Id = 5, FullName = "Austin Dunham", Age = 15 },
                new Person { Id = 5, FullName = "Austin Dunham", Age = 25 },
            };

            #region Linq Grouping

            //Linq grouping
            var groupByAge = from p in people
                             group p by p.Age;

            foreach (var ageGroup in groupByAge)
            {
                Console.WriteLine($"Age group: {ageGroup.Key}");
                foreach (Person person in ageGroup)
                {
                    Console.WriteLine(person.FullName);
                }
                Console.WriteLine();
            }

            //lambda grouping
            Console.WriteLine("Lambda grouping: ");
            Console.WriteLine();
            var groupByAgeLambda = people.GroupBy(p => p.Age);

            foreach (var ageGroup in groupByAgeLambda)
            {
                Console.WriteLine($"Age group: {ageGroup.Key}");
                foreach (Person p in ageGroup)
                {
                    Console.WriteLine(p.FullName);
                }
                Console.WriteLine();
            }

            #endregion

            #region Lookup

            Console.WriteLine("Lamda ToLookup: ");
            Console.WriteLine();
            var lookupGrouping = people.ToLookup(p => p.Age);

            foreach (var ageGroup in lookupGrouping)
            {
                Console.WriteLine($"Age group: {ageGroup.Key}");
                foreach (Person p in ageGroup)
                {
                    Console.WriteLine(p.FullName);
                }
                Console.WriteLine();
            }

            #endregion
        }
    }
}
