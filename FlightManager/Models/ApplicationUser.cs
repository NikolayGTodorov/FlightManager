using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FlightManager.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [Display(Name = "First name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last name")]
        public string LastName { get; set; }
        [Required]
        [MaxLength(10)]
        [Display(Name = "National ID")]
        public string NationalId { get; set; }
        [Required]
        [MaxLength(150)]
        [Display(Name = "Address")]
        public string StreetAddress { get; set; }
    }
}
