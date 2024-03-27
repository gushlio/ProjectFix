using Domain.Entity;
using Domain.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooBazarDesktopApp.UserControls
{
    public partial class AnimalsUC : UserControl
    {
        private AnimalManager animalManager;
        public AnimalsUC()
        {
            InitializeComponent();
            animalManager = new AnimalManager();
            LoadAnimals();
        }

        private void AnimalsUC_Load(object sender, EventArgs e)
        {

        }
        private void LoadAnimals()
        {
            List<Animal> animals = animalManager.GetAllAnimals();
            dataGridViewAnimals.DataSource = animals;
        }
        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            // Get input from text boxes and create an Animal object
            Animal animal = new Animal(
                0, // AnimalID (0 because it will be assigned by the database)
                txtName.Text,
                txtSpecies.Text,
                int.Parse(txtAge.Text),
                txtGender.Text,
                decimal.Parse(txtWeight.Text),
                txtColor.Text,
                chkIsSick.Checked,
                txtLocation.Text,
                DateTime.Parse(txtLastFeedTime.Text)
            );

            // Call AddAnimal method of AnimalManager to add the animal
            animalManager.AddAnimal(animal);
            MessageBox.Show("Animal added successfully!");
            ClearAllFields();
        }

        private void btnUpdateAnimal_Click(object sender, EventArgs e)
        {
            // Get input from text boxes and create an Animal object
            Animal animal = new Animal(
                int.Parse(txtAnimalID.Text),
                txtName.Text,
                txtSpecies.Text,
                int.Parse(txtAge.Text),
                txtGender.Text,
                decimal.Parse(txtWeight.Text),
                txtColor.Text,
                chkIsSick.Checked,
                txtLocation.Text,
                DateTime.Parse(txtLastFeedTime.Text)
            );

            // Call UpdateAnimal method of AnimalManager to update the animal
            animalManager.UpdateAnimal(animal);
            MessageBox.Show("Animal updated successfully!");
            ClearAllFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int animalID = int.Parse(txtAnimalID.Text);

            // Create a temporary animal object with only AnimalID set
            Animal animal = new Animal(animalID, "", "", 0, "", 0, "", false, "", DateTime.Now);

            // Call DeleteAnimal method of AnimalManager to delete the animal
            animalManager.DeleteAnimal(animal);
            MessageBox.Show("Animal deleted successfully!");
            ClearAllFields();
        }
        private void ClearAllFields()
        {
            txtAnimalID.Clear();
            txtName.Clear();
            txtSpecies.Clear();
            txtAge.Clear();
            txtGender.Clear();
            txtWeight.Clear();
            txtColor.Clear();
            chkIsSick.Checked = false;
            txtLocation.Clear();
            txtLastFeedTime.Clear();
        }
    }
}
