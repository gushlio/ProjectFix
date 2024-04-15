using Microsoft.Data.SqlClient;


namespace DataAccessLayer
{
    public class AnimalDB
    {
        private DatabaseConnection dbManager = new DatabaseConnection();

        public void AddAnimal(string name, string species, int age, string gender, decimal weight, string color, bool isSick, string location, DateTime lastFeedTime)
        {
            string query = "INSERT INTO Animal (Name, Species, Age, Gender, Weight, Color, IsSick, Location, LastFeedTime) VALUES (@Name, @Species, @Age, @Gender, @Weight, @Color, @IsSick, @Location, @LastFeedTime)";
            using (SqlConnection connection = dbManager.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Species", species);
                    command.Parameters.AddWithValue("@Age", age);
                    command.Parameters.AddWithValue("@Gender", gender);
                    command.Parameters.AddWithValue("@Weight", weight);
                    command.Parameters.AddWithValue("@Color", color);
                    command.Parameters.AddWithValue("@IsSick", isSick);
                    command.Parameters.AddWithValue("@Location", location);
                    command.Parameters.AddWithValue("@LastFeedTime", lastFeedTime);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<IDictionary<string, object>> GetAllAnimals()
        {
            List<IDictionary<string, object>> animals = new List<IDictionary<string, object>>();
            string query = "SELECT * FROM Animal";

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
                                var animal = new Dictionary<string, object>();
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    animal[reader.GetName(i)] = reader.GetValue(i);
                                }
                                animals.Add(animal);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while retrieving animals: " + ex.Message);
            }

            return animals;
        }

        public void DeleteAnimal(int animalID)
        {
            string query = "DELETE FROM Animal WHERE AnimalID = @AnimalID";

            try
            {
                using (SqlConnection connection = dbManager.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AnimalID", animalID);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while deleting animal: " + ex.Message);
                throw;
            }
        }

        public void UpdateAnimal(string name, string species, int age, string gender, decimal weight, string color, bool isSick, string location, DateTime lastFeedTime)
        {
            string query = "UPDATE Animal SET Age = @Age, Gender = @Gender, Weight = @Weight, Color = @Color, IsSick = @IsSick, Location = @Location, LastFeedTime = @LastFeedTime WHERE Name = @Name AND Species = @Species";

            try
            {
                using (SqlConnection connection = dbManager.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Species", species);
                        command.Parameters.AddWithValue("@Age", age);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@Weight", weight);
                        command.Parameters.AddWithValue("@Color", color);
                        command.Parameters.AddWithValue("@IsSick", isSick);
                        command.Parameters.AddWithValue("@Location", location);
                        command.Parameters.AddWithValue("@LastFeedTime", lastFeedTime);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while updating animal: " + ex.Message);
                throw;
            }
        }

    }
}
