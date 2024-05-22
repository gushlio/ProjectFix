using DataAccessLayer.Repository;
using System.Data;

namespace Domain.Service
{
    public class AnimalService
    {
        private AnimalRepository _animalRepository;
        public AnimalService()
        {
            _animalRepository = new AnimalRepository();
        }
        // Method to retrieve all animals


        // Method to retrieve all animal care records
        public DataTable GetAllAnimalCareRecords()
        {
            return _animalRepository.GetAllAnimalCareRecords();
        }

        // Method to update the location of an animal
        public void UpdateAnimalLocation(string animalName, string location)
        {
            _animalRepository.UpdateAnimalLocation(animalName, location);
        }

        // Method to check if the species already exists
        public bool SpeciesExists(string species)
        {
            return _animalRepository.SpeciesExists(species);
        }

        // Method to check if the location already exists
        public bool LocationExists(string location)
        {
            // Call the corresponding method in the data access layer to check if the location exists
            return _animalRepository.LocationExists(location);
        }


        // Method to get all locations from the Locations table
        public List<string> GetAllLocations()
        {
            // Call the corresponding method in the data access layer to retrieve all locations
            return _animalRepository.GetAllLocations();
        }

        // Method to retrieve all species
        public List<string> GetAllSpecies()
        {

            return _animalRepository.GetAllSpecies();
        }

        // Methods to implement business logic
        public void AddLocation(string location)
        {
            if (!LocationExists(location))
            {
                // Call the corresponding method in the data access layer to store the location
                _animalRepository.AddLocation(location);
            }
            else
            {
                // Handle the case where the location already exists
                Console.WriteLine("Location already exists. Please choose a different location name.");

            }
        }

        // Method to add a new animal
        public void AddAnimal(string name, string species, string color, decimal weight, DateTime dateOfBirth)
        {
            // You can add additional validation here if needed
            _animalRepository.AddAnimal(name, species, color, weight, dateOfBirth);
        }


        public void Deploy(string animalName, string newLocation)
        {
            try
            {
                // Retrieve all animals with details from the database
                DataTable animalsDataTable = _animalRepository.GetAllAnimals();

                // Loop through each row in the DataTable
                foreach (DataRow row in animalsDataTable.Rows)
                {
                    // Get the name of the animal from the row
                    string AnimalName = row["AnimalName"].ToString();

                    // Update the location of the animal to the new location
                    _animalRepository.UpdateAnimalLocation(animalName, newLocation);
                }

                // Provide feedback to the user or log a success message
                Console.WriteLine("Deployment completed successfully.");
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine("Error during deployment: " + ex.Message);
            }
        }

        public void AddSpecies(string species)
        {
            if (!SpeciesExists(species))
            {
                // Call the corresponding method in the data access layer to store the species
                _animalRepository.AddSpecies(species);
            }
            else
            {
                // Handle the case where the species already exists
                Console.WriteLine("Species already exists. Please choose a different species name.");

            }
        }
        // Method to insert data into AnimalClinic table with location
        public void InsertIntoAnimalClinicTable(string animalName, string clinicUpdate, string location)
        {
            // Call the repository method to insert data into AnimalClinic table
            _animalRepository.InsertIntoAnimalClinicTable(animalName, clinicUpdate, location);
        }


        // Method to update the VetAction for an animal in the AnimalClinic table
        public void UpdateVetActionInAnimalClinicTable(string animalName, string remedy)
        {
            // Call the corresponding method in the data access layer to update VetAction
            _animalRepository.UpdateVetActionInAnimalClinicTable(animalName, remedy);
        }

        // Method to insert data into AnimalUpdates table
        public void InsertIntoAnimalUpdatesTable(string animalName, string updateText)
        {
            _animalRepository.InsertIntoAnimalUpdatesTable(animalName, updateText);
        }
        // Method to remove an animal
        public void RemoveAnimal(string animalName)
        {
            _animalRepository.RemoveAnimal(animalName);
        }
        // Method to remove an animal
        public void InsertIntoDeportedAnimalsTable(string animalName, string species, string color, decimal weight, DateTime dateOfBirth, string location, DateTime dateOfRegister)
        {
            _animalRepository.InsertIntoDeportedAnimalsTable(animalName, species, color, weight, dateOfBirth, location, dateOfRegister);
        }


        public DataTable GetAllAnimalsExcludingDeported()
        {
            return _animalRepository.GetAllAnimalsExcludingDeported();
        }

        // Method to retrieve all records from the DeportedAnimals table
        public DataTable GetAllDeportedAnimals()
        {
            return _animalRepository.GetAllDeportedAnimals();
        }

        // Method to retrieve all animals
        public DataTable GetAllAnimals()
        {
            // Call the corresponding method in the data access layer to retrieve all animals
            return _animalRepository.GetAllAnimals();
        }

    }
}
