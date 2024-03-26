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

        public Mammal(int animalID, string name, string species, int age, string gender, decimal weight, string color, bool isSick, string location, DateTime lastFeedTime, string furType)
            : base(animalID, name, species, age, gender, weight, color, isSick, location, lastFeedTime)
        {
            this.furType = furType;
        }

        public override string MakeSound()
        {
            return "The mammal makes a generic sound.";
        }

        public override string Feed()
        {
            LastFeedTime = DateTime.Now;
            return "Feeding the mammal.";
        }

        public void Groom()
        {
        }


        public void NurseYoung()
        {
            // Code to nurse young
        }

        public override string ToString()
        {
            return $"Species: {Species}, Name: {Name}, Age: {Age}, Gender: {Gender}, Fur Type: {furType}, Weight: {Weight}, Color: {Color}, Is Sick: {IsSick}, Location: {Location}, Last Feed Time: {LastFeedTime}";
        }
    }
}
