using Azure;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Drawing;
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

        public Bird(int animalID, string name, string species, int age, string gender, decimal weight, string color, bool isSick, string location, DateTime lastFeedTime, bool canFly, double wingspan, string beakType)
        : base(animalID, name, species, age, gender, weight, color, isSick, location, lastFeedTime)
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
            LastFeedTime = DateTime.Now;
            return "Feeding seeds to the bird.";
        }

        public void Fly()
        {
            if (canFly)
            {
            }
        }

        public void BuildNest()
        {
            // Code to build a nest
        }

        public override string ToString()
        {
            return $"Species: {Species}, Name: {Name}, Age: {Age}, Gender: {Gender}, Wingspan: {wingspan}, Beak Type: {beakType}, Weight: {Weight}, Color: {Color}, Is Sick: {IsSick}, Location: {Location}, Last Feed Time: {LastFeedTime}";
        }
    }
}
