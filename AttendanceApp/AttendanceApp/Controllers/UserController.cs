using AttendanceApp.Models;
using AttendanceApp.ViewModel;
using System.Linq;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using System;

namespace AttendanceApp.Controllers
{

    public class UserController : Controller
    {
       private AppDbContext db = new AppDbContext();

        // GET: User
        public ActionResult Index()
        { 
            var currentuserid= User.Identity.GetUserId();
          
            var userprofile = new UserProfileViewModel();
       
               
            userprofile.user = db.Users.Find(currentuserid);
            userprofile.rest = db.Rests.FirstOrDefault(x => x.personId == currentuserid);
            userprofile.IO = db.Inouts.FirstOrDefault(x => x.personId == currentuserid);


            return View(userprofile);
        }

        public ActionResult IOEntry()
        {
            var currentuserid = User.Identity.GetUserId();

            return View();
        }

        public ActionResult RestEntry()
        {
            var currentuserid = User.Identity.GetUserId();
            return View();
        }

        [HttpPost]
        public ActionResult RestEntry(rest rest)
        {
            var currentuserid = User.Identity.GetUserId();

            return View();
        }

        public ActionResult DailyReport()
        {
            var currentuserid = User.Identity.GetUserId();
            var dailyresult = db.Inouts.Where(n =>n.personId== currentuserid);
           
            return View(dailyresult.ToList());
        }
        [HttpPost]
        public ActionResult DailyReport(DateTime choosendate)
        {
            var currentuserid = User.Identity.GetUserId();
            var dailyresult = db.Inouts.Where(n => n.personId == currentuserid && n.date== choosendate);
          
            return View(dailyresult.ToList());
        }
        public ActionResult MonthlyReport(DateTime startdate, DateTime? enddate)
        {
            var currentuserid = User.Identity.GetUserId();
            if (enddate == null) { enddate = DateTime.Now; }
            var monthlyresult = db.Inouts.Where(n => n.personId == currentuserid &&
            (n.date >= startdate && n.date <= enddate));
            return View(monthlyresult.ToList());
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}