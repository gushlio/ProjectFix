using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ImagesDB
    {
        private DatabaseConnection dbManager = new DatabaseConnection();

        public void AddImage(byte[] imageData)
        {
            string query = "INSERT INTO Images (ImageData) VALUES (@ImageData)";
            try
            {
                using (SqlConnection connection = dbManager.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ImageData", imageData);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while adding image: " + ex.Message);
                throw;
            }
        }

        public List<byte[]> GetAllImages()
        {
            List<byte[]> images = new List<byte[]>();
            string query = "SELECT ImageData FROM Images";

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
                                byte[] imageData = (byte[])reader["ImageData"];
                                images.Add(imageData);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while retrieving images: " + ex.Message);
                throw;
            }

            return images;
        }

        public void DeleteImage(int imageID)
        {
            string query = "DELETE FROM Images WHERE ImageID = @ImageID";

            try
            {
                using (SqlConnection connection = dbManager.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ImageID", imageID);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while deleting image: " + ex.Message);
                throw;
            }
        }

        public void UpdateImage(int imageID, byte[] newImageData)
        {
            string query = "UPDATE Images SET ImageData = @NewImageData WHERE ImageID = @ImageID";

            try
            {
                using (SqlConnection connection = dbManager.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NewImageData", newImageData);
                        command.Parameters.AddWithValue("@ImageID", imageID);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while updating image: " + ex.Message);
                throw;
            }
        }
        public List<string> GetAllImagesAsBase64()
        {
            List<string> imagesBase64 = new List<string>();
            string query = "SELECT ImageData FROM Images";

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
                                byte[] imageData = (byte[])reader["ImageData"];
                                string base64String = Convert.ToBase64String(imageData);
                                imagesBase64.Add(base64String);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while retrieving images: " + ex.Message);
                throw;
            }

            return imagesBase64;
        }


    }
}
