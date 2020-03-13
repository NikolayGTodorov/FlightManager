using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;

namespace MvcMovie.Models
{
    public class Flights
    {
        [Key]
        public int PlaneId { get; set; }
        [Display(Name = "From")]
        public string LocationFrom { get; set; }
        [Display(Name = "To")]
        public string LocationTo { get; set; }
        [Display(Name = "Depart")]
        public DateTime DepartTime { get; set; }
        [Display(Name = "Arrival")]
        public DateTime ArrivalTime { get; set; }
        [Display(Name = "Plane Type")]
        public string PlaneType { get; set; }
        [Display(Name = "Pilot")]
        public string PilotName { get; set; }
        [Display(Name = "Economy Seats")]
        public int PlaneCapacityNormal { get; set; }
        [Display(Name = "Business Seats")]
        public int PlaneCapacityBusiness { get; set; }
        [Display(Name = "Reserved")]
        public int AlreadyReserved { get; set; }
    }
}
