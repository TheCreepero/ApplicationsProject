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
        private ListBox userList;
        private Button selectUser;

        Program()
        {
            InitializeComponent();
        }

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new Program());

        }

        private void InitializeComponent()
        {
            this.userList = new System.Windows.Forms.ListBox();
            this.selectUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userList
            // 
            this.userList.FormattingEnabled = true;
            this.userList.Location = new System.Drawing.Point(12, 12);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(311, 121);
            this.userList.TabIndex = 0;
            this.userList.SelectedIndexChanged += new System.EventHandler(this.userList_SelectedIndexChanged);
            // 
            // selectUser
            // 
            this.selectUser.Location = new System.Drawing.Point(12, 150);
            this.selectUser.Name = "selectUser";
            this.selectUser.Size = new System.Drawing.Size(157, 61);
            this.selectUser.TabIndex = 1;
            this.selectUser.Text = "Select User";
            this.selectUser.UseVisualStyleBackColor = true;
            this.selectUser.Click += new System.EventHandler(this.selectUser_Click);
            // 
            // Program
            // 
            this.ClientSize = new System.Drawing.Size(335, 444);
            this.Controls.Add(this.selectUser);
            this.Controls.Add(this.userList);
            this.Name = "Program";
            this.ResumeLayout(false);

        }

        private void userList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void selectUser_Click(object sender, EventArgs e)
        {
            DbConnection listUsersButton = new DbConnection();
            string listUsers = "SELECT UserName FROM [User]";

            try
            {
                listUsersButton.OpenConnection();

                SqlDataReader dr = listUsersButton.DataReader(listUsers);

                while (dr.Read())
                {
                    userList.Items.Add(dr["UserName"].ToString());
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                listUsersButton.CloseConnection();
            }
        }
    }
}
