using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Ticket
    {
        public int TicketNumber { get; }
        public DateTime PurchaseDate { get; }
        public decimal Price { get; }
        public DateTime ExpiryDate { get; set; }

        public Ticket(Visitor visitor, decimal price, DateTime expiryDate)
        {
            TicketNumber = GenerateTicketNumber();
            PurchaseDate = DateTime.Now;
            Price = price;
            ExpiryDate = expiryDate;
        }

        private int GenerateTicketNumber()
        {
            Random random = new Random();
            return random.Next(1000, 10000);
        }

        public bool IsExpired()
        {
            return DateTime.Now > ExpiryDate;
        }
    }
}
