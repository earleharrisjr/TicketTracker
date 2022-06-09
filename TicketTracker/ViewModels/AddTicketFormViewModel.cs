using System;
using System.ComponentModel.DataAnnotations;

namespace TicketTracker.ViewModels
{
    public class AddTicketFormViewModel
    {
        [Required]
        public string Issue { get; set; }
        [Required]
        public string Details { get; set; }
        [Required(ErrorMessage = "Date and time required")]
        public DateTime GetDate { get; set; }
    }
}
