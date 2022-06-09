using Microsoft.AspNetCore.Mvc;
using TicketTracker.Data;
using TicketTracker.Models;
using TicketTracker.ViewModels;

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

        [Route("/ViewTicket")]
        public IActionResult ViewTicket()
        {
            return View("ViewTicket");
        }


        //handle post request that is getting sent by the form
        [HttpPost]
        [Route("/Adding")]
        public IActionResult AddTicket(AddTicketFormViewModel viewModel)
        {
            
            //TicketData.Add(newTicket);

            if (!ModelState.IsValid)
            {
                return View("AddTicketForm");
            }
            Ticket newTicket = new Ticket(viewModel.Issue, viewModel.Details, viewModel.GetDate);
            TicketData.Add(newTicket);
            ViewBag.tickets = TicketData.tickets; 


            return View("Index");
        }


    }
}
