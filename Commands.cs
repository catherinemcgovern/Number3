using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Logging;

namespace Buffteks
{
    public static class Commands
    {
        public static void ListAll()
        {
            using (var db = new AppDbContext())              //#A
            {
                        Console.WriteLine();

                 Console.WriteLine($"BUFFTEKS DATABASE CONTENT:");

    
                        Console.WriteLine();

                         Console.WriteLine("Students");
                        
                         Console.WriteLine("--------------------------------------------------------------------");

                  var students = db.Students.ToList();
                        foreach(Student s in students)
                        {
                           Console.WriteLine($"Buffteks Members: {s.FirstName} {s.LastName}, {s.PhoneNumber}, {s.Email}");
                        }
                        Console.WriteLine();                        
                        Console.WriteLine();

                         Console.WriteLine("Organizations");
                        
                         Console.WriteLine("--------------------------------------------------------------------");
                         var organizations = db.Organizations.ToList();
                        foreach(Organization o in organizations)
                        {
                            Console.WriteLine($"Organization: {o.OrganizationId}, {o.Name}");
                        }

                        
                        
                        Console.WriteLine();
                         Console.WriteLine();


                         Console.WriteLine("Team");
                        
                         Console.WriteLine("--------------------------------------------------------------------");

                        var teams = db.Team.ToList();
                        foreach(Team t in teams)
                        {
                            Console.WriteLine($"Team: Team number {t.TeamId}, {t.TeamName}");
                        }
                        
                        
                        Console.WriteLine();
                        Console.WriteLine();
                        


                         Console.WriteLine("Advisor");
                        
                         Console.WriteLine("--------------------------------------------------------------------");

                        var Advisor = db.Advisor.ToList();
                        foreach(Advisor a in Advisor)
                        {
                            Console.WriteLine($"Buffteks Advisor: {a.AdvisorId}: {a.FirstName} {a.LastName}, {a.PhoneNumber}, {a.Email}");
                        }


                        Console.WriteLine();
                         Console.WriteLine();


                         Console.WriteLine("Projects");
                        
                         Console.WriteLine("--------------------------------------------------------------------");


                        var projects = db.Project.ToList();
                        foreach(Project p in projects)
                        {
                            Console.WriteLine($"Project Number {p.ProjectID}; {p.ProjectName}; Required Hours: {p.RequiredHours}; Deadline: {p.Deadline: d/M/yyyy}");
                        }

                        /*
*/
                 
           
        
/*
                     
                    
             




                         */



                /* 
                foreach (var book in db.Books.AsNoTracking() //#B
                    .Include(a => a.Author))                 //#C
                {
                    var webUrl = book.Author.WebUrl ?? "- no web url given -";
                    Console.WriteLine($"{book.Title} by {book.Author.Name}");
                    Console.WriteLine("     Published on " +
                        $"{book.PublishedOn:dd-MMM-yyyy}. {webUrl}");

                        */
                
            }
        }
    }
}