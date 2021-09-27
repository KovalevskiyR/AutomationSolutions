using System;
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

    class OperationsUnderUsers
    {
        public static void GetUsers()
        {
            using (SqlConnection connect = new SqlConnection())
            {
                connect.ConnectionString =
                    "Server=sql11.freesqldatabase.com;Database=sql11437128;user id=sql11437128;password=U31XlvcAsL";
                connect.Open();
                SqlCommand getAllUsers = new SqlCommand("SELECT * FROM Users", connect);
                getAllUsers.ExecuteNonQuery();
                connect.Close();
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
                
                insertCommand.ExecuteNonQuery();
                connect.Close();
            }      
        }       
    }
}