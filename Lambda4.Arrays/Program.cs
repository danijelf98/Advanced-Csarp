namespace Lambda4.Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //find even numbers
            int [] even = nums.Where(x => x % 2 == 0).ToArray();
            //find odd nummbers
            int[] odd = nums.Where(x => x % 2 != 0).ToArray();

            foreach (int i in even)
            {
                Console.Write($"{i} " );
            }
            Console.WriteLine();
            foreach (int i in odd)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.WriteLine();

            List<Person> people = new List<Person>()
            {
                new Person {Name = "Alex", LastName = "Turkov"},
                new Person {Name = "Brad", LastName = "Peterson"},
                new Person {Name = "Johnny", LastName = "Turkov"},
                new Person {Name = string.Empty, LastName = "Hemington"}
            };

            List<Person> startsWithA = people.Where(name => name.Name.StartsWith("A")).ToList();
            List<Person> containsA = people.Where(name => name.Name.Contains("a")).ToList();
            List<Person> withoutName = people.Where(name => string.IsNullOrEmpty(name.Name)).ToList();

            foreach (Person person in startsWithA)
            {
                Console.WriteLine($"Name starts with the letter 'A': {person.Name} {person.LastName}");
            }
            foreach (Person person in containsA)
            {
                Console.WriteLine($"Name contains the letter 'A': {person.Name} {person.LastName}");
            }
            foreach (Person person in withoutName)
            {
                Console.WriteLine($"Without hte name: {person.Name} {person.LastName}");
            }


        }
    }
}
