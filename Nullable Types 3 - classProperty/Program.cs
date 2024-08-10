namespace Nullable_Types_3___classProperty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            People getPerson = new People();
            var adresa = GetAddress(getPerson);
            if (adresa != null)
            {
                Console.WriteLine(adresa.Street);
            }

            People newPerson = new People(new Person(new Workplace(new Address("old street", 55))));
            var person = GetAddress(newPerson);
            if (person != null)
            {
                Console.WriteLine(person.Street);
            }

            List<Vehicle> vehicles = new List<Vehicle>()
            {
                new Vehicle()
                {
                    Name = "VW",
                    Model = "Polo",
                    PreviousOwner = "Ivo Ivic"
                },
                new Vehicle()
                {
                    Name = "Merc",
                    Model = "AMG-GT"
                }
            };
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Vehicle Name is: {vehicle.Name}");
                Console.WriteLine($"Vehicle Model is: {vehicle.Model}");
                if (vehicle.PreviousOwner != null)
                {
                    Console.WriteLine($"Vehicle's Previous Owner is: {vehicle.PreviousOwner}");
                }
                else
                {
                    Console.WriteLine("Vehicle is brand new, and it doesn't have a owner");
                }
                Console.WriteLine("");
            }
        }
        private static Address GetAddress(People getP)
        {
            if (getP.Person?.Workplace?.Address != null)
            {
                return getP.Person?.Workplace?.Address;
            }
            return null;
        }
    }
}
