using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace Budgeting_Application
{
    class Program
    {                
        static void Main(string[] args)
        {
            String connstr;
            String projectPath = @"H:\Tiedostot\GitHub Repos\ApplicationsProject\Budgeting Application";
            connstr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MyData.accdb; " + @"Data Source = " + projectPath + @"\ApplicationData\MainDB.mdf";

            OleDbConnection myConnection = new OleDbConnection();
            myConnection.ConnectionString = connstr;
            myConnection.Open();

            OleDbCommand listUsers = new OleDbCommand();
            listUsers.Connection = myConnection;
            listUsers.CommandText = "SELECT UserName FROM User";
            listUsers.CommandType = CommandType.Text;

            OleDbDataReader userReader;
            userReader = listUsers.ExecuteReader();

            bool notEoF;
            notEoF = userReader.Read();

            Console.WriteLine("Please select an user:");

            while (notEoF)
            {
                Console.WriteLine(userReader["UserName"].ToString());
                notEoF = userReader.Read();
            }

        }
    }
}
