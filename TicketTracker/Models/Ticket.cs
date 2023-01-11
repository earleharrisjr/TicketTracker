using System;
using System.Collections.Generic;


namespace TicketTracker.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Issue { get; set; }
        public string Details { get; set; }
        public DateTime GetDate { get; set; }

        //public List<NotesModel> Notes { get; set; }


        public Ticket() { }

        public Ticket(string name, string issue, string details, DateTime getdate)
        {
            Name = name;
            Issue = issue;
            Details = details;
            GetDate = getdate;
           
        }

        public Ticket(string issue, string details, DateTime getDate)
        {
            Issue = issue;
            Details = details;
            GetDate = getDate;
        }
    }

}
