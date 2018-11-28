using AttendanceApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AttendanceApp.ViewModel
{
    public class UserProfileViewModel
    {
        public ApplicationUser user { get; set; }
        public inout IO { get; set; }
        public rest rest { get; set; }
    }
}