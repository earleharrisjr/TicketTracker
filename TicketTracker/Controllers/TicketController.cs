using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TicketTracker.Data;
using TicketTracker.Models;
using TicketTracker.ViewModels;
using System;

namespace TicketTracker.Controllers
{
    public class TicketController : Controller
    {
        private ApplicationDbContext context;
        public TicketController(ApplicationDbContext applicationDbContext)
        {
            context = applicationDbContext;
        }

        public IActionResult Index()
        {
            ViewBag.tickets = context.Tickets.ToList();


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
        public IActionResult AddTicket(AddTicketFormViewModel viewModel)
        {
            
            //TicketData.Add(newTicket);

            if (!ModelState.IsValid)
            {
                return View("AddTicketForm");
            }
            Ticket newTicket = new Ticket(viewModel.Issue, viewModel.Details, viewModel.GetDate);
            TicketData.Add(newTicket);
            //ViewBag.tickets = TicketData.tickets; 
            context.Tickets.Add(newTicket);
            context.SaveChanges();


            return Redirect("Ticket/Index");
        }

        //trying this for viewing ticket
        public IActionResult ViewTicket(int id)
        {
           // Console.WriteLine("this is the ID RIGHT HERE!!!"+ id);
            var selectedTicket = context.Tickets.Find(id);
            return View(selectedTicket);
        }


        public IActionResult Edit(int id)
        {
            var selectedTicket = context.Tickets.Find(id);
            return View(selectedTicket);
        }

        [HttpPost]
        public IActionResult Edit(Ticket ticket)
        {
            var selectedTicket = context.Tickets.Find(ticket.Id);
            selectedTicket.Issue = ticket.Issue;
            selectedTicket.Details = ticket.Details;
            context.SaveChanges();
            return RedirectToAction("index");
        }


        public IActionResult Delete(int id)
        {
            var selectedTicket = context.Tickets.Find(id);
            return View(selectedTicket);
        }
        [HttpPost]
        public IActionResult Delete(Ticket ticket)
        {
            var selectedTicket = context.Tickets.Find(ticket.Id);
            context.Tickets.Remove(selectedTicket);
            context.SaveChanges();

            return RedirectToAction("index");
        }
    }
}
