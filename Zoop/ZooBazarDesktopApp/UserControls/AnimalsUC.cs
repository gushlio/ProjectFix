using Domain.Entity;
using Domain.Manager;


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
            dtpLastFeedTime.Format = DateTimePickerFormat.Custom;
            dtpLastFeedTime.CustomFormat = "yyyy-MM-dd";
            dtpAge.Format = DateTimePickerFormat.Custom;
            dtpAge.CustomFormat = "yyyy-MM-dd";
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
            // Get input from text boxes and DateTimePicker controls and create an Animal object
            Animal animal = new Animal(
                txtName.Text,
                txtSpecies.Text,
                GetAgeFromDateTimePicker(), // Get age from DateTimePicker
                txtGender.Text,
                decimal.Parse(txtWeight.Text),
                txtColor.Text,
                chkIsSick.Checked,
                txtLocation.Text,
                dtpLastFeedTime.Value
            );

            // Call AddAnimal method of AnimalManager to add the animal
            animalManager.AddAnimal(animal);
            MessageBox.Show("Animal added successfully!");

            // Clear all fields
            ClearAllFields();

            // Reload animals data and update DataGridView
            LoadAnimals();
        }

        private void btnUpdateAnimal_Click(object sender, EventArgs e)
        {
            // Get input from text boxes and DateTimePicker controls and create an Animal object
            Animal animal = new Animal(
                txtName.Text,
                txtSpecies.Text,
                GetAgeFromDateTimePicker(), // Get age from DateTimePicker
                txtGender.Text,
                decimal.Parse(txtWeight.Text),
                txtColor.Text,
                chkIsSick.Checked,
                txtLocation.Text,
                dtpLastFeedTime.Value
            );

            // Call UpdateAnimal method of AnimalManager to update the animal
            animalManager.UpdateAnimal(animal);
            MessageBox.Show("Animal updated successfully!");
            ClearAllFields();
        }
        // Helper method to get age from DateTimePicker
        private int GetAgeFromDateTimePicker()
        {
            DateTime birthDate = dtpAge.Value;
            DateTime currentDate = DateTime.Today;
            int age = currentDate.Year - birthDate.Year;
            if (birthDate > currentDate.AddYears(-age))
                age--;
            return age;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            

            // Create a temporary animal object with only AnimalID set
            Animal animal = new Animal("", "", 0, "", 0, "", false, "", DateTime.Now);

            // Call DeleteAnimal method of AnimalManager to delete the animal
            animalManager.DeleteAnimal(animal);
            MessageBox.Show("Animal deleted successfully!");
            ClearAllFields();
        }
        private void ClearAllFields()
        {
            txtName.Clear();
            txtSpecies.Clear();
            dtpAge.Value = DateTime.Today; // Set to current date
            txtGender.Clear();
            txtWeight.Clear();
            txtColor.Clear();
            chkIsSick.Checked = false;
            txtLocation.Clear();

        }
    }
}
