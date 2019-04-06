using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Configuration;

namespace Budgeting_Application
{
    public abstract class User
    {
        protected int UserID;
        protected string UserName;  
        protected string UserLvl;
        protected float BankAccountBalance;
        
        public void createReport()
        {

        }
        /*
        public User GetUsers()
        {
            OleDbCommand listUsers = new OleDbCommand();
            listUsers.CommandText = "SELECT UserID, UserName, UserLvl, BankAccountBalance FROM User";
            listUsers.CommandType = CommandType.Text;

            OleDbDataReader userReader;
            userReader = listUsers.ExecuteReader();

            bool notEoF;
            notEoF = userReader.Read();

            List<User> users = new List<User>();
            
            int i = 0;

            while (notEoF)
            {
                users.Add(new User())
                i++;
                notEoF = userReader.Read();
            }
        }
        */
    }
}
