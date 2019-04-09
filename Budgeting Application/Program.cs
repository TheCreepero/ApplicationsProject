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

            string listUsers = "SELECT UserName, UserID FROM [User]";

            startup.DataReader(listUsers);

            DataTable users = new DataTable();

            users = startup.ShowDataInGridView(listUsers);
            Console.ReadLine();

            startup.CloseConnection();
        }
    }
}
