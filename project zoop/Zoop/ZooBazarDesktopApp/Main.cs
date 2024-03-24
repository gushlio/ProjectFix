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

        }
    }
}
