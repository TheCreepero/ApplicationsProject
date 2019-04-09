using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace Budgeting_Application
{
    class Program:System.Windows.Forms.Form
    {
        Program()
        {
            InitializeComponent();
        }

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new Program());
            /*
            DbConnection startup = new DbConnection();
            startup.OpenConnection();

            string listUsers = "SELECT UserName, UserID FROM [User]";

            startup.DataReader(listUsers);

            DataTable users = new DataTable();

            startup.ShowDataInGridView(listUsers);

            startup.CloseConnection();
            */
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Program
            // 
            this.ClientSize = new System.Drawing.Size(335, 444);
            this.Name = "Program";
            this.ResumeLayout(false);

        }
    }
}
