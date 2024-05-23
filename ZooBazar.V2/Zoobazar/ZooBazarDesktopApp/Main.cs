using DesktopApp;
using Domain.Entity;
using Domain.Manager;
using Drawing = System.Drawing;


namespace ZooBazarDesktopApp
{
    public partial class Main : Form
    {
        private EmployeeManager employeeManager = new EmployeeManager();
        

        public Main()
        {
            InitializeComponent();
            
            foreach (var title in Enum.GetValues(typeof(JobTitles)))
            {
                cmbJobTitle.Items.Add(title);
            }
            RefreshEmployeeListData();

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

        

       
       
    }
}
