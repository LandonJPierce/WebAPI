using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public int UserID { get; set; }
        public int TicketID { get; set; }

        public virtual User User { get; set; }
        public virtual Ticket Ticket { get; set; }
    }
}