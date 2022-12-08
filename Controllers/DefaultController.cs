using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;
using System.Data.Entity;
using System.Collections.ObjectModel;
using System.Net.Http.Headers;

namespace WebAPI.Controllers
{
    public class DefaultController : ApiController
    {
        public ICollection<User> Get()
        {
            ICollection<User> userColl = new Collection<User>();
            using (EmployeeTickets db = new EmployeeTickets())
            {
                userColl = db.Users.ToList();
                return userColl;
            }
        }       
            static void Main(string[] args)
            {
                HttpClient client = new HttpClient
                {
                    BaseAddress = new Uri("http://localhost:44372/")
                };
                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                // List all Names.
                HttpResponseMessage response = client.GetAsync("api/Default").Result;  // Blocking call!
                if (response.IsSuccessStatusCode)
                {
                    _ = response.Content.ReadAsStringAsync().Result;
                }
                else
                {
                    Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                }

                {
                    User p = new User { UserID = 1, FirstName = "Random", LastName = "Guy", Department = "sales", Manager = "Some Guy" };
                    var createresponse = client.PostAsJsonAsync("api/createUser", p).Result;
                    if (createresponse.IsSuccessStatusCode)
                    {
                        Console.Write("Success");
                    }
                    else
                        Console.Write("Error");
                }
            }
        }

    }



