using DataAccessLayer;
using Domain.Entity;
using Domain.Interfaces;

namespace Domain.Manager
{
    public class EmployeeManager
    {
        private EmployeeDatabase employeeDatabase;
        private IFormFactory _formFactory;

        public EmployeeManager(EmployeeDatabase dataAccess, IFormFactory formFactory)
        {
            employeeDatabase = dataAccess;
            _formFactory = formFactory;
        }

        public void AddEmployee(Employee employee)
        {
            employeeDatabase.AddEmployee(employee.FirstName, employee.LastName, employee.EmailAddress, employee.Password, employee.Salary, employee.HireDate, employee.JobTitle);
        }
        public List<Employee> GetAllEmployees()
        {
            List<IDictionary<string, object>> employeesData = employeeDatabase.GetAllEmployees();
            List<Employee> employees = new List<Employee>();

            foreach (var employeeData in employeesData)
            {
                Employee employee = new Employee(
                    Convert.ToInt32(employeeData["Id"]),
                    employeeData["FirstName"].ToString(),
                    employeeData["LastName"].ToString(),
                    employeeData["EmailAddress"].ToString(),
                    employeeData["Password"].ToString(),
                    Convert.ToDouble(employeeData["Salary"]),
                    Convert.ToDateTime(employeeData["HireDate"]),
                    employeeData["JobTitle"].ToString()
                );
                employees.Add(employee);
            }

            return employees;
        }
        public void DeleteEmployee(Employee employee)
        {
            employeeDatabase.DeleteEmployee(employee.Id);
        }

        public void UpdateEmployee(Employee employee)
        {
            employeeDatabase.UpdateEmployee(employee.Id, employee.FirstName, employee.LastName, employee.EmailAddress, employee.Password, employee.Salary, employee.HireDate, employee.JobTitle);
        }

        public bool ValidateLogin(string email, string password)
        {
            return employeeDatabase.ValidateLogin(email, password);
        }

        public void OpenForm(string email)
        {
            string jobTitle = GetJobTitle(email);

            if (jobTitle == null)
            {
                Console.WriteLine("Error: Job title is null for email " + email);
                return;
            }

            if (_formFactory == null)
            {
                Console.WriteLine("Error: _formFactory is null");
                return;
            }

            _formFactory.OpenForm(jobTitle);
        }

        public string GetJobTitle(string email)
        {
            return employeeDatabase.GetJobTitle(email);
        }

    }
}