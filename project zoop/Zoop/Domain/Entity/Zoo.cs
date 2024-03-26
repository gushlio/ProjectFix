using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Zoo
    {
        private string _name;
        private string _location;
        private string _openingHours;
        private string _contactInfo;
        private List<Animal> _animals = new List<Animal>();
        public List<Employee> EmployeeList { get; } = new List<Employee>();
        public List<Task> tasks { get; } = new List<Task>();

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }

        public string OpeningHours
        {
            get { return _openingHours; }
            set { _openingHours = value; }
        }

        public string ContactInfo
        {
            get { return _contactInfo; }
            set { _contactInfo = value; }
        }

        public List<Animal> Animals
        {
            get { return _animals; }
        }

        public Zoo(string name, string location, string openingHours, string contactInfo)
        {
            _name = name;
            _location = location;
            _openingHours = openingHours;
            _contactInfo = contactInfo;
        }

        public void AddAnimal(Animal animal)
        {
            _animals.Add(animal);
        }

        public void RemoveAnimal(Animal animal)
        {
            _animals.Remove(animal);
        }

        public Animal[] GetAllAnimals()
        {
            return _animals.ToArray();
        }

        public void AddStaff(Employee employee)
        {
            EmployeeList.Add(employee);
        }
    }
}
