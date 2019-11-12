using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Midterm_Practical_Starter.Models
{
    public static class Repository
    {
        private static List<User> _users;
        private static List<Workshop> _workshops;
        private static List<Registration> _registrations;


        static Repository()
        {
            
            _users = new List<User>
            {
                new User {Id = 1, Email = "user1@gmail.com", Password = "user1"},
                new User {Id = 2, Email = "user2@gmail.com", Password = "user2"},
                new User {Id = 3, Email = "user3@gmail.com", Password = "user3"},
            };


            _workshops = new List<Workshop>
            {
                new Workshop {Id = 1, Title = "Introduction to Photography", Date = new DateTime(2020,1,1)},
                new Workshop {Id = 2, Title = "Outdoor Portrait Photography", Date = new DateTime(2020,2,1)},
                new Workshop {Id = 3, Title = "Lighting and Studio photography", Date = new DateTime(2020,3,1)},
            };

            _registrations = new List<Registration>
            {
                new Registration {Id = 1, UserId = 1, WorkshopId = 2},
                new Registration {Id = 2, UserId = 1, WorkshopId = 3},
            };

        }

        public static List<User> Users => _users;
        public static List<Workshop> Workshops => _workshops;
        public static List<Registration> Registrations => _registrations;

        public static IEnumerable<User> IUsers
        {
            get
            {
                return Users;
            }
        }

        public static IEnumerable<Workshop> IWorkshops
        {
            get
            {
                return Workshops;
            }
        }

        public static IEnumerable<Registration> IRegistrations
        {
            get
            {
                return Registrations;
            }
        }

        public static void AddUser(User user)
        {
            Users.Add(user);
        }


    }

}
