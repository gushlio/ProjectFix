using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Bird : Animal
    {
        private bool canFly;
        private double wingspan;
        private string beakType;

        public Bird(string species, string name, int age, string gender, bool canFly, double wingspan, string beakType)
        : base(species, name, age, gender)
        {
            this.canFly = canFly;
            this.wingspan = wingspan;
            this.beakType = beakType;
        }

        public override string MakeSound()
        {
            return "The bird chirps.";
        }

        public override string Feed()
        {
            hunger -= 15;
            return "Feeding seeds to the bird.";
        }

        public void Fly()
        {
            if (canFly)
            {
                hunger += 5;
            }
        }

        public void BuildNest()
        {
            // Code to build a nest
        }

        public override string ToString()
        {
            return $"Species: {species}, Name: {name}, Age: {age}, Gender: {gender}, Wingspan: {wingspan}, Beak Type: {beakType}, Hunger Level: {hunger}";
        }
    }
}
