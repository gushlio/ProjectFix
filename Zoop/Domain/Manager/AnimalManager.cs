using DataAccessLayer;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Manager
{
    public class AnimalManager
    {
        private AnimalDB animalDB;

        public AnimalManager()
        {
            // Initialize an instance of AnimalDB for data access
            animalDB = new AnimalDB();
        }

        public void AddAnimal(Animal animal)
        {
            // Call the AddAnimal method of the AnimalDB to add the animal
            animalDB.AddAnimal(animal.Name, animal.Species, animal.Age, animal.Gender, animal.Weight, animal.Color, animal.IsSick, animal.Location, animal.LastFeedTime);
        }

        public List<Animal> GetAllAnimals()
        {
            // Get all animals from the database
            List<IDictionary<string, object>> animalsData = animalDB.GetAllAnimals();
            List<Animal> animals = new List<Animal>();

            // Transform the data into a list of Animal objects
            foreach (var animalData in animalsData)
            {
                Animal animal = new Animal(
                    Convert.ToInt32(animalData["AnimalID"]),
                    animalData["Name"].ToString(),
                    animalData["Species"].ToString(),
                    Convert.ToInt32(animalData["Age"]),
                    animalData["Gender"].ToString(),
                    Convert.ToDecimal(animalData["Weight"]),
                    animalData["Color"].ToString(),
                    Convert.ToBoolean(animalData["IsSick"]),
                    animalData["Location"].ToString(),
                    Convert.ToDateTime(animalData["LastFeedTime"])
                );
                animals.Add(animal);
            }

            return animals;
        }

        public void DeleteAnimal(Animal animal)
        {
            // Call the DeleteAnimal method of the AnimalDB to delete the animal
            animalDB.DeleteAnimal(animal.AnimalID);
        }

        public void UpdateAnimal(Animal animal)
        {
            // Call the UpdateAnimal method of the AnimalDB to update the animal
            animalDB.UpdateAnimal(animal.AnimalID, animal.Name, animal.Species, animal.Age, animal.Gender, animal.Weight, animal.Color, animal.IsSick, animal.Location, animal.LastFeedTime);
        }
    }
}
