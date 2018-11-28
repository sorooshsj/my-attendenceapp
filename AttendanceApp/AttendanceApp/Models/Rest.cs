using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AttendanceApp.Models
{
    public class rest
    {
        public int Id { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public bool isCommited { get; set; }
        public ICollection<ApplicationUser> persons { get; set; }
        public string personId { get; set; }
    }
}