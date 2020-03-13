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
using Microsoft.AspNetCore.Identity;
using FlightManager.Models;
using FlightManager.Views.Users.ViewModels;
using FlightManager.Areas.Identity.Pages.Account;

namespace FlightManager.Controllers
{
    public class UsersController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        //private readonly RoleManager<IdentityUserRole> userRoleManager;

        public UserManager<ApplicationUser> userManager { get; }

        public UsersController(RoleManager<IdentityRole> roleManager,
                               UserManager<ApplicationUser> userManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(userManager.Users.ToList());
        }

        [HttpGet]
        public async Task<IActionResult> Details(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await userManager.Users.FirstOrDefaultAsync(m => m.Id == id);

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }
        
        [Authorize(Roles = "Admin")]
        [HttpGet]
        // GET: Users/Create
        public IActionResult Create()
        {            
            return View();
        }


        // POST: Flights/Create
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(UsersVM model)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser applicationUser = new ApplicationUser
                {
                    Id = model.Id,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    UserName = model.UserName,
                    Email = model.Email,
                    NationalId = model.NationalId,
                    PhoneNumber = model.PhoneNumber,
                    StreetAddress = model.StreetAddress,
                    PasswordHash = model.Password
                };
                
                IdentityResult result = await userManager.CreateAsync(applicationUser);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Users");
                }

                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            var user = await userManager.FindByIdAsync(id);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with id = {id} cannot be found";
                return View("Error");
            }

            var model = new UsersVM
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                UserName = user.UserName,
                Email = user.Email,
                NationalId = user.NationalId,
                PhoneNumber = user.PhoneNumber,
                StreetAddress = user.StreetAddress,
                Password = user.PasswordHash
            };
            
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UsersVM model)
        {
            var user = await userManager.FindByIdAsync(model.Id);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with id = {model.Id} cannot be found";
                return View("Error");
            }
            else
            {
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.UserName = model.UserName;
                user.Email = model.Email;
                user.NationalId = model.NationalId;
                user.PhoneNumber = model.PhoneNumber;
                user.StreetAddress = model.StreetAddress;

                var result = await userManager.UpdateAsync(user);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Users");
                }

                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(model);
            }
        }

        // GET: Flights/Delete/
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await userManager.FindByIdAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Flights/Delete/
        [Authorize(Roles = "Admin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var user = await userManager.FindByIdAsync(id);
            var result = await userManager.DeleteAsync(user);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Users");
            }

            foreach (IdentityError error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }

            return RedirectToAction(nameof(Index));
        }

    }
}
