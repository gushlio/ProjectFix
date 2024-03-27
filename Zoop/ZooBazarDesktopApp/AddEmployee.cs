using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Domain.Entity;
using Domain.Manager;


namespace DesktopApp
{
    public partial class AddEmployee : Form
    {
  
 
        public AddEmployee()
        {
            InitializeComponent();

            foreach (var title in Enum.GetValues(typeof(JobTitles)))
            {
                cmbJobTitle.Items.Add(title);
            }
        }

       
        private void label1_Click(object sender, EventArgs e)
        {

        }
      

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {

            if (IsValidInput())
            {
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                string emailAddress = txtEmail.Text;
                string password = txtPassword.Text;
                double salary;
                if (!double.TryParse(txtSalary.Text, out salary))
                {
                    MessageBox.Show("Invalid salary. Please enter a valid number.");
                    return;
                }
                DateTime hireDate = dateTimePicker1.Value;
                string jobTitle = cmbJobTitle.SelectedItem.ToString();

          
                Employee newEmployee = new Employee(0, firstName, lastName, emailAddress, password, salary, hireDate, jobTitle);

                EmployeeManager employeeManager = new EmployeeManager();
                employeeManager.AddEmployee(newEmployee);
                MessageBox.Show("Employee added successfully.");
                ClearForm();
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
        private bool IsValidInput()
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtSalary.Text) ||
                cmbJobTitle.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields");
                return false;
            }

            return true;
        }

    }
}
