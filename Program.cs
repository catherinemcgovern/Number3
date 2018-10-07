using System.Collections;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System;

namespace Buffteks
{
     class Program
    {
        static void Main(string[] args)
        {
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
                                Role = "Senior"
                            },
                            new Student()
                            {
                                FirstName = "Joe",
                                LastName = "Smith",
                                PhoneNumber = "456-684-4684",
                                Email = "fun@aol.com",
                                Role = "Sophomore"
                            },
                            new Student()
                            {
                                FirstName = "Jane",
                                LastName = "Doe",
                                PhoneNumber = "123-555-1234",
                                Email = "janestudent@buffs.wtamu.edu",
                                Role = "Freshman"
                            },  

                            new Student()
                            {
                                FirstName = "Marion",
                                LastName = "McGovern",
                                PhoneNumber = "888-595-9324",
                                Email = "MarionMcGee@buffs.wtamu.edu",
                                Role = "Sophomore"
                            },   
                            
                                                 
                        };


                        //Project db

 List<Project> projects = new List<Project>()
                        {
                            new Project()
                            {
                                ProjectName = "Pink Poodle Boutique",
                                RequiredHours = 10,
                                Deadline = new DateTime(1999, 7, 8),
                            },
 
                            
                                                 
                        };

                        //Project end db

                        db.Students.AddRange(students);  

                        db.SaveChanges();                                              

                    }
                    else
                    {
                        var students = db.Students.ToList();
                        foreach(Student s in students)
                        {
                            Console.WriteLine(s);
                        }
                    }


                }
                catch(Exception exp)
                {
                    Console.WriteLine(exp.Message);
                }

                
            }
        }
    }
}
