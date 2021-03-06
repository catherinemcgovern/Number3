﻿using System.Collections;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Logging;

namespace Buffteks
{
     class Program
    {
        static void Main(string[] args)
        {
            
            /*
            

            
            
             */

            //THis is where I'm going to add code to write out my commands







            //Here ends the command code
            


            
                        using(var db = new AppDbContext())
            {
                try
                {

                    //no matter what, delete and then create
                    db.Database.EnsureDeleted();
                    db.Database.EnsureCreated();

                    if(!db.Students.Any())
                    {
                        List<Student> students = new List<Student>()
                        {
                            new Student()
                            {
                                FirstName = "Jeffry",
                                LastName = "Babb",
                                PhoneNumber = "123-555-1234",
                                Email = "test1@test.com",
                                Role = "Senior",
                                TeamId = 1,
                            },
                            new Student()
                            {
                                FirstName = "Joe",
                                LastName = "Smith",
                                PhoneNumber = "456-684-4684",
                                Email = "fun@aol.com",
                                Role = "Sophomore",
                                TeamId = 1,
                            },
                            new Student()
                            {
                                FirstName = "Jane",
                                LastName = "Doe",
                                PhoneNumber = "123-555-1234",
                                Email = "janestudent@buffs.wtamu.edu",
                                Role = "Freshman",
                                TeamId = 2,

                            },  

                            new Student()
                            {
                                FirstName = "Marion",
                                LastName = "McGovern",
                                PhoneNumber = "888-595-9324",
                                Email = "MarionMcGee@buffs.wtamu.edu",
                                Role = "Sophomore",
                                TeamId = 2,
                            },   
                            
                                                 
                        };


                        //Project db

 List<Project> projects = new List<Project>()
                        {
                            new Project()
                            {
                                ProjectName = "Pink Poodle Boutique Website",
                                RequiredHours = 10,
                                Deadline = new DateTime(2019, 10, 2),
                                OrganizationId = 1,
                            },
 

                          new Project()
                            {
                                ProjectName = "The Insidious Martian Library Web App",
                                RequiredHours = 95,
                                Deadline = new DateTime(2019, 10, 22),
                                OrganizationId = 2,

                            },

                            
                          new Project()
                            {
                                ProjectName = "Frank's Bakery Online Ordering System",
                                RequiredHours = 65,
                                Deadline = new DateTime(2019, 5, 11),
                                OrganizationId = 3,

                            },
 
                            
                                                 
                        };

                       List<Organization> organizations = new List<Organization>()
                        {
                            new Organization()
                            {
                                 OrganizationId = 1,
                                 Name = "Poodles of America",

                            },
 

                            new Organization()
                            {
                                OrganizationId = 2,
                                Name = "Martian Librarians of Tevolia",


                            },

                            
                            new Organization()
                            {
                                 OrganizationId = 3,
                                 Name = "Je Veux International",

                            },

                        };

                        //Team will start here
                         List<Team> teams = new List<Team>()
                        {
                            new Team()
                            {
                                 TeamId = 1,
                                 TeamName = "Team of Awesomeness",
                                 AdvisorID = 1,

                            },
 

                             new Team()
                            {
                                 TeamId = 2,
                                 TeamName = "Team-Two Titans",
                                 AdvisorID = 2,
                            },
 
                            
                                                 
                        };
                        //Team ends here


                        //Advisor Starts here

                        List<Advisor> advisors = new List<Advisor>()
                        {
                            new Advisor()
                            {
                                FirstName = "Gandalf",
                                LastName = "McGray",
                                PhoneNumber = "206-515-0056",
                                Email = "McGray@test.com",
                                AdvisorId = 1,
                            },
                            new Advisor()
                            {
                                FirstName = "Morgan",
                                LastName = "LeFay",
                                PhoneNumber = "202-669-0010",
                                Email = "Mo@aol.com",
                                AdvisorId = 2,
                            },


                   
                        };

                        //Advisor ends here

                        //Project end db

                        db.Students.AddRange(students);  
                        db.Project.AddRange(projects);
                        db.Organizations.AddRange(organizations);
                         db.Team.AddRange(teams);
                          db.Advisor.AddRange(advisors);

                     

                        db.SaveChanges();                                              

                    }
                    else
                    {
                        var students = db.Students.ToList();
                        foreach(Student s in students)
                        {
                            Console.WriteLine(s);
                        }

                        var projects = db.Project.ToList();
                        foreach(Project p in projects)
                        {
                            Console.WriteLine(p);
                        }
                    
                     var organizations = db.Organizations.ToList();
                        foreach(Organization o in organizations)
                        {
                            Console.WriteLine(o);
                        }


                        var teams = db.Team.ToList();
                        foreach(Team t in teams)
                        {
                            Console.WriteLine(t);
                        }
                        
                        var Advisor = db.Advisor.ToList();
                        foreach(Advisor a in Advisor)
                        {
                            Console.WriteLine(a);
                        }
                    }


                }
                catch(Exception exp)
                {
                    Console.WriteLine(exp.Message);
                }

                // putting menue stuff here
                Console.WriteLine("Welcome to the Bufteks Datatbase");

                Console.WriteLine("--------------------------------------------");

                Console.WriteLine("Please select a menu option below:");
                Console.WriteLine("--------------------------------------------");

                 Console.WriteLine(
                "Commands: l (list), e (exit)");

                                Console.WriteLine("--------------------------------------------");

            {
                Console.Write("> ");
                var command = Console.ReadLine();
                switch (command)
                {
                    case "l":
                        Commands.ListAll();
                        break;
                        
                    case "e":
                        return;
                    default: 
                        Console.WriteLine("Unknown command.");
                        break;
                }

            }



                //end of menu stuff
            }
        }
    }
}

