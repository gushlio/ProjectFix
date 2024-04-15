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

        public Reptile(string name, string species, int age, string gender, decimal weight, string color, bool isSick, string location, DateTime lastFeedTime, string scaleType, string eggType, bool isColdBlooded)
            : base(name, species, age, gender, weight, color, isSick, location, lastFeedTime)
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
            LastFeedTime = DateTime.Now;
            return "Feeding insects to the reptile.";
        }

        public void Bask()
        {
            if (isColdBlooded)
            {
            }
        }

        public void RegulateBodyTemperature()
        {
            // Code to regulate body temperature
        }

        public override string ToString()
        {
            return $"Species: {Species}, Name: {Name}, Age: {Age}, Gender: {Gender}, Scale Type: {scaleType}, Egg Type: {eggType}, Weight: {Weight}, Color: {Color}, Is Sick: {IsSick}, Location: {Location}, Last Feed Time: {LastFeedTime}";
        }
    }
}
