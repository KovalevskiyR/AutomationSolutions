using System;
using System.Collections.Generic;

namespace MethodOverloadingPage63
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

        private string GetRole(string Role)
        {
            this.Role = _role;
            return Role;
        }

        public string GetLogin()
        {
            return Login;         
        }

        public string GetPassword()
        {
            return Password;
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

            User User1 = new User("adminadmin1", "qwer", admin_role);
            Console.WriteLine(User1.GetLogin());
            Console.WriteLine(User1.GetPassword());            
            Console.WriteLine();

            User User2 = new User("qwerqeqe12", "password1", null);
            Console.WriteLine(User2.GetLogin());
            Console.WriteLine(User2.GetPassword());
            Console.WriteLine();


            ForumUser FUser1 = new ForumUser("login112323", "password33", "developer");
            FUser1.CreateMessage();        
            Console.WriteLine();

            User User3 = new User("login222323", "password222", "ba");           
            FUser1.CreateMessage("Nature", "Beneath a tiger's fur, the animal's skin is striped as well." +
                                           "Although shaving a tiger is not recommended, if you were to do so," +
                                           "you would see dark and light stripes in the same pattern as its fur.");
        }
    }
}
