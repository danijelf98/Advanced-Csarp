namespace Linq_3._Syntax
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

            Person[] filteredPeople = new Person[5];

            filteredPeople = (from person in people
                              where person.Age > 15 && person.Age < 22
                              select person).ToArray();

            Console.WriteLine("People older than 15 and younger than 22 are: ");
            Console.WriteLine();
            foreach (var person in filteredPeople)
            {
                Console.WriteLine($"{person.Id}. {person.FullName}, {person.Age}" );
            }
            Console.WriteLine();

            //using the Method Syntax Style

            filteredPeople = people.Where(person => person.Age > 15 && person.Age < 22).ToArray();

            foreach (var person in filteredPeople)
            {
                Console.WriteLine($"{person.Id}. {person.FullName}, {person.Age}");
            }
            Console.WriteLine();
        }
    }
}
