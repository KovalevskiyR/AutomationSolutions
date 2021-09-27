using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace LINQPage70
{
    public class User
    {
        private string _login;

        public string Login
        {
            get
            {
                return _login;
            }
            set
            {
                if (value.Length < 10)
                {
                    Console.Write("Login can not be less than 10 symbols");

                }
                else
                {
                    _login = value;
                }
            }
        }

        public string Password;
        public string Country { get; set; }
        public string ZipCode { get; set; }

        private string _role;

        public string Role
        {
            get
            {
                return _role;
            }
            set
            {
                if (string.IsNullOrEmpty(value) | string.IsNullOrWhiteSpace(value))
                {
                    _role = "Unknown";

                }
                else
                {
                    _role = value;
                }
            }
        }

        public User(string login, string password, string role)
        {
            Login = login;
            Password = password;
            Role = role;
        }

        public enum UserRole
        {
            Admin,
            SalesManager,
            Customer,
        }

        private void GetRole(string Role)
        {
            this.Role = _role;
            Console.WriteLine(Role);
        }

        public void GetLogin()
        {
            Console.WriteLine(Login);
        }

        public void GetPassword()
        {
            Console.WriteLine(Password);
        }
        public static void GetUserName(string UserName)
        {
            Console.WriteLine($"User name is: {UserName}");
        }

        public static void GetUserRole(string UserRole)
        {
            Console.WriteLine($"User role is: {UserRole}");
        }
    }
    public class ForumUser : User
    {
        public ForumUser(string login, string password, string role) : base(login, password, role)
        {

        }
        public void CreateMessage()
        {
            Console.WriteLine("Some Message");
        }
        public void CreateMessage(string theme, string message)
        {
            Console.WriteLine($"\"Theme: {theme}\"");
            Console.WriteLine($"\"Message: {message}\"");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string admin_role = Enum.GetName(typeof(User.UserRole), 0);
            string sales_manager_role = Enum.GetName(typeof(User.UserRole), 1);

            List<User> userList = new List<User>()
            {
            new User("xforesttxx", "qrwet242", admin_role),
            new User("Aonnie12333", "password23", "user"),
            new User("abysqweqwe", "password33", admin_role)
            };


            var adminUsers = userList.Where(u => u.Role.Contains("admin"));  //*Users with Admin role*//*  

            var orderedUsers = userList.OrderBy(u => u.Login);               //*Order by Login*//*

            var userwithA = userList.Where(u => u.Login.ToUpper().StartsWith("A"));     //*Login starts with A*//*

            foreach (var user in orderedUsers)
                Console.WriteLine(user.Login);
            
        }
    }
}
