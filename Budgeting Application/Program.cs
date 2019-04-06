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
            OleDbCommand listUsers = new OleDbCommand();
            listUsers.CommandText = "SELECT UserID, UserName FROM User";
            listUsers.CommandType = CommandType.Text;

            OleDbDataReader userReader;
            userReader = listUsers.ExecuteReader();

            bool notEoF;
            notEoF = userReader.Read();

            List<string> userList = new List<string>();
          
            while (notEoF)
            {
                userList.Add(userReader["UserName"].ToString());
                notEoF = userReader.Read();
            }

            userList.ForEach(Console.WriteLine);
        }
    }
}
