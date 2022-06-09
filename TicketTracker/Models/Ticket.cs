using System;


namespace TicketTracker.Models
{
    public class Ticket
    {

        public string Issue { get; set; }
        public string Details { get; set; }
        public DateTime GetDate { get; set; }

        public Ticket() { }
        public Ticket(string issue, string details, DateTime getdate)
        {
            Issue = issue;
            Details = details;
            GetDate = getdate;
        }
    }
}
