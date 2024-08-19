using Linq_7._SQLExample.Models.Dbo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_7._SQLExample.Services
{
    public class AnimalService
    {
        private readonly MyLinqBaseContext db;

        public AnimalService()
        {
            this.db = new MyLinqBaseContext();
        }

        public Animal AddAnimal(Animal model)
        {
            db.Animals.Add(model);
            db.SaveChanges();
            return model;
        }

        public List<Animal> GetAllAnimals()
        {
            return db.Animals.ToList();
        }

        public Animal GetAnimalById(int id)
        {
            return db.Animals.Find(id);
        }

        public Animal UpdateAnimalById(int id, string? animalName = null, string? habitat = null, int? legNumber = null)
        {
            var animal = db.Animals.Find(id);

            if (!string.IsNullOrEmpty(animalName))
            {
                animal.AnimalName = animalName;
            }
            if (!string.IsNullOrEmpty(habitat))
            {
                animal.Habitat = habitat;
            }
            if (legNumber != null)
            {
                animal.LegNumber = legNumber;
            }

            db.SaveChanges();
            return animal;
        }

        public void DeleteAnimalById(int id)
        {
            var animal = db.Animals.Find(id);
            db.Animals.Remove(animal);
            db.SaveChanges();
        }
    }
}
