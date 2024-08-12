namespace Lambda5.Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create an object of person with properties, Id, Name, Last name, Date of Birth
            //Use lambda expressions to filter:
            //1.List of underaged 
            //2.Those whose Id is less than 3
            //3.Those whose last name contains letter 'a' and begin with letter 'm'
            //4.All who are born on Tuesday

            Person person = new Person();
            var people = person.GetPerson();

            var underaged = people.Where(x => (DateTime.Now.Year - x.BirthDate.Year) < 18).ToList();
            var idSmallerThan3 = people.Where(x => x.Id < 3).ToList();
            var contains_a_beginsWith_m = people.Where(x => x.LastName.ToLower().Contains("a") && x.LastName.ToLower().StartsWith("m")).ToList();
            var bornOnTuesday = people.Where(x => x.BirthDate.DayOfWeek == DayOfWeek.Tuesday).ToList();

            Console.WriteLine("Underaged:");
            foreach (Person human in underaged)
            {
                Console.WriteLine($"{human.Id}, {human.Name}, {human.LastName}, {human.BirthDate.Year}");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Id smaller than 3:");
            foreach (Person human in idSmallerThan3)
            {
                Console.WriteLine($"{human.Id}, {human.Name}, {human.LastName}, {human.BirthDate.Year}");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Last Name contains A, begins with M:");
            foreach (Person human in contains_a_beginsWith_m)
            {
                Console.WriteLine($"{human.Id}, {human.Name}, {human.LastName}, {human.BirthDate.Year}");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Born on Tuesday:");
            foreach (Person human in bornOnTuesday)
            {
                Console.WriteLine($"{human.Id}, {human.Name}, {human.LastName}, {human.BirthDate.Year}");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

    }
}

