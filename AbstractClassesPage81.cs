using System;
using System.Collections.Generic;

namespace AbstractClassesPage81
{
    abstract class User
    {
        public string Status { get; set; }
        public int Balance { get; set; }
        
        public User (string status, int balance)
        {
            Status = status;
            Balance = balance;
        }
        public abstract string GetBalanceData();

        public void ResetBalance()
        {
            Balance = 0;
        }
    }

    class RegularUser : User
    {     
        public RegularUser (string status, int balance) : base (status, balance)
        {         
        }
        public override string GetBalanceData()
        {
            return $"Balance regular is: {Balance}";
        }
    }

    class PremiumUser : User
    {
        public int BonusBalance { get; set; }
        public PremiumUser (int bonusbalance, string status , int balance) : base (status, balance)
        {
            BonusBalance = bonusbalance;
            Balance += BonusBalance;
        }
        public override string GetBalanceData()
        {
            return $"Balance premium is: {Balance}";
        }
    }

    class Program
    {
        private static void ShowUsersBalance(List<User> users)
        {
            foreach (var user in users)
            {
                Console.WriteLine(user.GetBalanceData());
            };
        }

        static void Main(string[] args)
        {
            RegularUser user1 = new RegularUser("regular", 300);
            PremiumUser user2 = new PremiumUser(250, "premium", 250);
            User user3 = new RegularUser("regular", 350);
            User user4 = new PremiumUser(250, "qwer", 350);
   
            List<User> users = new List<User>()
            {
                user1,
                user2,
                user3,
                user4,              
            };
            ShowUsersBalance(users);
            Console.WriteLine();

            user1.ResetBalance();
            user2.ResetBalance();

            ShowUsersBalance(users);
        }
    }
}
