using System;
using Dapper;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace InteractionWithDbSolutionPage93
{
    class Program
    {
        static void Main(string[] args)
        {

            OperationsUnderUsers.UpdateUser(1, "Ireland", "Wilson", "ProjectManager");
            OperationsUnderUsers.GetUsers();
        }
    }

    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Position { get; set; }
    }

    class OperationsUnderUsers
    {
        public static List<User> GetUsers()
        {
            using (SqlConnection connect = new SqlConnection())
            {
                connect.ConnectionString =
                    "Server=sql11.freesqldatabase.com;Database=sql11437128;user id=sql11437128;password=U31XlvcAsL";                
                connect.Open();
                SqlCommand alluserscommand = new SqlCommand("SELECT * FROM Users", connect);
                SqlDataReader reader = alluserscommand.ExecuteReader();
                List<User> allUsers = reader.Parse<User>().AsList();
                return allUsers;
            }            
        }
        public static void UpdateUser(int id, string country, string name, string position)
        {
            using (SqlConnection connect = new SqlConnection())
            {
                connect.ConnectionString =
                    "Server=[sql11.freesqldatabase.com];Database=[sql11437128];user id=sql11437128;password=U31XlvcAsL";
                connect.Open();
                SqlCommand insertCommand = new SqlCommand
                ("UPDATE Users SET Name = @name, Country = @country and Position = @pos Where UserId = @id", connect);

                insertCommand.Parameters.AddWithValue("@id", id);
                insertCommand.Parameters.AddWithValue("@country", country);
                insertCommand.Parameters.AddWithValue("@name", name);
                insertCommand.Parameters.AddWithValue("@pos", position);
                int result = insertCommand.ExecuteNonQuery();

                Console.WriteLine($"Changed {result} objects");
                connect.Close();
            }
        }
    }
}