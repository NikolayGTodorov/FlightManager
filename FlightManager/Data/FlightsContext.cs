using FlightManager.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Data
{
    public class FlightsContext : IdentityDbContext<ApplicationUser>
    {
        public FlightsContext(DbContextOptions<FlightsContext> options)
            : base(options)
        {
        }

        public DbSet<Flights> Flights { get; set; }
        public DbSet<Reservations> Reservations { get; set; }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }

    }
}
