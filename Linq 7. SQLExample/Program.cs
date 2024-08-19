using Linq_7._SQLExample.Models.Dbo;
using Linq_7._SQLExample.Services;

namespace Linq_7._SQLExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region People Database
            //MyLinqBaseContext db = new MyLinqBaseContext();

            ////Get all people from Database
            //var peopleFromDb = db.People.ToList();

            //foreach (var person in peopleFromDb)
            //{
            //    Console.WriteLine($"FullName: {person.FirstName} {person.LastName}");
            //}

            ////Create a new Person in Database
            ////var newPerson = new Person()
            ////{
            ////    FirstName = "Marko",
            ////    LastName = "Markov",
            ////    Pin = "789456123"
            ////};

            ////Add new Person in Database
            ////db.People.Add(newPerson);
            ////db.SaveChanges();

            ////Find person with specific Id
            //Console.WriteLine();
            //Console.WriteLine("Person with Id number 2 is: ");

            //var personWithId2 = db.People.FirstOrDefault(p => p.Id == 2);
            //Console.WriteLine($"{personWithId2.FirstName} {personWithId2.LastName}");
            ////different way
            //Console.WriteLine("Person with Id number 3 is: ");
            //var personWithId3 = db.People.Find(3);
            //Console.WriteLine($"{personWithId3.FirstName} {personWithId3.LastName}");

            ////delete person from Database
            ////db.Remove(personWithId3);
            ////db.SaveChanges();
            #endregion

            #region Animals Database

            AnimalService animalService = new AnimalService();
            var animals = animalService.GetAllAnimals();

            void ShowAnimals()
            {
                animals = animalService.GetAllAnimals();
                foreach (var animal in animals)
                {
                    Console.WriteLine();
                    Console.Write($"Id: {animal.Id}, Name: {animal.AnimalName}, Habitat: {animal.Habitat}, Legs: {animal.LegNumber}");
                }
                Console.WriteLine();
                Console.WriteLine();

            }

            //Get All Animals
            Console.WriteLine("List of all animals in database: ");
            ShowAnimals();

            //Get Animal by Id
            Console.WriteLine("Chose animal Id to show only this animal: ");

            int id = int.Parse(Console.ReadLine());
            var animalId = animalService.GetAnimalById(id);

            Console.WriteLine("The chosen animal is: ");
            Console.WriteLine(animalId.AnimalName);
            Console.WriteLine();


            //Add animal
            Console.WriteLine("To add a new animal, enter animal's name: ");
            Animal newAnimal = new Animal()
            {
                AnimalName = Console.ReadLine(),
            };
            Console.WriteLine();

            Console.WriteLine("Enter animal's habitat: ");
            newAnimal.Habitat = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Enter how many legs this animal has:");
            newAnimal.LegNumber = int.Parse(Console.ReadLine());
            animalService.AddAnimal(newAnimal);

            animals = animalService.GetAllAnimals();
            Console.WriteLine();
            Console.WriteLine("New List after adding: ");
            ShowAnimals();

            //Update animal
            animals = animalService.GetAllAnimals();
            Console.WriteLine("Select animal's Id you want edit: ");
            foreach (var animal in animals)
            {
                Console.WriteLine($"Id: {animal.Id} Name: {animal.AnimalName}");
            }

            int updateAnimalId = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Insert new Name: ");

            string newAnimalName = Console.ReadLine();
            animalService.UpdateAnimalById(updateAnimalId, newAnimalName);

            Console.WriteLine("New Animal details are: ");
            ShowAnimals();

            //Delete animal
            Console.WriteLine("Choose animal's Id you want to delete");
            foreach (var animal in animals)
            {
                Console.WriteLine($"Id: {animal.Id} Name: {animal.AnimalName}");
            }

            int deleteAnimalId = int.Parse(Console.ReadLine());
            animalService.DeleteAnimalById(deleteAnimalId);

            Console.WriteLine();
            Console.WriteLine("New Animal list: ");

            ShowAnimals();

            #endregion

        }
    }
}
