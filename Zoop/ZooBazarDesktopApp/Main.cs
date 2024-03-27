using DesktopApp;
using Domain.Entity;
using Domain.Manager;
using Drawing = System.Drawing;


namespace ZooBazarDesktopApp
{
    public partial class Main : Form
    {
        private EmployeeManager employeeManager = new EmployeeManager();
        private AnimalManager animalManager;
        private ImageManager imageManager;

        public Main()
        {
            InitializeComponent();
            animalManager = new AnimalManager();
            imageManager = new ImageManager();
            dgvImages.Columns.Add("ImageDataColumn", "Image");
            LoadAnimals();
            LoadImages();



            foreach (var title in Enum.GetValues(typeof(JobTitles)))
            {
                cmbJobTitle.Items.Add(title);
            }
            RefreshEmployeeListData();

        }

        private void LoadImages()
        {
            try
            {
                // Get all images from the database
                List<byte[]> images = imageManager.GetAllImages();

                // Clear existing rows in the DataGridView
                dgvImages.Rows.Clear();

                // Add each image to the DataGridView
                foreach (byte[] imageData in images)
                {
                    // Convert byte array to Image
                    Drawing.Image image = Drawing.Image.FromStream(new System.IO.MemoryStream(imageData));

                    // Add the Image to the DataGridView
                    dgvImages.Rows.Add(new object[] { image });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while retrieving images: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadAnimals()
        {
            List<Animal> animals = animalManager.GetAllAnimals();
            dataGridViewAnimals.DataSource = animals;
        }
        //employees
        private void btnAddEmployees_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployeeForm = new AddEmployee();
            addEmployeeForm.ShowDialog();
            RefreshEmployeeListData();
        }
        private void RefreshEmployeeListData()
        {

            List<Employee> employees = employeeManager.GetAllEmployees();
            if (employees != null)
            {

                dataGridViewStaff.DataSource = employees;
            }
            else
            {

                MessageBox.Show("No employees found");
            }
        }
        private void ClearForm()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtSalary.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            cmbJobTitle.SelectedIndex = -1;
        }
        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (dataGridViewStaff.SelectedRows.Count > 0)
            {

                Employee selectedEmployee = (Employee)dataGridViewStaff.SelectedRows[0].DataBoundItem;

                employeeManager.DeleteEmployee(selectedEmployee);

                RefreshEmployeeListData();

                MessageBox.Show("Employee deleted succesfully!");
            }
            else
            {
                MessageBox.Show("Please select an employee to delete.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int employeeId = Convert.ToInt32(numericUpDownUpdateEmployee.Value);

            if (employeeId <= 0)
            {
                MessageBox.Show("Please enter a valid employee ID.");
                return;
            }

            string newFirstName = txtFirstName.Text;
            string newLastName = txtLastName.Text;
            string newEmail = txtEmail.Text;
            string newPassword = txtPassword.Text;
            double newSalary;
            if (!double.TryParse(txtSalary.Text, out newSalary))
            {
                MessageBox.Show("Invalid salary. Please enter a valid number.");
                return;
            }
            DateTime newHireDate = dateTimePicker1.Value;
            string newJobTitle = cmbJobTitle.SelectedItem.ToString();


            Employee updatedEmployee = new Employee(employeeId, newFirstName, newLastName, newEmail, newPassword, newSalary, newHireDate, newJobTitle);


            employeeManager.UpdateEmployee(updatedEmployee);


            RefreshEmployeeListData();

            MessageBox.Show("Employee updated successfully!");
            ClearForm();
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
            ClearForm();
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
            ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int animalID = int.Parse(txtAnimalID.Text);

            // Create a temporary animal object with only AnimalID set
            Animal animal = new Animal(animalID, "", "", 0, "", 0, "", false, "", DateTime.Now);

            // Call DeleteAnimal method of AnimalManager to delete the animal
            animalManager.DeleteAnimal(animal);
            MessageBox.Show("Animal deleted successfully!");
            ClearForm();
        }

        private void dataGridViewAnimals_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabTicketManagement_Click(object sender, EventArgs e)
        {

        }

        private void CurrentPrices_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            string selectedItem = checkedCategoryTicket.SelectedItem?.ToString();

            if (selectedItem != null)
            {

                string value = textBox1.Text;


                for (int i = 0; i < checkedCategoryTicket.Items.Count; i++)
                {
                    if (checkedCategoryTicket.GetItemChecked(i))
                    {

                        string checkedItem = checkedCategoryTicket.Items[i].ToString();


                        string info = $"{checkedItem}: {value}";
                        CurrentPrices.Items.Add(info);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an item from the list.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            CurrentPrices.Items.Clear();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem?.ToString();

            if (selectedItem != null)
            {
                // Get the price from the TextBox
                string price = textBox1.Text;

                // Check if the selected quantity is greater than 0
                if (comboBox1.SelectedIndex >= 0)
                {
                    int selectedQuantity = comboBox1.SelectedIndex + 1; // +1 because ComboBox is zero-indexed

                    // Clear both list boxes
                    CurrentPrices.Items.Clear();
                    RemainingTickets.Items.Clear();

                    // Display items in CurrentPrices ListBox
                    for (int i = 0; i < selectedQuantity; i++)
                    {
                        // Display the selected item along with its associated price in the CurrentPrices ListBox
                        string info = $"{selectedItem}: {price}";
                        CurrentPrices.Items.Add(info);
                    }

                    // Display remaining items in RemainingItems ListBox
                    int remainingQuantity = comboBox1.Items.Count - selectedQuantity;
                    for (int i = 0; i < remainingQuantity; i++)
                    {
                        // Display the remaining items in the RemainingItems ListBox
                        RemainingTickets.Items.Add(comboBox1.Items[selectedQuantity + i]);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a quantity from the list.");
                }
            }
            else
            {
                MessageBox.Show("Please select an item from the list.");
            }
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            // Open a file dialog to select an image file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Read the selected image file and convert it to a byte array
                    byte[] imageData = System.IO.File.ReadAllBytes(openFileDialog.FileName);
                    // Add the image to the database
                    imageManager.AddImage(imageData);
                    // Refresh the DataGridView displaying the images
                    RefreshImageDataGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred while adding image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDeleteImage_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dgvImages.SelectedRows.Count > 0)
            {
                // Get the ImageID of the selected row
                int imageID = (int)dgvImages.SelectedRows[0].Cells["ImageID"].Value;
                try
                {
                    // Delete the image from the database
                    imageManager.DeleteImage(imageID);
                    // Refresh the DataGridView displaying the images
                    RefreshImageDataGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred while deleting image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select an image to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // Method to refresh the DataGridView displaying the images
        private void RefreshImageDataGrid()
        {
            try
            {
                // Reload images
                LoadImages();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while refreshing images: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblImageId_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxImage_Click(object sender, EventArgs e)
        {

        }

        private void dgvImages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
