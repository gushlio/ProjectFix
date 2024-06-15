using DataAccessLayer.DTOs;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace DataAccessLayer
{
    public class EmployeeDatabase
    {
        private DatabaseConnection dbManager = new DatabaseConnection();

        public void AddEmployee(string firstName, string lastName, string emailAddress, string password, double salary, DateTime hireDate, string jobTitle)
        {
            // generates salt
            byte[] saltBytes = new byte[16];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(saltBytes);
            }
            string salt = Convert.ToBase64String(saltBytes);

     
            string hashedPassword = HashPassword(password, salt);

            string query = "INSERT INTO Employees (FirstName, LastName, EmailAddress, Password, Salt, Salary, HireDate, JobTitle) VALUES (@FirstName, @LastName, @EmailAddress, @Password, @Salt, @Salary, @HireDate, @JobTitle)";
            using (SqlConnection connection = dbManager.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@EmailAddress", emailAddress);
                    command.Parameters.AddWithValue("@Password", hashedPassword);
                    command.Parameters.AddWithValue("@Salt", salt);
                    command.Parameters.AddWithValue("@Salary", salary);
                    command.Parameters.AddWithValue("@HireDate", hireDate);
                    command.Parameters.AddWithValue("@JobTitle", jobTitle);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private string HashPassword(string password, string salt)
        {
            using (var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, Encoding.UTF8.GetBytes(salt), 10000))
            {
                return Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(32)); // 256 bits
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

        public bool ValidateLogin(string email, string password)
        {
            string query = "SELECT Password, Salt FROM Employees WHERE EmailAddress = @EmailAddress";
            using (SqlConnection connection = dbManager.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EmailAddress", email);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedHash = reader["Password"].ToString();
                            string storedSalt = reader["Salt"].ToString();

                         
                            string hashedInputPassword = HashPassword(password, storedSalt);

                           
                            return storedHash == hashedInputPassword;
                        }
                    }
                }
            }
            return false;
        }

        public EmployeeDTO GetEmployeeById(int employeeId)
        {
            EmployeeDTO employeeDTO = null;

            using (SqlConnection connection = dbManager.GetConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Employees WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", employeeId);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    employeeDTO = new EmployeeDTO
                    {
                        Id = (int)reader["Id"],
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        EmailAddress = reader["EmailAddress"].ToString(),
                        Password = reader["Password"].ToString(),
                        Salary = Convert.ToDouble(reader["Salary"]),
                        HireDate = Convert.ToDateTime(reader["HireDate"]),
                        JobTitle = reader["JobTitle"].ToString()
                    };
                }
            }

            return employeeDTO;
        }

        public string GetJobTitle(string email)
        {
            string query = "SELECT JobTitle FROM Employees WHERE EmailAddress = @EmailAddress";
            using (SqlConnection connection = dbManager.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EmailAddress", email);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader["JobTitle"].ToString();
                        }
                    }
                }
            }
            return null;
        }

        public void UpdateEmployee(int employeeId, string firstName, string lastName, string emailAddress, string password, double salary, DateTime hireDate, string jobTitle)
        {
            string query = @"UPDATE Employees 
                     SET FirstName = @FirstName, 
                         LastName = @LastName, 
                         EmailAddress = @EmailAddress, 
                         Salary = @Salary, 
                         HireDate = @HireDate, 
                         JobTitle = @JobTitle
                     WHERE Id = @EmployeeId";

            if (!string.IsNullOrEmpty(password))
            {
                
                byte[] saltBytes = new byte[16];
                using (var rng = new RNGCryptoServiceProvider())
                {
                    rng.GetBytes(saltBytes);
                }
                string salt = Convert.ToBase64String(saltBytes);

            
                string hashedPassword = HashPassword(password, salt);

               
                query = @"UPDATE Employees 
                  SET FirstName = @FirstName, 
                      LastName = @LastName, 
                      EmailAddress = @EmailAddress, 
                      Password = @Password, 
                      Salt = @Salt, 
                      Salary = @Salary, 
                      HireDate = @HireDate, 
                      JobTitle = @JobTitle
                  WHERE Id = @EmployeeId";

                try
                {
                    using (SqlConnection connection = dbManager.GetConnection())
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@FirstName", firstName);
                            command.Parameters.AddWithValue("@LastName", lastName);
                            command.Parameters.AddWithValue("@EmailAddress", emailAddress);
                            command.Parameters.AddWithValue("@Password", hashedPassword);
                            command.Parameters.AddWithValue("@Salt", salt);
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
            else
            {
                try
                {
                    using (SqlConnection connection = dbManager.GetConnection())
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@FirstName", firstName);
                            command.Parameters.AddWithValue("@LastName", lastName);
                            command.Parameters.AddWithValue("@EmailAddress", emailAddress);
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
}

