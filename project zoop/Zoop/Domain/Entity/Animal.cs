using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public abstract class Animal
    {
        protected string species;
        protected string name;
        protected int age;
        protected string gender;
        protected int hunger;

        public string Species
        {
            get { return species; }
            set { this.species = value; }
        }

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return age; }
            set { this.age = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { this.gender = value; }
        }

        public int Hunger
        {
            get { return hunger; }
        }

        public Animal(string species, string name, int age, string gender)
        {
            this.species = species;
            this.name = name;
            this.age = age;
            this.gender = gender;
            hunger = 50;
        }

        public abstract string MakeSound();
        public virtual string Feed()
        {
            hunger -= 20;
            return "Feeding the animal.";
        }

        public abstract string ToString();
    }
}
