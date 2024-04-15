using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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

            using(SqlConnection connection = dbManager.GetConnection())
            {
                string query = "SELECT TicketID, Type, Price, QuantityAvailable, TicketsSold FROM Tickets";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                adapter.Fill(dataTable);
            }

            return dataTable;
        }

        public void UpdateQuantityAvailable(string ticketType, int quantityToAdd)
        {
            using(SqlConnection connection = dbManager.GetConnection())
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
            using(SqlConnection connection = dbManager.GetConnection())
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

            using(SqlConnection connection = dbManager.GetConnection())
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
    }
}
