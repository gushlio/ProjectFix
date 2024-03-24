using DesktopApp;
using Domain.Entity;
using Domain.Manager;

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
    }
}
