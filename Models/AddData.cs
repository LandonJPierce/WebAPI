using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class AddData
    {
        static void Main(string[] args)
        {
                using (var context = new TicketsDbContext())
                {
                    Console.WriteLine("Adding new students");

                    var user = new User
                    {
                        FirstName = "Kevin",
                        LastName = "Hart",
                        Department = "Short",
                        Manager = "John Cena"
                    };

                    context.Users.Add(user);                   
                    
                    context.SaveChanges();

                var user2 = new User
                {
                    FirstName = "Bob",
                    LastName = "Marley",
                    Department = "Eating",
                    Manager = "Vicky Longrow"
                };

                context.Users.Add(user2);

                context.SaveChanges();

                // Display all Students from the database
                var users = (from s in context.Users
                                    orderby s.FirstName
                                    select s).ToList<User>();

                    Console.WriteLine("Retrieve all Students from the database:");

                    foreach (var usr in users)
                    {
                        string name = usr.FirstName + " " + usr.LastName;
                        Console.WriteLine("ID: {0}, Name: {1}", usr.ID, name);
                    }

                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey();
                }
            }
        }
    }
