using System;
using System.Collections.Generic;

namespace TicketTracker.Models
{
    public class NotesModel<T>
    {
        public List<T> Notes { get; set; }
        public NotesModel(List<T> note) {
            Notes = note; 
        }
    }
}
