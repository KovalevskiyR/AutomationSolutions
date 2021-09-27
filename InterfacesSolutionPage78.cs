using System;
using System.Collections.Generic;

namespace InterfacesSolutionPage78
{   
    interface IUser
    {
        string Status { get; set; }
        int Balance { get; set; }
        string GetBalanceData();
    }

    class RegularUser : IUser
    {

        public RegularUser (string status, int balance)
        {
            Status = status;
            Balance = balance;
        }

        public string Status { get; set; }
        public int Balance { get; set; }

        public virtual string GetBalanceData()
        {
            return $"Balance regular is: {Balance}";
        }
    }

    class PremiumUser : RegularUser
    {
        public PremiumUser(string status, int balance) : base(status, balance)
        {
            Balance =+ BonusBalance;
        }

        public int BonusBalance = 250;
        public override string GetBalanceData()
        {
            return $"Balance premium is: {Balance + BonusBalance}";         
        }
    }
    class Program
    {
        private static void ShowUsersBalance(List<IUser> users)
        {
            foreach (var user in users)
            {
                Console.WriteLine(user.GetBalanceData());
            }
        }
        static void Main(string[] args)
        {
            RegularUser user1 = new RegularUser("regular", 250);

            PremiumUser user2 = new PremiumUser("premium", 250);          

            List<IUser> users = new List<IUser>()
            {
                user1,
                user2
            };

            ShowUsersBalance(users);          
        }
    }
}
