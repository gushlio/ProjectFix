using DataAccessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class TaskDB
    {
        private DatabaseConnection databaseConnection = new DatabaseConnection();
        private AnimalRepository animalRepository;



        public void AddTask(string name, string description, string location, DateTime time, List<string> frequency)
        {
            string frequencyString = string.Join(",", frequency);

            using (SqlConnection connection = databaseConnection.GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Task (Name, Description, Location, Time, Frequency) VALUES (@Name, @Description, @Location, @Time, @Frequency)", connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Description", description);
                command.Parameters.AddWithValue("@Location", location);
                command.Parameters.AddWithValue("@Time", time);
                command.Parameters.AddWithValue("@Frequency", frequencyString);
                command.ExecuteNonQuery();
            }
        }

        public void UpdateTask(int taskId, string name, string description, string location, DateTime time, List<string> frequency)
        {
            string frequencyString = string.Join(",", frequency);

            using (SqlConnection connection = databaseConnection.GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE Task SET Name = @Name, Description = @Description, Location = @Location, Time = @Time, Frequency = @Frequency WHERE TaskId = @TaskId", connection);
                command.Parameters.AddWithValue("@TaskId", taskId);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Description", description);
                command.Parameters.AddWithValue("@Location", location);
                command.Parameters.AddWithValue("@Time", time);
                command.Parameters.AddWithValue("@Frequency", frequencyString);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteTask(int taskId)
        {
            using (SqlConnection connection = databaseConnection.GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Task WHERE TaskId = @TaskId", connection);
                command.Parameters.AddWithValue("@TaskId", taskId);
                command.ExecuteNonQuery();
            }
        }
        public List<Dictionary<string, object>> GetAllTasks()
        {
            List<Dictionary<string, object>> tasks = new List<Dictionary<string, object>>();

            using (SqlConnection connection = databaseConnection.GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Task", connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Dictionary<string, object> task = new Dictionary<string, object>();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            task[reader.GetName(i)] = reader.GetValue(i);
                        }
                        tasks.Add(task);
                    }
                }
            }

            return tasks;
        }

        public Dictionary<string, object> GetTaskById(int taskId)
        {
            Dictionary<string, object> task = null;

            using (SqlConnection connection = databaseConnection.GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Task WHERE TaskId = @TaskId", connection);
                command.Parameters.AddWithValue("@TaskId", taskId);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        task = new Dictionary<string, object>();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            task[reader.GetName(i)] = reader.GetValue(i);
                        }
                    }
                }
            }

            return task;
        }
    }
}
