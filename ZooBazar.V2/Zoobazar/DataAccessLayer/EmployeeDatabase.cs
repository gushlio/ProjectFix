using DataAccessLayer.DTOs;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using BCrypt.Net;

namespace DataAccessLayer
{
    public class EmployeeDatabase
    {
        private DatabaseConnection dbManager = new DatabaseConnection();
       
        public List<List<string>> EmployeeData { get; set; }
        public List<List<string>> ContractData { get; set; }
        public int lastId { get; set; }
        public EmployeeDatabase()
        {
            EmployeeData = new List<List<string>>();
            ContractData = new List<List<string>>();
            lastId = 1;
        }

        public void AddEmployee(string firstName, string lastName, string emailAddress, string password, string dateOfBirth, string contactInfo, string bsn, string address)
        {
            string salt = BCrypt.Net.BCrypt.GenerateSalt();
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password, salt);

            using (SqlConnection connection = dbManager.GetConnection())
            {
                connection.Open();

                string insertEmployeeQuery = @"
        INSERT INTO NewEmployee 
        (FirstName, LastName, EmailAddress, Password, Salt, DateOfBirth, ContactInfo, ContractId, Bsn, Address, FirstLogin)
        VALUES (@FirstName, @LastName, @EmailAddress, @Password, @Salt, @DateOfBirth, @ContactInfo, NULL, @Bsn, @Address, @FirstLogin);
        SELECT SCOPE_IDENTITY();";  // Retrieve the generated EmployeeId

                // Execute the INSERT statement for NewEmployee
                int newEmployeeId;
                using (SqlCommand command = new SqlCommand(insertEmployeeQuery, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@EmailAddress", emailAddress);
                    command.Parameters.AddWithValue("@Password", hashedPassword);
                    command.Parameters.AddWithValue("@Salt", salt);
                    command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                    command.Parameters.AddWithValue("@ContactInfo", contactInfo);
                    command.Parameters.AddWithValue("@Bsn", bsn);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@FirstLogin", false); // Assuming false for the first login

                    // Execute the query and retrieve the generated EmployeeId
                    newEmployeeId = Convert.ToInt32(command.ExecuteScalar());
                }

                connection.Close();
            }
        }

        private string HashPassword(string password, string salt)
        {
            using (var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, Encoding.UTF8.GetBytes(salt), 10000))
            {
                return Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(32)); // 256 bits
            }
        }

        public void AddContract(int employeeId, string ContractStart, string EndMessage , string ContractEnd, double Salary, string JobTitle)
        {
            using (SqlConnection connection = dbManager.GetConnection())
            {
                connection.Open();

                // Insert the contract and get the new ContractId
                string insertContractQuery = @"
        INSERT INTO Contracts (ContractStart, ContractEnd, EndMessage, Salary, JobTitle) 
        VALUES (@ContractStart, @ContractEnd, @EndMessage, @Salary, @JobTitle);
        SELECT SCOPE_IDENTITY();";

                int newContractId;
                using (SqlCommand command = new SqlCommand(insertContractQuery, connection))
                {
                    command.Parameters.AddWithValue("@ContractStart", ContractStart);
                    command.Parameters.AddWithValue("@EndMessage", EndMessage);
                    command.Parameters.AddWithValue("@ContractEnd", ContractEnd);
                    command.Parameters.AddWithValue("@Salary", Salary);
                    command.Parameters.AddWithValue("@JobTitle", JobTitle);

                    // Retrieve the new ContractId
                    newContractId = Convert.ToInt32(command.ExecuteScalar());
                }

                // Update the employee's ContractId
                string updateUserQuery = "UPDATE NewEmployee SET ContractId = @NewContractId WHERE EmployeeId = @EmployeeId";
                using (SqlCommand command = new SqlCommand(updateUserQuery, connection))
                {
                    command.Parameters.AddWithValue("@NewContractId", newContractId);
                    command.Parameters.AddWithValue("@EmployeeId", employeeId);

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        public void LoadEmployees()
        {
            EmployeeData.Clear();

            using (SqlConnection connection = dbManager.GetConnection())
            {
                connection.Open();

                // Query to join NewEmployee and Contracts tables
                string query = @"
                SELECT 
                    e.EmployeeId, e.FirstName, e.LastName, e.EmailAddress, e.Password, e.Salt, 
                    e.DateOfBirth, e.ContactInfo, e.ContractId, e.Address, e.Bsn, e.ContractHistory, e.FirstLogin,
                    c.ContractId, c.ContractStart, c.EndMessage, c.ContractEnd, c.Salary, c.JobTitle
                FROM 
                    NewEmployee e
                LEFT JOIN 
                    Contracts c ON e.ContractId = c.ContractId";

                SqlCommand command = new SqlCommand(query, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        List<string> employeeData = new List<string>();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            employeeData.Add(reader[i].ToString());
                        }
                        EmployeeData.Add(employeeData);
                    }
                }
            }
        }

        public void LoadContracts()
        {
            ContractData.Clear();

            using (SqlConnection connection = dbManager.GetConnection())
            {
                connection.Open();
                string selectQuery = "SELECT * FROM Contracts";

                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                List<string> contractData = new List<string>();

                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    if (reader.IsDBNull(i))
                                    {
                                        contractData.Add(null);
                                    }
                                    else
                                    {
                                        contractData.Add(reader[i].ToString());
                                    }
                                }

                                ContractData.Add(contractData);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No data found.");
                        }
                    }
                }
                connection.Close();
            }
        }

        public void TerminateContract(int employeeId, string endMessage)
        {
            using (SqlConnection connection = dbManager.GetConnection())
            {
                connection.Open();

                // Set the contract's end message and date
                string updateContractQuery = @"
            UPDATE Contracts
            SET EndMessage = @EndMessage, ContractEnd = @ContractEnd
            WHERE ContractId = (SELECT ContractId FROM NewEmployee WHERE EmployeeId = @EmployeeId)
        ";

                using (SqlCommand command = new SqlCommand(updateContractQuery, connection))
                {
                    command.Parameters.AddWithValue("@EndMessage", endMessage);
                    command.Parameters.AddWithValue("@ContractEnd", DateTime.Now);
                    command.Parameters.AddWithValue("@EmployeeId", employeeId);

                    command.ExecuteNonQuery();
                }

                // Set the employee's ContractId to null
                string updateEmployeeQuery = @"
            UPDATE NewEmployee
            SET ContractId = NULL
            WHERE EmployeeId = @EmployeeId
        ";

                using (SqlCommand command = new SqlCommand(updateEmployeeQuery, connection))
                {
                    command.Parameters.AddWithValue("@EmployeeId", employeeId);

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        public void DeleteEmployee(int employeeId)
        {
            string query = "DELETE FROM NewEmployee WHERE EmployeeId = @Id";

            try
            {
                using (SqlConnection connection = dbManager.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", employeeId);

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

        public void GetNewContract(int employeeId)
        {
            using (SqlConnection connection = dbManager.GetConnection())
            {
                connection.Open();

                // Insert the new contract and get the generated ContractId
                string insertContractQuery = @"
            INSERT INTO [Contracts] (ContractStart, ContractEnd, EndMessage, Salary, JobTitle) 
            VALUES (@ContractStart, @ContractEnd, @EndMessage, @Salary, @JobTitle);
            SELECT SCOPE_IDENTITY();";

                int newContractId;
                using (SqlCommand command = new SqlCommand(insertContractQuery, connection))
                {
                    // Provide placeholder values for required fields
                    command.Parameters.AddWithValue("@ContractStart", DBNull.Value);
                    command.Parameters.AddWithValue("@ContractEnd", DBNull.Value);
                    command.Parameters.AddWithValue("@EndMessage", DBNull.Value);
                    command.Parameters.AddWithValue("@Salary", 0);
                    command.Parameters.AddWithValue("@JobTitle", DBNull.Value);

                    newContractId = Convert.ToInt32(command.ExecuteScalar());
                }

                // Update the employee's ContractId with the newly generated ContractId
                string updateEmployeeQuery = "UPDATE [NewEmployee] SET ContractId=@ContractId WHERE EmployeeId=@EmployeeId";
                using (SqlCommand command = new SqlCommand(updateEmployeeQuery, connection))
                {
                    command.Parameters.AddWithValue("@EmployeeId", employeeId);
                    command.Parameters.AddWithValue("@ContractId", newContractId);

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        public void UpdateContract(int id, string ContractStart, string ContractEnd, string EndMessage, double Salary, string JobTitle)
        {
            using (SqlConnection connection = dbManager.GetConnection())
            {
                connection.Open();

                string updateUserQuery = "UPDATE [Contracts] SET JobTitle=@JobTitle, ContractStart=@ContractStart, ContractEnd=@ContractEnd, EndMessage=@EndMessage, Salary=@Salary WHERE ContractId = @Id";
                using (SqlCommand command = new SqlCommand(updateUserQuery, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@ContractStart", ContractStart);
                    command.Parameters.AddWithValue("@ContractEnd", ContractEnd);
                    command.Parameters.AddWithValue("@EndMessage", EndMessage);
                    command.Parameters.AddWithValue("@Salary", Salary);
                    command.Parameters.AddWithValue("@JobTitle", JobTitle);

                    command.ExecuteNonQuery();

                }

                connection.Close();
            }
        }
        public void UpdateEmployeeData(int id, string firstName, string lastName, string emailAddress, string dateOfBirth, string contactInfo, string bsn, string address)
        {
            using (SqlConnection connection = dbManager.GetConnection())
            {
                connection.Open();

                string updateEmployeeQuery = "UPDATE [NewEmployee] SET FirstName=@FirstName, LastName=@LastName, EmailAddress=@Email, DateOfBirth = @DateOfBirth, Bsn = @Bsn, ContactInfo = @ContactInfo, Address = @Address WHERE EmployeeId = @Id";
                using (SqlCommand command = new SqlCommand(updateEmployeeQuery, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@Email", emailAddress);
                    command.Parameters.AddWithValue("@ContactInfo", contactInfo);
                    command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                    command.Parameters.AddWithValue("@BSN", bsn);
                    command.Parameters.AddWithValue("@Address", address);

                    command.ExecuteNonQuery();

                }
                connection.Close();
            }
        }

        public void UpdateEmployeePassword(int id, string password, string salt)
        {
            using (SqlConnection connection = dbManager.GetConnection())
            {
                connection.Open();

                string updatePasswordQuery = "UPDATE [NewEmploye] SET Password=@Password, Salt=@Salt WHERE EmployeeId = @Id";

                using (SqlCommand command = new SqlCommand(updatePasswordQuery, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Salt", salt);
                    command.ExecuteNonQuery();

                }

                connection.Close();
            }
        }

        public string GetContractHistory(int employeeId)
        {
            using (SqlConnection connection = dbManager.GetConnection())
            {
                connection.Open();
                string selectQuery = "SELECT ContractHistory FROM [NewEmployee] WHERE EmployeeId = @Id";
                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@Id", employeeId);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {

                            while (reader.Read())
                            {

                                return reader[0].ToString();

                            }
                        }
                        else
                        {
                            Console.WriteLine("No data found for the specified ID.");
                            return null;
                        }
                    }
                }
                connection.Close();
            }
            return null;
        }

        public void EmployeeFirstLoginData(int id, string password, string salt)
        {
            using (SqlConnection connection = dbManager.GetConnection())
            {
                connection.Open();

                string updateEmployeeFirstLoginQuery = "UPDATE [NewEmployee] SET FirstLogin=@FirstLogin, Password=@Password, Salt=@Salt WHERE EmployeeId = @Id";
                using (SqlCommand command = new SqlCommand(updateEmployeeFirstLoginQuery, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@FirstLogin", "1");
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Salt", salt);

                    command.ExecuteNonQuery();

                }

                connection.Close();
            }
        }
        public void UpdateContractHistory(int employeeId, string contractHistory)
        {
            using (SqlConnection connection = dbManager.GetConnection())
            {
                connection.Open();
                string selectQuery = "UPDATE [NewEmployee] SET ContractHistory=@ContractHistory WHERE EmployeeId=@Id";
                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@Id", employeeId);
                    command.Parameters.AddWithValue("@ContractHistory", contractHistory);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }


        /*public bool ValidateLogin(string email, string password)
        {
            string query = "SELECT Password, Salt FROM NewEmployees WHERE EmailAddress = @EmailAddress";
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

                SqlCommand command = new SqlCommand("SELECT * FROM NewEmployees WHERE Id = @Id", connection);
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

        public EmployeeDTO GetEmployeeByEmail(string email)
        {
            EmployeeDTO employeeDTO = null;

            using (SqlConnection connection = dbManager.GetConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Employees WHERE EmailAddress = @Email", connection);
                command.Parameters.AddWithValue("@Email", email);

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
            string query = @"UPDATE NewEmployees 
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

               
                query = @"UPDATE NewEmployees 
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
        }*/
    }
}

