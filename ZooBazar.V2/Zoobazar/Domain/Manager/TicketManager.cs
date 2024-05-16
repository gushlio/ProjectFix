using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Manager
{
    public class TicketManager
    {
        private readonly TicketsDB _ticketsDB;

        public TicketManager()
        {
            _ticketsDB = new TicketsDB();
        }

        public DataTable LoadTicketData()
        {
            return _ticketsDB.LoadTicketData();
        }

        public void UpdateQuantityAvailable(string ticketType, int quantityToAdd)
        {
            _ticketsDB.UpdateQuantityAvailable(ticketType, quantityToAdd);
        }

        public void UpdateTicketPrice(string ticketType, decimal newPrice)
        {
            _ticketsDB.UpdateTicketPrice(ticketType, newPrice);
        }

        public decimal GetTicketPrice(string ticketType)
        {
            return _ticketsDB.GetTicketPrice(ticketType);
        }

        public void PurchaseTickets(string ticketType, int quantity)
        {
            // Get the current quantity available for the ticket type
            int currentQuantityAvailable = _ticketsDB.GetQuantityAvailable(ticketType);

            // Calculate the new quantity available and tickets sold
            int newQuantityAvailable = currentQuantityAvailable - quantity;
            int newTicketsSold = _ticketsDB.GetTicketsSold(ticketType) + quantity;

            // Update the database with the new quantities
            _ticketsDB.UpdateQuantityAvailableAndTicketsSold(ticketType, newQuantityAvailable, newTicketsSold);
        }
    }
}
