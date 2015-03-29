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

        public static List<Task> tasks = null;

        protected override void Seed(CompanyContext context)
        {
            base.Seed(context);
            Store = new UserStore<ApplicationUser>(context);
            UserManager = new UserManager<ApplicationUser>(Store);
            String newPassword = "1111";
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

        //TODO write tasks to employees
        //TODO write projects and tasks end teams to manager ... etc

        private static List<Employee> GetEmployees()
        {
            employees = new List<Employee>{
                new Employee{
                    EmployeeId = "1",
                    User = new ApplicationUser{
                        Id = "1",
                        UserName = "yaroslava",
                        FirstName = "Yaroslava",
                        LastName = "Girilishena",
                        PasswordHash = Password,
                        SecurityStamp = "41fererg",
                        PhoneNumber = "+380631234567",
                        Email = "girilishena@math.com",
                        EmailConfirmed = true,
                        Description = "Main Client"
                    }
                },
                new Employee{
                    EmployeeId = "4",
                    User = new ApplicationUser{
                        Id = "4",
                        UserName = "taras",
                        FirstName = "Taras",
                        LastName = "Lehinevych",
                        PasswordHash = Password,
                        SecurityStamp = "41fererg",
                        PhoneNumber = "+380631234567",
                        Email = "lehinevych@math.com",
                        EmailConfirmed = true,
                        Description = "Employee"
                    }
                }
            };

            anotherEmployees = new List<Employee>{
                new Employee{
                    EmployeeId = "7",
                    User = new ApplicationUser{
                        Id = "7",
                        UserName = "bogdan",
                        FirstName = "Bogdan",
                        LastName = "Kulynych",
                        PasswordHash = Password,
                        SecurityStamp = "41fererg",
                        PhoneNumber = "+380631234567",
                        Email = "kulynych@math.com",
                        EmailConfirmed = true,
                        Description = "Client"
                    }
                },
                new Employee{
                    EmployeeId = "10",
                    User = new ApplicationUser{
                        Id = "10",
                        UserName = "illya",
                        FirstName = "Illya",
                        LastName = "Bakurov",
                        PasswordHash = Password,
                        SecurityStamp = "41fererg",
                        PhoneNumber = "+380631234567",
                        Email = "bakurov@math.com",
                        EmailConfirmed = true,
                        Description = "Employee"
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
                        UserName = "yaroslav",
                        FirstName = "Yaroslav",
                        LastName = "Kaplunskij",
                        PasswordHash = Password,
                        SecurityStamp = "41fererg",
                        PhoneNumber = "+380631234567",
                        Email = "kaplunskij@math.com",
                        EmailConfirmed = true,
                        Description = "Super Msanager"
                    }
                }
            };
            return managers;
        }

        private static List<Client> GetClients()
        {
            var clients = new List<Client>{
                new Client{
                    ClientId = "3",
                    User = new ApplicationUser{
                        Id = "3",
                        UserName = "victoria",
                        FirstName = "Victoria",
                        LastName = "Konup",
                        PasswordHash = Password,
                        SecurityStamp = "41fererg",
                        PhoneNumber = "+380631234567",
                        Email = "konup@math.com",
                        EmailConfirmed = true,
                        Description = "Client",
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
                    Name = "Task1",
                    Description = "Bla bla",
                    Status = "OPENED",
                    Deadline = new DateTime(2015, 03, 25),
                    StartDate = DateTime.Now,
                    EndDate = DateTime.MaxValue,
                    EmployeeId = "1"
                },
                new Task{
                    TaskId = "2",
                    Name = "Write some ASP.NET Controller!",
                    Description = "Do it right NOW !!!",
                    Status = "CLOSED",
                    Deadline = new DateTime(2015, 03, 29),
                    StartDate = DateTime.Now,
                    EndDate = DateTime.MaxValue,
                    EmployeeId = "1"
                },
                new Task{
                    TaskId = "3",
                    Name = "Do practice 9 and 10",
                    Description = "The last chance",
                    Status = "OPENED",
                    Deadline = new DateTime(2015, 03, 31),
                    StartDate = DateTime.Now,
                    EndDate = DateTime.MaxValue,
                    EmployeeId = "4"
                },
            };
            return tasks;
        }

        // TODO set project
        private static List<Project> GetProjects()
        {
            var projects = new List<Project>
            {
                new Project{
                    ProjectId = "1",
                    ClientId = "3",
                    ManagerId = "2",
                    TeamId = "1",
                    Tasks = tasks,
                    Name = "Prototype",
                    Status = "OPENED",
                    Description = "We are going to do cool project!",
                    Deadline = new DateTime(2015, 03, 20),
                    StartDate = DateTime.Now,
                    EndDate = DateTime.MaxValue,
                }
            };
            return projects;
        }
    }
}