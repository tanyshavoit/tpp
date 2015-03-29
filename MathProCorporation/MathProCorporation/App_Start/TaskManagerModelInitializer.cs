using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using MathProCorporation.Models;

namespace MathProCorporation.TaskManagerDatabase
{
    public class TaskManagerModelInitializer : DropCreateDatabaseAlways<CompanyContext>//DropCreateDatabaseIfModelChanges<CompanyContext>
    {
        public static UserManager<ApplicationUser> UserManager { get; private set; }

        public static string Password = "1111";

        public static string Stamp = "";

        public static UserStore<ApplicationUser> Store = null;

        public static List<Employee> employees = null;

        public static List<Employee> anotherEmployees = null;

        public static List<Employee> otherEmployees = null;

        public static List<Task> tasks = null;

        protected override void Seed(CompanyContext context)
        {
            base.Seed(context);
            Store = new UserStore<ApplicationUser>(context);
            UserManager = new UserManager<ApplicationUser>(Store);
            String newPassword = "test@123";
            String hashedNewPassword = UserManager.PasswordHasher.HashPassword(newPassword);
            Password = hashedNewPassword;

            Store.Dispose();
            UserManager.Dispose();

            GetClients().ForEach(c => context.Clients.Add(c));
            GetEmployees().ForEach(c => context.Employees.Add(c));
            GetManagers().ForEach(c => context.Managers.Add(c));
            GetTeams().ForEach(c => context.Teams.Add(c));
            GetTasks().ForEach(c => context.Tasks.Add(c));
            GetProjects().ForEach(c => context.Projects.Add(c));
        }

        // Clients ids start with 101
        private static List<Employee> GetEmployees()
        {
            employees = new List<Employee>{
                new Employee{
                    EmployeeId = "101",
                    User = new ApplicationUser{
                        Id = "101",
                        UserName = "Dan",
                        FirstName = "Dan",
                        LastName = "Belei",
                        PasswordHash = Password,
                        SecurityStamp = "41fererg",
                        PhoneNumber = "+380631234567",
                        Email = "belei@mathpro.com",
                        EmailConfirmed = true,
                        Description = "SQL Guru"
                    }
                },
                new Employee{
                    EmployeeId = "102",
                    User = new ApplicationUser{
                        Id = "102",
                        UserName = "Valeriya",
                        FirstName = "Valeriya",
                        LastName = "Avramenko",
                        PasswordHash = Password,
                        SecurityStamp = "41fererg",
                        PhoneNumber = "+380631234567",
                        Email = "avramenko@mathpro.com",
                        EmailConfirmed = true,
                        Description = "Senior Java developer"
                    }
                },
                new Employee{
                    EmployeeId = "103",
                    User = new ApplicationUser{
                        Id = "103",
                        UserName = "Illya",
                        FirstName = "Illya",
                        LastName = "Bakurov",
                        PasswordHash = Password,
                        SecurityStamp = "41fererg",
                        PhoneNumber = "+380631234567",
                        Email = "bakurov@mathpro.com",
                        EmailConfirmed = true,
                        Description = "Senior iOS developer"
                    }
                }
            };

            anotherEmployees = new List<Employee>{
                new Employee{
                    EmployeeId = "104",
                    User = new ApplicationUser{
                        Id = "104",
                        UserName = "Yaroslava",
                        FirstName = "Yaroslava",
                        LastName = "Girilishena",
                        PasswordHash = Password,
                        SecurityStamp = "41fererg",
                        PhoneNumber = "+380631234567",
                        Email = "girilishena@mathpro.com",
                        EmailConfirmed = true,
                        Description = "Junior iOS developer"
                    }
                },

                new Employee{
                    EmployeeId = "105",
                    User = new ApplicationUser{
                        Id = "105",
                        UserName = "Yaroslav",
                        FirstName = "Yaroslav",
                        LastName = "Kaplunskiy",
                        PasswordHash = Password,
                        SecurityStamp = "41fererg",
                        PhoneNumber = "+380631234567",
                        Email = "kaplunskiy@mathpro.com",
                        EmailConfirmed = true,
                        Description = "Senior Java developer"
                    }
                },

                new Employee{
                    EmployeeId = "106",
                    User = new ApplicationUser{
                        Id = "106",
                        UserName = "Taras",
                        FirstName = "Taras",
                        LastName = "Lehynevich",
                        PasswordHash = Password,
                        SecurityStamp = "41fererg",
                        PhoneNumber = "+380631234567",
                        Email = "lehynevich@mathpro.com",
                        EmailConfirmed = true,
                        Description = "Senior developer"
                    }
                },

                new Employee{
                    EmployeeId = "107",
                    User = new ApplicationUser{
                        Id = "107",
                        UserName = "Bogdan",
                        FirstName = "Bogdan",
                        LastName = "Kylinich",
                        PasswordHash = Password,
                        SecurityStamp = "41fererg",
                        PhoneNumber = "+380631234567",
                        Email = "kylinich@mathpro.com",
                        EmailConfirmed = true,
                        Description = "Senior Python developer"
                    }
                },

                new Employee{
                    EmployeeId = "108",
                    User = new ApplicationUser{
                        Id = "108",
                        UserName = "Tatiana",
                        FirstName = "Tatiana",
                        LastName = "Voytovich",
                        PasswordHash = Password,
                        SecurityStamp = "41fererg",
                        PhoneNumber = "+380631234567",
                        Email = "voytovich@mathpro.com",
                        EmailConfirmed = true,
                        Description = "Top Tester"
                    }
                },

                new Employee{
                    EmployeeId = "109",
                    User = new ApplicationUser{
                        Id = "109",
                        UserName = "Victoria",
                        FirstName = "Victoria",
                        LastName = "Konup",
                        PasswordHash = Password,
                        SecurityStamp = "41fererg",
                        PhoneNumber = "+380631234567",
                        Email = "konup@mathpro.com",
                        EmailConfirmed = true,
                        Description = "Web Designer"
                    }
                }
            };

            var fullEmployeeList = new List<Employee>();
            employees.ForEach(e => fullEmployeeList.Add(e));
            anotherEmployees.ForEach(e => fullEmployeeList.Add(e));

            return fullEmployeeList.ToList();
        }

        private static List<Manager> GetManagers()
        {
            var managers = new List<Manager>
            {
                new Manager{
                    ManagerId = "2",
                    User = new ApplicationUser{
                        Id = "2",
                        UserName = "Anton",
                        FirstName = "Anton",
                        LastName = "Morozov",
                        PasswordHash = Password,
                        SecurityStamp = "41fererg",
                        PhoneNumber = "+380631234567",
                        Email = "morozov@mathpro.com",
                        EmailConfirmed = true,
                        Description = "Top Manager"
                    }
                }
            };
            return managers;
        }

        // Clients ids start with 1001
        private static List<Client> GetClients()
        {
            var clients = new List<Client>{
                 new Client{
                    ClientId = "1001",
                    User = new ApplicationUser{
                        Id = "1001",
                        UserName = "Roman",
                        FirstName = "Roman",
                        LastName = "Minenko",
                        PasswordHash = Password,
                        SecurityStamp = "41fererg",
                        PhoneNumber = "0631234567",
                        Email = "minenko@gmail.com",
                        EmailConfirmed = true,
                        Description = "Client"
                    }
                },
                new Client{
                    ClientId = "1002",
                    User = new ApplicationUser{
                        Id = "1002",
                        UserName = "Anna",
                        FirstName = "Anna",
                        LastName = "Kolyuka",
                        PasswordHash = Password,
                        SecurityStamp = "41fererg",
                        PhoneNumber = "0631234567",
                        Email = "kolyuka@gmail.com",
                        EmailConfirmed = true,
                        Description = "Client"
                    }
                },
                new Client{
                    ClientId = "1003",
                    User = new ApplicationUser{
                        Id = "1003",
                        UserName = "Yuriy",
                        FirstName = "Yuriy",
                        LastName = "Mytnyk",
                        PasswordHash = Password,
                        SecurityStamp = "41fererg",
                        PhoneNumber = "0631234567",
                        Email = "mytnyk@gmail.com",
                        EmailConfirmed = true,
                        Description = "Client"
                    }
                },
                new Client{
                    ClientId = "1004",
                    User = new ApplicationUser{
                        Id = "1004",
                        UserName = "Ruslan",
                        FirstName = "Ruslan",
                        LastName = "Chornei",
                        PasswordHash = Password,
                        SecurityStamp = "41fererg",
                        PhoneNumber = "0631234567",
                        Email = "chorneirk@gmail.com",
                        EmailConfirmed = true,
                        Description = "Client"
                    }
                }
            };
            return clients;
        }

        private static List<Team> GetTeams()
        {
            var teams = new List<Team>
            {
                new Team{
                    TeamId = "1",
                    ManagerId = "2",
                    Employees = employees
                },
                new Team{
                    TeamId = "2",
                    ManagerId = "2",
                    Employees = anotherEmployees
                }
            };
            return teams;
        }

        private static List<Task> GetTasks()
        {
            tasks = new List<Task>
            {
                new Task{
                    TaskId = "1",
                    Name = "t100001",
                    Description = "Task description goes here",
                    Status = "OPENED",
                    Deadline = new DateTime(2014, 05, 25),
                    StartDate = DateTime.Now,
                    EndDate = DateTime.MaxValue,
                    EmployeeId = "101"
                },
                new Task{
                    TaskId = "2",
                    Name = "t100002",
                    Description = "Task description goes here",
                    Status = "CLOSED",
                    Deadline = new DateTime(2014, 05, 25),
                    StartDate = DateTime.Now,
                    EndDate = DateTime.MaxValue,
                    EmployeeId = "106"
                },
                new Task{
                    TaskId = "3",
                    Name = "t100004",
                    Description = "Task description goes here",
                    Status = "OPENED",
                    Deadline = new DateTime(2015, 03, 25),
                    StartDate = DateTime.Now,
                    EndDate = DateTime.MaxValue,
                    EmployeeId = "104"
                },
            };
            return tasks;
        }

        private static List<Project> GetProjects()
        {
            var projects = new List<Project>
            {
                new Project{
                    ProjectId = "1",
                    ClientId = "1003",
                    ManagerId = "2",
                    TeamId = "1",
                    Tasks = tasks,
                    Name = "Trip Advisor",
                    Status = "OPENED",
                    Description = "Reccomendations and ratings for all kinds of resorts",
                    Deadline = new DateTime(2015, 04, 25),
                    StartDate = DateTime.Now,
                    EndDate = new DateTime(2015, 06, 25),
                },
                new Project{
                    ProjectId = "2",
                    ClientId = "1001",
                    ManagerId = "2",
                    TeamId = "2",
                    Tasks = null,
                    Name = "Barcode scanner",
                    Status = "OPENED",
                    Description = "Mobile application - scan and search products",
                    Deadline = new DateTime(2015, 04, 12),
                    StartDate = new DateTime(2015, 03, 28),
                    EndDate = new DateTime(2015, 04, 12),
                },
                new Project{
                    ProjectId = "3",
                    ClientId = "1002",
                    ManagerId = "2",
                    TeamId = "2",
                    Tasks = null,
                    Name = "Privat24/7",
                    Status = "OPENED",
                    Description = "Mobile bank accounts manager",
                    Deadline = new DateTime(2015, 08, 10),
                    StartDate = new DateTime(2015, 02, 28),
                    EndDate = new DateTime(2015, 08, 10),
                }
            };
            return projects;
        }
    }
}