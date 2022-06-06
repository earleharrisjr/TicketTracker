namespace TicketTracker.Models
{
    public class Ticket
    {
        public string Issue { get; set; }   
        public string Details { get; set; }


        public Ticket(string issue, string details)
        {
            Issue = issue;
            Details = details;
        }


        //constructor


    }
}
