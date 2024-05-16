using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class TicketsDB
    {
        private DatabaseConnection dbManager = new DatabaseConnection();
        public DataTable LoadTicketData()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = dbManager.GetConnection())
            {
                string query = "SELECT TicketID, Type, Price, QuantityAvailable, TicketsSold FROM Tickets";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                adapter.Fill(dataTable);
            }

            return dataTable;
        }

        public void UpdateQuantityAvailable(string ticketType, int quantityToAdd)
        {
            using (SqlConnection connection = dbManager.GetConnection())
            {
                string query = $"UPDATE Tickets SET QuantityAvailable = QuantityAvailable + {quantityToAdd} WHERE Type = @TicketType";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@TicketType", ticketType);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void UpdateTicketPrice(string ticketType, decimal newPrice)
        {
            using (SqlConnection connection = dbManager.GetConnection())
            {
                string query = $"UPDATE Tickets SET Price = @NewPrice WHERE Type = @TicketType";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@NewPrice", newPrice);
                command.Parameters.AddWithValue("@TicketType", ticketType);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public decimal GetTicketPrice(string ticketType)
        {
            decimal price = 0;

            using (SqlConnection connection = dbManager.GetConnection())
            {
                string query = "SELECT Price FROM Tickets WHERE Type = @TicketType";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@TicketType", ticketType);

                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    price = Convert.ToDecimal(result);
                }
            }
            return price;
        }

        public int GetQuantityAvailable(string ticketType)
        {
            int quantityAvailable = 0;

            using (SqlConnection connection = dbManager.GetConnection())
            {
                string query = "SELECT QuantityAvailable FROM Tickets WHERE Type = @TicketType";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TicketType", ticketType);

                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    quantityAvailable = Convert.ToInt32(result);
                }
            }

            return quantityAvailable;
        }

        public int GetTicketsSold(string ticketType)
        {
            int ticketsSold = 0;

            using (SqlConnection connection = dbManager.GetConnection())
            {
                string query = "SELECT TicketsSold FROM Tickets WHERE Type = @TicketType";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TicketType", ticketType);

                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    ticketsSold = Convert.ToInt32(result);
                }
            }

            return ticketsSold;
        }

        public void UpdateQuantityAvailableAndTicketsSold(string ticketType, int newQuantityAvailable, int newTicketsSold)
        {
            using (SqlConnection connection = dbManager.GetConnection())
            {
                string query = "UPDATE Tickets SET QuantityAvailable = @NewQuantityAvailable, TicketsSold = @NewTicketsSold WHERE Type = @TicketType";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NewQuantityAvailable", newQuantityAvailable);
                command.Parameters.AddWithValue("@NewTicketsSold", newTicketsSold);
                command.Parameters.AddWithValue("@TicketType", ticketType);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
