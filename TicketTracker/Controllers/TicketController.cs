using Microsoft.AspNetCore.Mvc;
using TicketTracker.Data;
using TicketTracker.Models;

namespace TicketTracker.Controllers
{
    public class TicketController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("/addTicket/form")]
        public IActionResult AddTicketForm()
        {
            return View("AddTicketForm");
        }
        //handle post request that is getting sent by the form
        [HttpPost]
        [Route("/Adding")]
        public IActionResult AddTicket(string issue, string details)
        {
            Ticket newTicket = new Ticket(issue, details);
            TicketData.Add(newTicket);

            ViewBag.tickets = TicketData.tickets; 


            return View("Index");
        }


    }
}
