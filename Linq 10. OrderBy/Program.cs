using Linq_10._OrderBy.Model;

namespace Linq_10._OrderBy
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
                new Person { Id = 5, FullName = "Austin Dunham", Age = 17 },
            };

            #region OrderBy ascending

            //using a linq
            var linq_order_by_Name = from p in people
                                  orderby p.FullName
                                  select p;

            Console.WriteLine("Linq ascending order: ");
            Console.WriteLine();
            foreach (var person in linq_order_by_Name)
            {
                Console.WriteLine(person.FullName);
            }
            Console.WriteLine();

            //using a lambda
            var lamda_orderby_name = people.OrderBy(p => p.FullName);

            Console.WriteLine("Lambda ascending order: ");
            Console.WriteLine();
            foreach (var person in lamda_orderby_name)
            {
                Console.WriteLine(person.FullName);
            }
            Console.WriteLine();

            #endregion

            #region OrderBy Descending

            var linq_OrderByDescending = from p in people
                                         orderby p.FullName descending
                                         select p;

            Console.WriteLine("Linq Descending order: ");
            Console.WriteLine();
            foreach (var person in linq_OrderByDescending)
            {
                Console.WriteLine(person.FullName);
            }
            Console.WriteLine();

            var lambda_OrderByDescending = people.OrderByDescending(p => p.FullName);

            Console.WriteLine("Lambda Descending order: ");
            Console.WriteLine();
            foreach (var person in lambda_OrderByDescending)
            {
                Console.WriteLine(person.FullName);
            }
            Console.WriteLine();

            #endregion

            #region Multiple sorting

            //Linq ultiple sorting
            var linq_multiple_sorting = from p in people
                                   orderby p.FullName, p.Age
                                   select new { p.FullName, p.Age };

            Console.WriteLine("Linq multiple sorting: ");
            Console.WriteLine();
            foreach (var person in linq_multiple_sorting)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine();
            #endregion
        }
    }
}
