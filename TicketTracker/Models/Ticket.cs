using Microsoft.AspNetCore.Mvc;

namespace TicketTracker.Models
{
    public class Ticket : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
