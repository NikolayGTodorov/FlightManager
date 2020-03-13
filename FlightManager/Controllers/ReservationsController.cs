using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlightManager.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class ReservationsController : Controller
    {
        private readonly FlightsContext _context;

        public ReservationsController(FlightsContext context)
        {
            _context = context;
        }

        // GET: Reservations
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Reservations.ToListAsync());
        }

        // GET: Reservations/Details
        [AllowAnonymous]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservations = await _context.Reservations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reservations == null)
            {
                return NotFound();
            }

            return View(reservations);
        }

        // GET: Reservations/Create
        [AllowAnonymous]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Reservations/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> Create([Bind("Id,Name,Surname,Lastname,Nationality,IdentificationalNumber,PhoneNumber,Email,FlightNumber,TicketType")] Reservations reservations)
        {
            if (ModelState.IsValid)
            {
                int business = _context.Flights.Find(reservations.FlightNumber).PlaneCapacityBusiness;
                int economy = _context.Flights.Find(reservations.FlightNumber).PlaneCapacityNormal;
                if(reservations.TicketType == "Economy")
                {
                    if(_context.Flights.Find(reservations.FlightNumber).PlaneCapacityNormal > 0)
                    {
                        _context.Flights.Find(reservations.FlightNumber).PlaneCapacityNormal -= 1;
                        _context.Flights.Find(reservations.FlightNumber).AlreadyReserved += 1;
                        await _context.SaveChangesAsync();
                        Mailer.SendMail(reservations);
                    }
                    else
                    {
                        return View(_context.Flights);
                    }
                }
                else if(reservations.TicketType == "Business")
                {
                    if(_context.Flights.Find(reservations.FlightNumber).PlaneCapacityBusiness > 0)
                    {
                        _context.Flights.Find(reservations.FlightNumber).PlaneCapacityBusiness -= 1;
                        _context.Flights.Find(reservations.FlightNumber).AlreadyReserved += 1;
                        await _context.SaveChangesAsync();
                        Mailer.SendMail(reservations);
                    }
                    else
                    {
                        return View(_context.Flights);
                    }
                }
                else
                {
                    
                    return View(_context.Flights);
                }
                return RedirectToAction(nameof(Index));
            }
            return View(reservations);
        }
        // GET: Reservations/Edit
        [AllowAnonymous]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservations = await _context.Reservations.FindAsync(id);
            if (reservations == null)
            {
                return NotFound();
            }
            return View(reservations);
        }

        // POST: Reservations/Edit/
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Surname,Lastname,Nationality,IdentificationalNumber,PhoneNumber,Email,FlightNumber,TicketType")] Reservations reservations)
        {
            if (id != reservations.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reservations);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReservationsExists(reservations.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(reservations);
        }

        // GET: Reservations/Delete/
        [AllowAnonymous]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservations = await _context.Reservations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reservations == null)
            {
                return NotFound();
            }

            return View(reservations);
        }

        // POST: Reservations/Delete/
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reservations = await _context.Reservations.FindAsync(id);
            _context.Flights.Find(reservations.FlightNumber).AlreadyReserved -= 1;
            if(reservations.TicketType == "Economy")
            {
                _context.Flights.Find(reservations.FlightNumber).PlaneCapacityNormal += 1;
            }
            else if(reservations.TicketType == "Business")
            {
                _context.Flights.Find(reservations.FlightNumber).PlaneCapacityBusiness += 1;
            }
            _context.Reservations.Remove(reservations);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [AllowAnonymous]
        private bool ReservationsExists(int id)
        {
            return _context.Reservations.Any(e => e.Id == id);
        }
    }
}
