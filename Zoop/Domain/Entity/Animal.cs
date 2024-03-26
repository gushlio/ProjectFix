using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Animal
    {
        public int AnimalID { get; set; } // Unique identifier for the animal
        public string Name { get; set; } // Name of the animal
        public string Species { get; set; } // Species of the animal
        public int Age { get; set; } // Age of the animal
        public string Gender { get; set; } // Gender of the animal
        public decimal Weight { get; set; } // Weight of the animal
        public string Color { get; set; } // Color of the animal
        public bool IsSick { get; set; } // Indicates whether the animal is sick
        public string Location { get; set; } // Location of the animal
        public DateTime LastFeedTime { get; set; } // Last feed time of the animal

        // Constructor
        public Animal(int animalID, string name, string species, int age, string gender, decimal weight, string color, bool isSick, string location, DateTime lastFeedTime)
        {
            AnimalID = animalID;
            Name = name;
            Species = species;
            Age = age;
            Gender = gender;
            Weight = weight;
            Color = color;
            IsSick = isSick;
            Location = location;
            LastFeedTime = lastFeedTime;
        }

        public virtual string MakeSound()
        {
            return "animal sounds";
        }
        public virtual string Feed()
        {
            LastFeedTime = DateTime.Now;
            return "Feeding the animal.";
        }

        public virtual string ToString()
        {
            return "blalala";
        }

    }
}
