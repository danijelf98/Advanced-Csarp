using Linq_17._Quantifiers.Model;

namespace Linq_17._Quantifiers
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

            Console.WriteLine("Checking if everyone are teenagers: ");
            var areTeens = people.All(y => y.Age > 12 && y.Age < 20);
            Console.WriteLine(areTeens);
            Console.WriteLine();

            Console.WriteLine("Checking if list contains number 10: ");
            IList<int> intList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            bool is10Inside = intList.Contains(10);
            Console.WriteLine(is10Inside);
        }
    }
}
