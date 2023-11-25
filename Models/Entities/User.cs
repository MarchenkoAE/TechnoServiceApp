using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnoServiceApp;

namespace TechnoServiceApp.Models.Entities
{
    internal class User
    {
        int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int UserRoleId { get; set; }

        public User(int id, string name, string email, string login, string password, int userRoleId)
        {
            Id = id;
            Name = name;
            Email = email;
            Login = login;
            Password = password;
            UserRoleId = userRoleId;
        }
    }
}
