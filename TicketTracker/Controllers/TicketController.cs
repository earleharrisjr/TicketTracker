using Microsoft.AspNetCore.Mvc;

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
            //passing form details into View("Home")
            ViewBag.Issue = issue;
            ViewBag.Details= details;   
            return View("Index");
        }


    }
}
