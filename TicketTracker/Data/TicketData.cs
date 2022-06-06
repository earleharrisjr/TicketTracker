using System.Collections.Generic;
using TicketTracker.Models;

namespace TicketTracker.Data
{
    public class TicketData
    {
        public static List<Ticket> tickets = new List<Ticket>();

        public static void Add(Ticket ticketObject)
        {
            tickets.Add(ticketObject);  
        }
    }
}
