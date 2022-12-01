using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Ticket
    {
        public int TicketID { get; set; }
        public int TNumber { get; set; }
        public string Title { get; set; }
        public string TimeEntered { get; set; }
        public string ETA { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}