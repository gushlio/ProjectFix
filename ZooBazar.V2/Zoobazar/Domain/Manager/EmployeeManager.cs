using DataAccessLayer;
using DataAccessLayer.DTOs;
using Domain.Entity;
using Domain.Interfaces;
using Domain.MapperClasses;

namespace Domain.Manager
{
    public class EmployeeManager
    {
        private EmployeeDatabase employeeDatabase;
        
        private IFormFactory _formFactory;

        public EmployeeManager()
        {
            employeeDatabase = new EmployeeDatabase();
        }

        public void AddEmployee(Employee employee)
        {
            employeeDatabase.AddEmployee(employee.FirstName, employee.LastName, employee.EmailAddress, employee.Password, employee.Birthday, employee.ContactInfo);
        }
        /*public List<Employee> GetAllEmployees()
        {
            List<IDictionary<string, object>> employeesData = employeeDatabase.GetAllEmployees();
            List<Employee> employees = new List<Employee>();

            foreach (var employeeData in employeesData)
            {
                Employee employee = new LoadEmployees
                    
                    Employee(
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
        }*/

        public List<Employee> LoadEmployees()
        {
            List<EmployeeDTO> employeeDTOs = employeeDatabase.LoadEmployees();
            List<Employee> employees = new List<Employee>();

            foreach (var employeeDTO in employeeDTOs)
            {
                Employee employee = EmployeeMapper.MapToEntity(employeeDTO);
                employees.Add(employee);
            }

            return employees;
        }

        public Employee GetEmployeeById(int employeeId)
        {
            var employeeDTO = employeeDatabase.GetEmployeeById(employeeId);
            return EmployeeMapper.MapToEntity(employeeDTO);
        }

        public Employee GetEmployeeByEmail(string email)
        {
            var employeeDTO = employeeDatabase.GetEmployeeByEmail(email);
            return EmployeeMapper.MapToEntity(employeeDTO);
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