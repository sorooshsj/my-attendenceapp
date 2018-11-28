using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AttendanceApp.Models
{
    public class inout
    {
        public int Id { get; set; }
        public DateTime date { get; set; }
        public string personId { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public bool isRest { get; set; }

        /*
         * 
         * [DatabaseGenerated(DatabaseGeneratedOption.Computed)
         public int pmd {get (){ counting ligic}}
             
             */

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public double workInThisDay {
            get
            {
                return ((endTime - startTime).TotalHours);
            }

        }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public double delayInThisDay {
            get {
                var rule = new rule();

              //ToDo check delay accounting
                var delay = startTime.TimeOfDay.TotalHours - rule.startWorkTime;
                if(delay > 0.0)
                    return (delay);
                 

                return (0.0);
            }

        }
        public bool isCommited { get; set; }
        public ICollection<ApplicationUser> person { get; set; }
    }
}