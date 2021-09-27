using System;
using System.Collections.Generic;

namespace AccessModifiersPage61
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
    }

    class Program
    {
        static void Main(string[] args)
        {
            string admin_role = Enum.GetName(typeof(User.UserRole), 0);
            string sales_manager_role = Enum.GetName(typeof(User.UserRole), 1);

            User User1 = new User("adminadmin1", "qwer", admin_role);
            User1.GetLogin();
            User1.GetPassword();
            User1.GetRole("BA");
            Console.WriteLine();

            User User2 = new User("qwerqlogin23", "password1", null);
            User2.GetLogin();
            User2.GetPassword();
            User2.GetRole("PM");
            Console.WriteLine();

            List<string> users = new List<string>
            { "User1", "User2", "User3" };

            Console.WriteLine(users.Count);
            users.RemoveRange(0, 3);
            Console.WriteLine(users.Count);

            ForumUser FUser1 = new ForumUser("login111313", "password33", "developer");
            FUser1.CreateMessage();
            FUser1.GetRole("QA");
           
        }
    }
}
