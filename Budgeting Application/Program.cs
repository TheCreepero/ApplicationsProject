using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Budgeting_Application
{
    class Program
    {                
        static void Main(string[] args)
        {
            DbConnection startup = new DbConnection();
            startup.OpenConnection();


            SqlCommand listUsers = new SqlCommand("SELECT UserName from [User];");
            SqlDataReader reader = startup.DataReader(listUsers.ToString());

            while(reader.Read())
            {
                Console.WriteLine(reader.ToString());
            }
            reader.Close();

            Console.ReadLine();
        }
    }
}
