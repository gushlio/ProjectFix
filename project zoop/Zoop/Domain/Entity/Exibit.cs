using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Exibit
    {
        private string _name;
        private string _description;
        private int _capacity;
        private List<Animal> _animals = new List<Animal>();

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public int Capacity
        {
            get { return _capacity; }
            set { _capacity = value; }
        }

        public List<Animal> Animals
        {
            get { return _animals; }
        }


        public Exibit(string name, string description, int capacity)
        {
            _name = name;
            _description = description;
            _capacity = capacity;
        }

        public void AddAnimal(Animal animal)
        {
            if (Animals.Count >= Capacity)
            {
                throw new InvalidOperationException("Exhibit is at full capacity.");
            }

            if (Animals.Count > 0 && animal.GetType() != Animals[0].GetType())
            {
                throw new ArgumentException("Only animals of the same type are allowed in this exhibit.");
            }

            Animals.Add(animal);
        }

        public void RemoveAnimal(Animal animal)
        {
            Animals.Remove(animal);
        }

        public void FeedAnimals()
        {
            foreach (var animal in Animals)
            {
                animal.Feed();
            }
        }
    }
}
