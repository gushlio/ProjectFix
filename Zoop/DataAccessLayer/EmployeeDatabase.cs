using Microsoft.Data.SqlClient;

namespace DataAccessLayer
{
    public class EmployeeDatabase
    {
        private DatabaseConnection dbManager = new DatabaseConnection();

        public void AddEmployee(string firstName, string lastName, string emailAddress, string password, double salary, DateTime hireDate, string jobTitle)
        {
            string query = "INSERT INTO Employees (FirstName, LastName, EmailAddress, Password, Salary, HireDate, JobTitle) VALUES (@FirstName, @LastName, @EmailAddress, @Password, @Salary, @HireDate, @JobTitle)";
            using (SqlConnection connection = dbManager.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@EmailAddress", emailAddress);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Salary", salary);
                    command.Parameters.AddWithValue("@HireDate", hireDate);
                    command.Parameters.AddWithValue("@JobTitle", jobTitle);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        public List<IDictionary<string, object>> GetAllEmployees()
        {
            List<IDictionary<string, object>> employees = new List<IDictionary<string, object>>();
            string query = "SELECT * FROM Employees";

            try
            {
                using (SqlConnection connection = dbManager.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var employee = new Dictionary<string, object>();
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    employee[reader.GetName(i)] = reader.GetValue(i);
                                }
                                employees.Add(employee);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                
                Console.WriteLine("Error occurred while retrieving employees: " + ex.Message);
            }

            return employees;
        }
        public void DeleteEmployee(int employeeId)
        {
            string query = "DELETE FROM Employees WHERE Id = @EmployeeId";

            try
            {
                using (SqlConnection connection = dbManager.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeId", employeeId);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while deleting employee: " + ex.Message);
                
                throw;
            }
        }
        public void UpdateEmployee(int employeeId, string firstName, string lastName, string emailAddress, string password, double salary, DateTime hireDate, string jobTitle)
        {
            string query = "UPDATE Employees SET FirstName = @FirstName, LastName = @LastName, EmailAddress = @EmailAddress, Password = @Password, Salary = @Salary, HireDate = @HireDate, JobTitle = @JobTitle WHERE Id = @EmployeeId";

            try
            {
                using (SqlConnection connection = dbManager.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@EmailAddress", emailAddress);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Salary", salary);
                        command.Parameters.AddWithValue("@HireDate", hireDate);
                        command.Parameters.AddWithValue("@JobTitle", jobTitle);
                        command.Parameters.AddWithValue("@EmployeeId", employeeId);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while updating employee: " + ex.Message);
                throw;
            }
        }
    }
}

