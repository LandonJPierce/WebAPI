using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;
using System.Data.Entity;

namespace WebAPI.Controllers
{
    public class DefaultController : ApiController
    {

        //Creating a method to return Json data
        public HttpResponseMessage Get()
        {
            List<User> employeeList = new List<User>();
            using(EmployeeTickets db = new EmployeeTickets())
            {
                employeeList = db.Users.OrderBy(a => a.FirstName).ToList();
                HttpResponseMessage response;
                response = Request.CreateResponse(HttpStatusCode.OK, employeeList);
                return response;
            }
        }       
    }
}



