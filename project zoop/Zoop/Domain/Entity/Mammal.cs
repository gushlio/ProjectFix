using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Mammal : Animal
    {
        private string furType;

        public Mammal(string species, string name, int age, string gender, string furType)
            : base(species, name, age, gender)
        {
            this.furType = furType;
        }

        public override string MakeSound()
        {
            return "The mammal makes a generic sound.";
        }

        public override string Feed()
        {
            hunger -= 25;
            return "Feeding the mammal.";
        }

        public void Groom()
        {
            hunger += 10;
        }


        public void NurseYoung()
        {
            // Code to nurse young
        }

        public override string ToString()
        {
            return $"Species: {species}, Name: {name}, Age: {age}, Gender: {gender}, Fur Type: {furType}, Hunger Level: {hunger}";
        }
    }
}
