using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Program
    {
        static void Main(string[] args) {}
    }
    public class TicketsDbContext :  DbContext
    {
        public TicketsDbContext() : base("name = EmployeeTickets") {}
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }

    }
}