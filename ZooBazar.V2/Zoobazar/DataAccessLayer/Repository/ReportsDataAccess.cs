using DataAccessLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class ReportsDataAccess
    {
        private DatabaseConnection dbManager = new DatabaseConnection();

        public void CreateReport(ReportDTO reportDTO)
        {
            using (SqlConnection connection = dbManager.GetConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand("INSERT INTO Reports (Title, Category, Description, CreatedBy) VALUES (@Title, @Category, @Description, @CreatedBy)", connection);
                command.Parameters.AddWithValue("@Title", reportDTO.Title);
                command.Parameters.AddWithValue("@Category", reportDTO.Category);
                command.Parameters.AddWithValue("@Description", reportDTO.Description);
                command.Parameters.AddWithValue("@CreatedBy", reportDTO.CreatedBy);

                command.ExecuteNonQuery();
            }
        }

        public List<ReportDTO> GetAllReports()
        {
            List<ReportDTO> reports = new List<ReportDTO>();

            using (SqlConnection connection = dbManager.GetConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Reports", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ReportDTO reportDTO = new ReportDTO();
                    reportDTO.Id = (int)reader["Id"];
                    reportDTO.Title = (string)reader["Title"];
                    reportDTO.Category = (string)reader["Category"];
                    reportDTO.Description = (string)reader["Description"];
                    reportDTO.DateCreated = (DateTime)reader["DateCreated"];
                    reportDTO.CreatedBy = (int)reader["CreatedBy"];

                    reports.Add(reportDTO);
                }
            }

            return reports;
        }

        public List<ReportDTO> GetReportsByCategory(string category)
        {
            List<ReportDTO> reports = new List<ReportDTO>();

            using (SqlConnection connection = dbManager.GetConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Reports WHERE Category = @Category", connection);
                command.Parameters.AddWithValue("@Category", category);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ReportDTO reportDTO = new ReportDTO();
                    reportDTO.Id = (int)reader["Id"];
                    reportDTO.Title = (string)reader["Title"];
                    reportDTO.Category = (string)reader["Category"];
                    reportDTO.Description = (string)reader["Description"];
                    reportDTO.DateCreated = (DateTime)reader["DateCreated"];
                    reportDTO.CreatedBy = (int)reader["CreatedBy"];

                    reports.Add(reportDTO);
                }
            }

            return reports;
        }

        public ReportDTO GetReportById(int id)
        {
            ReportDTO reportDTO = null;

            using (SqlConnection connection = dbManager.GetConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Reports WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    reportDTO = new ReportDTO();
                    reportDTO.Id = (int)reader["Id"];
                    reportDTO.Title = (string)reader["Title"];
                    reportDTO.Category = (string)reader["Category"];
                    reportDTO.Description = (string)reader["Description"];
                    reportDTO.DateCreated = (DateTime)reader["DateCreated"];
                    reportDTO.CreatedBy = (int)reader["CreatedBy"];
                }
            }

            return reportDTO;
        }
    }
}
