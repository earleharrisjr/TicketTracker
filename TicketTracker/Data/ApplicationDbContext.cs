using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TicketTracker.Models;

namespace TicketTracker.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }

    public class TicketDbContext : DbContext
    {
        public DbSet<Ticket> Tickets { get; set; }

        public TicketDbContext(DbContextOptions<TicketDbContext> options) : base(options) { }
    }
}

