using DataAccessLayer.DTOs;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Security.Cryptography;
using System.Text;

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
            // generates salt
            byte[] saltBytes = new byte[16];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(saltBytes);
            }
            string salt = Convert.ToBase64String(saltBytes);
            string hashedPassword = HashPassword(password, salt);

            int rowCount;
            LoadEmployees();
            int rowCountContract;
     
            using (SqlConnection connection = dbManager.GetConnection())
            {
                connection.Open();

                string query = "INSERT INTO NewEmployee (EmployeeId, FirstName, LastName, EmailAddress, Password, Salt, DateOfBirth, ContactInfo, ContractId, Bsn, Address) VALUES (@EmployeeId, @FirstName, @LastName, @EmailAddress, @Password, @Salt, @DateOfBirth, @ContactInfo, @ContractId, @Bsn, @Address)";
                string countQuery = "SELECT COUNT(*) FROM [NewEmployee]";
                string countContractQuery = "SELECT COUNT(*) FROM Contracts";
                string insertContractQuery = "ISERT INTO Contracts (ContractId) VALUES (@Id)";
                using (SqlCommand command = new SqlCommand(countQuery, connection))
                {
                    rowCount = (int)command.ExecuteScalar();
                }
                using (SqlCommand command = new SqlCommand(countQuery, connection))
                {
                    rowCountContract = (int)command.ExecuteScalar();
                }
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EmployeeId", lastId + 2);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@EmailAddress", emailAddress);
                    command.Parameters.AddWithValue("@Password", hashedPassword);
                    command.Parameters.AddWithValue("@Birthday", dateOfBirth);
                    command.Parameters.AddWithValue("@ContactInfo", contactInfo);
                    command.Parameters.AddWithValue("@ContractId", rowCountContract + 1);
                    command.Parameters.AddWithValue("@Salt", salt);
                    command.Parameters.AddWithValue("@Bsn", bsn);
                    command.Parameters.AddWithValue("@Address", address);

                    command.ExecuteNonQuery();
                }

                using (SqlCommand command = new SqlCommand(insertContractQuery, connection))
                {
                    command.Parameters.AddWithValue("@ContractId", rowCountContract + 2);

                    command.ExecuteNonQuery();
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
                int rowCount;
                string countQuery = "SELECT COUNT(*) FROM [Contracts]";
                string insertQuery = "INSERT INTO [Contracts] (ContractId, ContractStart, ContractEnd, EndMessage, Salary , JobTitle) VALUES (@Id, @ContractStart, @ContractEnd, @EndMessage, @Salary , @JobTitle)";
                using (SqlCommand command = new SqlCommand(countQuery, connection))
                {
                    rowCount = (int)command.ExecuteScalar();
                }
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Id", rowCount + 1);
                    command.Parameters.AddWithValue("@ContractStart", ContractStart);
                    command.Parameters.AddWithValue("@EndMessage", EndMessage);
                    command.Parameters.AddWithValue("@ContractEnd", ContractEnd);
                    command.Parameters.AddWithValue("@Salary", Salary);
                    command.Parameters.AddWithValue("@JobTitle", JobTitle);


                    command.ExecuteNonQuery();

                }

                string updateUserQuery = "UPDATE [NewEmployee] SET ContractId=@Id WHERE EmployeeId = @EmployeeId";
                using (SqlCommand command = new SqlCommand(updateUserQuery, connection))
                {
                    command.Parameters.AddWithValue("@Id", rowCount + 1);
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
                    e.DateOfBirth, e.ContactInfo, e.ContractId, e.Address, e.Bsn, e.ContractHistory,
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
                string selectQuery = @"
                    SELECT * FROM Contracts
                ";
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
                                    // SELECT * FROM [Contract] WHERE Id=ContractId
                                    contractData.Add(reader[i].ToString());
                                }
                                ContractData.Add(contractData);

                            }
                        }
                        else
                        {
                            Console.WriteLine("No data found for the specified ID.");
                        }
                    }
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
            int rowCount;
            int rowCountContract;
            using (SqlConnection connection = dbManager.GetConnection())
            {
                connection.Open();
                string countContractQuery = "SELECT COUNT(*) FROM Contracts";
                string insertEmployeeQuery = "UPDATE [NewEmployee] SET ContractId=@ContractId WHERE Id=@Id";
                string insertContractQuery = "INSERT INTO [Contracts] (ContractId) VALUES (@Id)";

                using (SqlCommand command = new SqlCommand(countContractQuery, connection))
                {
                    rowCountContract = (int)command.ExecuteScalar();
                }
                using (SqlCommand command = new SqlCommand(insertEmployeeQuery, connection))
                {
                    command.Parameters.AddWithValue("@EmployeeId", employeeId);
                    command.Parameters.AddWithValue("@ContractId", rowCountContract + 1);

                    command.ExecuteNonQuery();

                }

                using (SqlCommand command = new SqlCommand(insertContractQuery, connection))
                {
                    command.Parameters.AddWithValue("@ContractId", rowCountContract + 1);

                    command.ExecuteNonQuery();

                }

                connection.Close();
            }
        }

        public void UpdateContract(int id, string ContractStart, string ContractEnd, string JobTitle, string EndMessage, double Salary)
        {
            using (SqlConnection connection = dbManager.GetConnection())
            {
                connection.Open();

                string updateUserQuery = "UPDATE [Contracts] SET JobTitle=@JobTitle, ContractStart=@ContractStart, ContractEnd=@ContractEnd, EndMessage=@EndMessage, Salary=@Salary WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(updateUserQuery, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@ContractStart", ContractStart);
                    command.Parameters.AddWithValue("@EndMessage", EndMessage);
                    command.Parameters.AddWithValue("@ContractEnd", ContractEnd);
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

                string updateEmployeeQuery = "UPDATE [NewEmployee] SET FirstName=@FirstName, LastName=@LastName, EmailAddress=@Emai, DateOfBirth = @DateOfBirth, Bsn = @Bsn, ContactInfo = @ContactInfo, Address = @Address WHERE EmployeeId = @Id";
                using (SqlCommand command = new SqlCommand(updateEmployeeQuery, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@EmailAddress", emailAddress);
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

