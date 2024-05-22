
using Domain.Service;
using System.Data;
using System.Windows.Forms;

namespace ZooBazarDesktopApp
{
    public partial class Animal : Form
    {
        private AnimalService _animalService;
        private String selectedAnimalName;
        private String selectedLocationName;


        public Animal()
        {
            InitializeComponent();
            _animalService = new AnimalService();

            gbNotifficationView.Visible = false;

            PopulateLocationComboBox();
            PopulateSpeciesComboBox();
            PopulateNotificationViewComboBox();
            PopulateAnimalsDataGridView();
            PopulateAnimalCareDataGridView();
            PopulateDeportedAnimalsDataGridView();
        }

        private void PopulateAnimalCareDataGridView()
        {
            // Retrieve all animal care records from the database
            DataTable allAnimalCareRecords = _animalService.GetAllAnimalCareRecords();

            // Filter out animals for which a remedy has already been added
            DataTable filteredAnimalCareRecords = FilterOutAnimalsWithRemedy(allAnimalCareRecords);

            // Set the DataSource property of dgvAnimalCare
            dgvAnimalCare.DataSource = filteredAnimalCareRecords;
        }

        private DataTable FilterOutAnimalsWithRemedy(DataTable allAnimalCareRecords)
        {
            // Create a new DataTable to hold filtered records
            DataTable filteredRecords = allAnimalCareRecords.Clone();

            // Iterate through each row in the allAnimalCareRecords DataTable
            foreach (DataRow row in allAnimalCareRecords.Rows)
            {
                // Check if the animal does not have a remedy (VetAction)
                if (string.IsNullOrEmpty(row["VetAction"].ToString()))
                {
                    // If the animal does not have a remedy, add its row to the filteredRecords DataTable
                    filteredRecords.ImportRow(row);
                }
            }

            return filteredRecords;
        }

        private void PopulateNotificationViewComboBox()
        {
            // Add table names to cbNotificationView
            cbNotifficationView.Items.Add("AnimalClinic");
            cbNotifficationView.Items.Add("AnimalUpdates");
        }
        // Method to populate the ComboBox with locations
        private void PopulateLocationComboBox()
        {
            // Retrieve all locations from the domain layer
            List<string> locations = _animalService.GetAllLocations();

            // Clear the ComboBox before adding items
            cbAnimalLocation.Items.Clear();

            // Add locations to the ComboBox
            cbAnimalLocation.Items.AddRange(locations.ToArray());
        }

        // Method to populate the DataGridView with animals excluding deported ones
        private void PopulateAnimalsDataGridView()
        {
            try
            {
                // Retrieve all animals excluding deported ones from the domain layer
                DataTable animalsDataTable = _animalService.GetAllAnimalsExcludingDeported();

                // Set the DataSource of the DataGridViews to the DataTable
                dgvAnimal.DataSource = animalsDataTable;
                dgvAnimals.DataSource = animalsDataTable;
                dgvAnimalView.DataSource = animalsDataTable;
                dgvAnimalDeployHistory.DataSource = animalsDataTable;

                // Refresh DataGridViews to reflect changes
                dgvAnimal.Refresh();
                dgvAnimals.Refresh();
                dgvAnimalView.Refresh();
                dgvAnimalDeployHistory.Refresh();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine("Error populating DataGridView: " + ex.Message);
            }
        }

        // Method to populate the dgvAnimalDeportHistory DataGridView with deported animals
        private void PopulateDeportedAnimalsDataGridView()
        {
            try
            {
                // Retrieve all deported animals from the domain layer
                DataTable deportedAnimalsDataTable = _animalService.GetAllDeportedAnimals();

                // Set the DataSource of the DataGridView to the DataTable
                dgvAnimalDeportHistory.DataSource = deportedAnimalsDataTable;

                // Refresh the DataGridView to reflect changes
                dgvAnimalDeportHistory.Refresh();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine("Error populating deported animals DataGridView: " + ex.Message);
            }
        }


        // Method to populate the ComboBox with species
        private void PopulateSpeciesComboBox()
        {
            // Clear the ComboBox before adding items
            cbSpeciesNew.Items.Clear();

            // Retrieve all species from the domain layer
            List<string> speciesList = GetAllSpeciesFromDomain();

            // Add species to the ComboBox
            cbSpeciesNew.Items.AddRange(speciesList.ToArray());
        }
        // Method to retrieve all species from the domain layer
        private List<string> GetAllSpeciesFromDomain()
        {
            // Retrieve all species from the domain layer using AnimalService
            // You can call the corresponding method in AnimalService to get species
            return _animalService.GetAllSpecies();
        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            string location = txtZooLocations.Text;

            // Call the AddLocation method of AnimalService to add the location
            _animalService.AddLocation(location);

            // Clear the input control
            txtZooLocations.Text = "";

            // Update the ComboBox with the new location
            PopulateLocationComboBox();
        }
        private void btnAddAnimalNew_Click(object sender, EventArgs e)
        {
            // Get the values from the input controls
            string name = txtNameNew.Text;
            string species = cbSpeciesNew.SelectedItem.ToString(); // Assuming species is selected from ComboBox
            string color = txtColorNew.Text;
            decimal weight = numWeightNew.Value; // Assuming weight is a numeric up-down control
            DateTime dateOfBirth = dtpAgeNew.Value; // Assuming date of birth is a date time picker control

            // Call the AddAnimal method of AnimalService to add the animal
            _animalService.AddAnimal(name, species, color, weight, dateOfBirth);

            // Clear the input controls
            txtNameNew.Text = "";
            cbSpeciesNew.SelectedIndex = -1; // Clear selection
            txtColorNew.Text = "";
            numWeightNew.Value = 0; // Set numeric up-down control to default value
            dtpAgeNew.Value = DateTime.Now; // Set date time picker control to current date

            // Refresh the DataGridView to reflect the changes
            PopulateAnimalsDataGridView(); // Assuming PopulateAnimalsDataGridView method updates the DataGridView with new data
        }

        private void btnDeploy_Click(object sender, EventArgs e)
        {
            // Check if a location is selected in the ComboBox
            if (cbAnimalLocation.SelectedItem != null)
            {
                // Get the selected location from the ComboBox
                string selectedLocation = cbAnimalLocation.SelectedItem.ToString();

                // Check if the animal name label has a value
                if (!string.IsNullOrEmpty(selectedAnimalName))
                {
                    // Call the Deploy method of AnimalService to update the location of the selected animal
                    _animalService.Deploy(selectedAnimalName, selectedLocation);

                    // Optional: Refresh DataGridView to reflect changes
                    PopulateAnimalsDataGridView();

                    // Clear selected animal name
                    selectedAnimalName = "";
                    lblAnimalNameDeploy.Text = "";

                    // Clear selected location in ComboBox
                    cbAnimalLocation.SelectedIndex = -1;

                    // Optionally, clear other related controls if needed
                }
                else
                {
                    MessageBox.Show("Please select an animal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a location.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddSpecies_Click(object sender, EventArgs e)
        {
            string species = txtSpecies.Text;
            // Call the AddSpecies method 
            _animalService.AddSpecies(species);

            // Clear the txtSpecies TextBox
            txtSpecies.Text = "";

            // Repopulate the ComboBox with updated list of species
            PopulateSpeciesComboBox();
        }

        

        private void dgvAnimalView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in a valid row
            if (e.RowIndex >= 0)
            {
                // Get the animal name from the selected row
                selectedAnimalName = dgvAnimals.Rows[e.RowIndex].Cells["AnimalName"].Value.ToString();
                selectedLocationName = dgvAnimals.Rows[e.RowIndex].Cells["LocationName"].Value.ToString();

                // Update the label to show the selected animal name
                lblAnimalNameView.Text = selectedAnimalName;
                lblAnimalLocationView.Text = selectedLocationName;
            }
        }

        private void btnUpdateAnimalCare_Click(object sender, EventArgs e)
        {
            // Retrieve text from txtRemedyCare
            string remedy = txtRemedyCare.Text;

            // Retrieve name from lblAnimalNameCare
            string animalName = lblAnimalNameCare.Text;

            // Create an instance of AnimalService
            AnimalService animalService = new AnimalService();

            // Call the UpdateVetActionInAnimalClinicTable method
            animalService.UpdateVetActionInAnimalClinicTable(animalName, remedy);

            // Clear inputs
            lblAnimalNameCare.Text = "";
            lblAnimalLocationCare.Text = "";
            txtRemedyCare.Text = "";
            txtNotifficationCare.Text = "";

            // Refresh the dgvAnimalCare DataGridView with the updated data
            PopulateAnimalCareDataGridView();
        }

        private void btnUpdateAnimalView_Click(object sender, EventArgs e)
        {
            // Retrieve text from txtNotificationView
            string notificationText = txtNotifficationView.Text;

            // Retrieve name from lblAnimalNameView
            string animalName = lblAnimalNameView.Text;

            // Retrieve selected table name from cbNotificationView
            string selectedTable = cbNotifficationView.SelectedItem?.ToString();

            // Check if selected table is not null
            if (selectedTable != null)
            {
                // Get the location of the selected animal from the DataGridView
                string animalLocation = selectedLocationName; // Assuming selectedLocationName is the location of the selected animal

                // Create an instance of AnimalService
                AnimalService animalService = new AnimalService();

                // Insert data into the selected table using AnimalService methods
                if (selectedTable == "AnimalClinic")
                {
                    // Insert data into the AnimalClinic table with location
                    animalService.InsertIntoAnimalClinicTable(animalName, notificationText, animalLocation);
                }
                else if (selectedTable == "AnimalUpdates")
                {
                    // Insert data into the AnimalUpdates table
                    animalService.InsertIntoAnimalUpdatesTable(animalName, notificationText);
                }

                // Clear inputs
                txtNotifficationView.Text = "";
                lblAnimalNameView.Text = "";
                lblAnimalLocationView.Text = "";

                // Refresh dgvAnimalCare
                PopulateAnimalCareDataGridView();
            }
            else
            {
                MessageBox.Show("Please select a table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radbtnNotifficationView_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtnNotifficationView.Checked)
            {
                gbNotifficationView.Visible = true; // Show gbNotifficationView when radbtnNotificationView is checked
            }
            else
            {
                gbNotifficationView.Visible = false; // Hide gbNotifficationView when radbtnNotificationView is unchecked
            }
        }

        private void dgvAnimalCare_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a valid row is clicked
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the data from the clicked row
                DataGridViewRow selectedRow = dgvAnimalCare.Rows[e.RowIndex];
                string animalName = selectedRow.Cells["AnimalName"].Value.ToString();
                string locationName = selectedRow.Cells["Location"].Value.ToString();
                string clinicUpdate = selectedRow.Cells["ClinicUpdate"].Value.ToString();

                // Update labels and text box
                lblAnimalNameCare.Text = animalName;
                lblAnimalLocationCare.Text = locationName;
                txtNotifficationCare.Text = clinicUpdate;
            }
        }

        private void btnDeport_Click(object sender, EventArgs e)
        {
            if (dgvAnimals.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvAnimals.SelectedRows[0];

                string animalName = selectedRow.Cells["AnimalName"].Value.ToString();
                string species = selectedRow.Cells["SpeciesName"].Value.ToString();
                string color = selectedRow.Cells["Color"].Value.ToString();
                decimal weight = Convert.ToDecimal(selectedRow.Cells["Weight"].Value);
                DateTime dateOfBirth = Convert.ToDateTime(selectedRow.Cells["DateOfBirth"].Value);
                string location = selectedRow.Cells["LocationName"].Value.ToString();

                // Get the current date and time for DateOfRegister
                DateTime dateOfRegister = DateTime.Now;

                // Insert information into DeportedAnimals table
                _animalService.InsertIntoDeportedAnimalsTable(animalName, species, color, weight, dateOfBirth, location, dateOfRegister);

                // Remove the selected animal from the Animals table
                _animalService.RemoveAnimal(animalName);

                // Refresh dgvAnimals
                PopulateAnimalsDataGridView();

                //Refresh 
                PopulateDeportedAnimalsDataGridView();
            }
            else
            {
                MessageBox.Show("Please select an animal from the list.", "No Animal Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvAnimalDeployHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a valid row and column is clicked
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the data from the clicked row
                DataGridViewRow selectedRow = dgvAnimalDeployHistory.Rows[e.RowIndex];

                // Extract information from the selected row
                string animalName = selectedRow.Cells["AnimalName"].Value.ToString();
                DateTime dateOfRegister = Convert.ToDateTime(selectedRow.Cells["DateOfRegister"].Value);
                DateTime dateOfBirth = Convert.ToDateTime(selectedRow.Cells["DateOfBirth"].Value);
                string location = selectedRow.Cells["LocationName"].Value.ToString();

                // Calculate the age of the animal
                TimeSpan age = DateTime.Now - dateOfBirth;
                int ageInYears = (int)(age.Days / 365.25);

                // Update labels with the selected animal information
                lblAnimalNameDeployHistory.Text = animalName;
                lblAnimalDateDeployHistory.Text = dateOfRegister.ToString("dd/MM/yyyy");
                lblAnimalAgeDeployHistory.Text = ageInYears.ToString();
                lblAnimalLocationDeployHistory.Text = location;
            }
        }

        private void dgvAnimalDeportHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a valid row and column is clicked
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the data from the clicked row
                DataGridViewRow selectedRow = dgvAnimalDeportHistory.Rows[e.RowIndex];

                // Extract information from the selected row
                string animalName = selectedRow.Cells["AnimalName"].Value.ToString();
                DateTime dateOfDeportation = Convert.ToDateTime(selectedRow.Cells["DateOfDeportation"].Value);
                DateTime dateOfBirth = Convert.ToDateTime(selectedRow.Cells["DateOfBirth"].Value);
                string location = selectedRow.Cells["Location"].Value.ToString();

                // Calculate the age of the animal
                TimeSpan age = DateTime.Now - dateOfBirth;
                int ageInYears = (int)(age.Days / 365.25);

                // Update labels with the selected animal information
                lblAnimalNameDeportHistory.Text = animalName;
                lblAnimalDateDeportHistory.Text = dateOfDeportation.ToString("dd/MM/yyyy");
                lblAnimalAgeDeportHistory.Text = ageInYears.ToString();
                lblAnimalLocationDeportHistory.Text = location;
            }
        }
        private Dictionary<string, ProgressBar> animalProgressBars = new Dictionary<string, ProgressBar>();

        private void LoadAnimalStatus()
        {
            // Retrieve all animals from the database
            DataTable animalsDataTable = _animalService.GetAllAnimals();

            // Clear existing group boxes and progress bars
            groupBoxesPanel.Controls.Clear();
            animalProgressBars.Clear();

            // Define initial position for the first group box
            int startX = 10;
            int startY = 10;

            // Define width and height for each group box
            int groupBoxWidth = 150;
            int groupBoxHeight = 120; // Adjusted height without date of birth label

            // Iterate through each animal and create a group box
            foreach (DataRow row in animalsDataTable.Rows)
            {
                // Get animal details
                string animalName = row["AnimalName"].ToString();
                string speciesName = row["SpeciesName"].ToString();
                string color = row["Color"].ToString();
                decimal weight = (decimal)row["Weight"];

                // Create a new group box
                GroupBox groupBox = new GroupBox();
                groupBox.Text = animalName; // Set the group box title to the animal name
                groupBox.Size = new Size(groupBoxWidth, groupBoxHeight); // Set size

                // Create labels to display animal details
                Label speciesLabel = new Label();
                speciesLabel.Text = "Species: " + speciesName;
                speciesLabel.Location = new System.Drawing.Point(10, 20); // Adjust location as needed
                groupBox.Controls.Add(speciesLabel);

                Label colorLabel = new Label();
                colorLabel.Text = "Color: " + color;
                colorLabel.Location = new System.Drawing.Point(10, 40); // Adjust location as needed
                groupBox.Controls.Add(colorLabel);

                Label weightLabel = new Label();
                weightLabel.Text = "Weight: " + weight.ToString();
                weightLabel.Location = new System.Drawing.Point(10, 60); // Adjust location as needed
                groupBox.Controls.Add(weightLabel);

                // Create and add progress bar for animal health
                ProgressBar healthProgressBar = new ProgressBar();
                healthProgressBar.Minimum = 0;
                healthProgressBar.Maximum = 100; // Assuming health is represented as a percentage
                healthProgressBar.Value = 100; // Initial health value
                healthProgressBar.Size = new Size(groupBoxWidth - 20, 20); // Adjust size
                healthProgressBar.Location = new System.Drawing.Point(10, 90); // Adjust location
                groupBox.Controls.Add(healthProgressBar);
                // Add progress bar to dictionary for updating
                animalProgressBars.Add(animalName, healthProgressBar);

                // Set the position of the group box
                groupBox.Location = new Point(startX, startY);

                // Increment startX for the next group box position
                startX += groupBoxWidth + 10; // Add some spacing between group boxes

                // Add the group box to the panel
                groupBoxesPanel.Controls.Add(groupBox);
            }

            // Start a timer to update the progress bars periodically
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 5000; // 5000 milliseconds = 5 seconds (adjust as needed)
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Iterate through each animal's progress bar and decrement its value
            foreach (var progressBarEntry in animalProgressBars)
            {
                ProgressBar progressBar = progressBarEntry.Value;
                if (progressBar.Value > progressBar.Minimum)
                {
                    progressBar.Value -= 10; // Decrease health by 10% (adjust as needed)
                }
            }
        }

        private void TabAnimalStatus_Click(object sender, EventArgs e)
        {

        }

        private void TabAnimalStatus_Enter_1(object sender, EventArgs e)
        {
            // Call the method to load animal statuses when the tab is entered or activated
            LoadAnimalStatus();
        }

        private void dgvAnimals_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in a valid row
            if (e.RowIndex >= 0)
            {
                // Get the animal name from the selected row
                selectedAnimalName = dgvAnimals.Rows[e.RowIndex].Cells["AnimalName"].Value.ToString();

                // Update the label to show the selected animal name
                lblAnimalNameDeploy.Text = selectedAnimalName;
            }
        }
    }
}
