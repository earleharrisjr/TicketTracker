using System;
using System.ComponentModel.DataAnnotations;

namespace TicketTracker.ViewModels
{
    public class AddTicketFormViewModel
    {
        [Required(ErrorMessage = "Date/Time must be selected")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Issue cannot be blank")]
        public string Issue { get; set; }

        [Required(ErrorMessage = "Details cannot be blank")]
        public string Details { get; set; }

        [Required(ErrorMessage = "Date/Time must be selected")]
        public DateTime GetDate { get; set; }
    }
}
