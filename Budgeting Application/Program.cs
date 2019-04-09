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
        private Button button1;
        private Button exit;
        private Label label1;
        private Button getUserList;

        public static string selectedUser;

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
            this.getUserList = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userList
            // 
            this.userList.FormattingEnabled = true;
            this.userList.Location = new System.Drawing.Point(12, 39);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(160, 121);
            this.userList.TabIndex = 0;
            this.userList.SelectedIndexChanged += new System.EventHandler(this.userList_SelectedIndexChanged);
            // 
            // getUserList
            // 
            this.getUserList.Location = new System.Drawing.Point(12, 166);
            this.getUserList.Name = "getUserList";
            this.getUserList.Size = new System.Drawing.Size(160, 27);
            this.getUserList.TabIndex = 1;
            this.getUserList.Text = "List Users";
            this.getUserList.UseVisualStyleBackColor = true;
            this.getUserList.Click += new System.EventHandler(this.selectUser_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Open Application";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(12, 232);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(160, 27);
            this.exit.TabIndex = 3;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select the user from the list:";
            // 
            // Program
            // 
            this.ClientSize = new System.Drawing.Size(184, 269);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.getUserList);
            this.Controls.Add(this.userList);
            this.Name = "Program";
            this.Load += new System.EventHandler(this.Program_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void userList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedUser = userList.SelectedItem.ToString();
        }

        private void selectUser_Click(object sender, EventArgs e)
        {
            DbConnection listUsersButton = new DbConnection();
            string listUsers = "SELECT UserID, UserName, UserLvl FROM [User]";

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

        private void button1_Click(object sender, EventArgs e)
        {
            Form mainmenu = new Form();
            mainmenu.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Program_Load(object sender, EventArgs e)
        {

        }
    }
}
