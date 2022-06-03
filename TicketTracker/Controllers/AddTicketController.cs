using Microsoft.AspNetCore.Mvc;

namespace TicketTracker.Controllers
{
    public class AddTicketController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("/addTicket/form")]
        public IActionResult AddTicketForm()
        {
            return View("form");
        }
    }
}
