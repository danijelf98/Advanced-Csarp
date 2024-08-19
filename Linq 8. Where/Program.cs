using Linq_8._Where.Model;

namespace Linq_8._Where
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person { Id = 1, FullName = "Matt Nathan", Age = 14 },
                new Person { Id = 2, FullName = "Kevin Levis", Age = 27 },
                new Person { Id = 3, FullName = "George Harrison", Age = 22 },
                new Person { Id = 4, FullName = "Johnny Clarkson", Age = 20 },
                new Person { Id = 5, FullName = "Austin Dunham", Age = 17 },
            };

            //using a delegate func example

            Func<Person, bool> isTeen = delegate (Person person)
            {
                return person.Age > 12 && person.Age < 20;
            };

            var filtert_result_by_Delegate = from person in people
                                             where isTeen(person)
                                             select person.FullName;

            foreach (var person in filtert_result_by_Delegate)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine();

            //using an external method 

            Console.WriteLine("External Method: ");
            var filter_externally = from person in people
                                    where IsTeenager(person)
                                    select person.FullName;

            foreach (var person in filter_externally)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine();

            //using a lambda style  and external method
            var external_lambda_filter = people
                .Where(p => IsTeenager(p))
                .Select(p => p.FullName);

            Console.WriteLine("External Lambda style: ");
            foreach (var person in external_lambda_filter)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine();

            //Linq Where example with multiple statements
            Console.WriteLine("Linq where example with multiple statements: ");
            var filter_with_statement = people.Where((p, i) => 
            {
                if (i % 2 == 0)
                {
                    return true;
                }
                return false;
            });

            Console.WriteLine("Odd elements are: ");
            foreach (var p in filter_with_statement)
            {
                Console.WriteLine(p.FullName);
            }
            Console.WriteLine();

            //Linq filter with multiple where
            var multiple_where_filter = from p in people
                                        where p.Age > 12
                                        where p.Age < 20
                                        select p.FullName;

            Console.WriteLine("Multiple where Linq example: ");
            foreach (var person in multiple_where_filter)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine();
            //Multiple where lambda example

            multiple_where_filter = people
                .Where(p => p.Age > 12)
                .Where(p => p.Age < 20)
                .Select(p => p.FullName);

            Console.WriteLine("Multiple where lambda example: ");
            foreach (var person in multiple_where_filter)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine();
        }

        public static bool IsTeenager(Person person)
        {
            return person.Age > 12 && person.Age < 20;
        }
    }
}
