using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Reptile : Animal
    {
        private bool isColdBlooded;
        private string scaleType;
        private string eggType;

        public Reptile(string species, string name, int age, string gender, string scaleType, string eggType, bool isColdBlooded)
            : base(species, name, age, gender)
        {
            this.isColdBlooded = isColdBlooded;
            this.scaleType = scaleType;
            this.eggType = eggType;
        }

        public override string MakeSound()
        {
            return "The reptile hisses.";
        }

        public override string Feed()
        {
            hunger -= 10;
            return "Feeding insects to the reptile.";
        }

        public void Bask()
        {
            if (isColdBlooded)
            {
                hunger += 5;
            }
        }

        public void RegulateBodyTemperature()
        {
            // Code to regulate body temperature
        }

        public override string ToString()
        {
            return $"Species: {species}, Name: {name}, Age: {age}, Gender: {gender}, Scale Type: {scaleType}, Egg Type: {eggType}, Hunger Level: {hunger}";
        }
    }
}
