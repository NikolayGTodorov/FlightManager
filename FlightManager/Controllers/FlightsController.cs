using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{

    public class FlightsController : Controller
    {
        private readonly FlightsContext _context;

        public FlightsController(FlightsContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        // GET: Flights
        public async Task<IActionResult> Index()
        {
            return View(await _context.Flights.ToListAsync());
        }

        // GET: Flights/Details/
        [AllowAnonymous]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flights = await _context.Flights
                .FirstOrDefaultAsync(m => m.PlaneId == id);
            if (flights == null)
            {
                return NotFound();
            }

            return View(flights);
        }

        [Authorize(Roles = "Admin,Worker")]
        // GET: Flights/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Flights/Create
        [Authorize(Roles = "Admin,Worker")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PlaneId,LocationFrom,LocationTo,DepartTime,ArrivalTime,PlaneType,PilotName,PlaneCapacityNormal,PlaneCapacityBusiness,AlreadyReserved")] Flights flights)
        {
            if (ModelState.IsValid)
            {
                _context.Add(flights);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(flights);
        }

        // GET: Flights/Edit/
        [Authorize(Roles = "Admin,Worker")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flights = await _context.Flights.FindAsync(id);
            if (flights == null)
            {
                return NotFound();
            }
            return View(flights);
        }

        // POST: Flights/Edit/
        [Authorize(Roles = "Admin,Worker")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PlaneId,LocationFrom,LocationTo,DepartTime,ArrivalTime,PlaneType,PilotName,PlaneCapacityNormal,PlaneCapacityBusiness,AlreadyReserved")] Flights flights)
        {
            if (id != flights.PlaneId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(flights);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FlightsExists(flights.PlaneId))
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
            return View(flights);
        }

        // GET: Flights/Delete/
        [Authorize(Roles = "Admin,Worker")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flights = await _context.Flights
                .FirstOrDefaultAsync(m => m.PlaneId == id);
            if (flights == null)
            {
                return NotFound();
            }

            return View(flights);
        }

        // POST: Flights/Delete/
        [Authorize(Roles = "Admin,Worker")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var flights = await _context.Flights.FindAsync(id);
            _context.Flights.Remove(flights);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FlightsExists(int id)
        {
            return _context.Flights.Any(e => e.PlaneId == id);
        }
    }
}
