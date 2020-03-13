using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FlightManager.Data;
using MvcMovie.Data;

namespace MvcMovie.Models
{
    public class Reservations
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Lastname { get; set; }
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Identificational number must consist of 10 digits.")]
        public string IdentificationalNumber { get; set; }
        [Phone(ErrorMessage = "Invalid phone number.")]
        public string PhoneNumber { get; set; }
        public string Nationality { get; set; }
        //[Range(AllowableValues = new[] { "Economy", "Business" }, ErrorMessage = "Seats are either economy or business class.")]
        //[RegularExpression(@"$Economy$|$Business$", ErrorMessage = "Seats are either Economy or Business class.")]
        public string TicketType { get; set; }
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }
        [RegularExpression(@"[1-9][0-9]*", ErrorMessage = "Flight number cannot be zero or negative number.")]
        public int FlightNumber { get; set; }

    }
}
