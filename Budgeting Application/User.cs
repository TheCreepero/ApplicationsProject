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
        
    }
}
