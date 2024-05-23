using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Visitor : User
    {
        public List<Ticket> Tickets { get; } = new List<Ticket>();

        public Visitor(int id, string firstName, string lastName, string emailAddress, string password)
            : base(id, firstName, lastName, emailAddress, password)
        {
            Tickets = new List<Ticket>();
        }

        public void BuyTicket(decimal price, DateTime expiryDate)
        {
            Ticket ticket = new Ticket(this, price, expiryDate);
            Tickets.Add(ticket);
        }

        public List<Ticket> PurchaseHistory
        {
            get { return Tickets; }
        }

        public void CancelTicket(Ticket ticket)
        {
            if (Tickets.Contains(ticket))
            {
                Tickets.Remove(ticket);
            }
        }
    }
}
