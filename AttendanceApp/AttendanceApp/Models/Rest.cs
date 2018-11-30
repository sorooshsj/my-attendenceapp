using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AttendanceApp.Models
{
    public class rest
    {
        public int Id { get; set; }
        [Display(Name = "تاریخ شروع")]
        public DateTime startDate { get; set; }
        [Display(Name = "تاریخ پایان")]
        public DateTime endDate { get; set; }
        [Display(Name = "زمان شروع")]
        public DateTime startTime { get; set; }
        [Display(Name = "زمان پایان")]
        public DateTime endTime { get; set; }
        [Display(Name = "تایید شده؟")]
        public bool isCommited { get; set; }
        public ICollection<ApplicationUser> persons { get; set; }
        [Display(Name = "جنسیت")]
        public string personId { get; set; }
    }
}