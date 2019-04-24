using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace Budgeting_Application
{
    class Program:System.Windows.Forms.Form
    {
        private Button button1;
        private Button exit;
        private Label label1;

        const string admin = "admin";
        const string parent = "parent";
        const string child = "child";
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn userNameColumn;
        private DataGridViewTextBoxColumn UserLvlColumn;
        private BindingSource mainDBDataSetBindingSource;
        private System.ComponentModel.IContainer components;
        private ApplicationData.MainDBDataSet mainDBDataSet;
        private BindingSource mainDBDataSetBindingSource1;
        private System.IO.Ports.SerialPort serialPort1;
        public static object selectedUserName;


        Program()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new Program());
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserLvlColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainDBDataSet = new Budgeting_Application.ApplicationData.MainDBDataSet();
            this.mainDBDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDBDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lavender;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(100, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Open Application";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Lavender;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(100, 232);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(160, 27);
            this.exit.TabIndex = 3;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select the user from the list:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 18;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userNameColumn,
            this.UserLvlColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(64, 32);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(229, 121);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
            // 
            // userNameColumn
            // 
            this.userNameColumn.HeaderText = "Username";
            this.userNameColumn.Name = "userNameColumn";
            this.userNameColumn.ReadOnly = true;
            // 
            // UserLvlColumn
            // 
            this.UserLvlColumn.HeaderText = "User Level";
            this.UserLvlColumn.Name = "UserLvlColumn";
            this.UserLvlColumn.ReadOnly = true;
            // 
            // mainDBDataSetBindingSource
            // 
            this.mainDBDataSetBindingSource.DataSource = this.mainDBDataSet;
            this.mainDBDataSetBindingSource.Position = 0;
            // 
            // mainDBDataSet
            // 
            this.mainDBDataSet.DataSetName = "MainDBDataSet";
            this.mainDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mainDBDataSetBindingSource1
            // 
            this.mainDBDataSetBindingSource1.DataSource = this.mainDBDataSet;
            this.mainDBDataSetBindingSource1.Position = 0;
            // 
            // Program
            // 
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(364, 306);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name = "Program";
            this.Text = "Budgeting Application - User Selection";
            this.Load += new System.EventHandler(this.Program_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDBDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void LoadUsers()
        {
            DbConnection listUsersButton = new DbConnection();
            string listUsers = "SELECT UserID, UserName, UserLvl FROM [User]";

            try
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();

                listUsersButton.OpenConnection();
                dr = listUsersButton.DataReader(listUsers);
                while (dr.Read())
                {
                    dataGridView1.Rows.Add(dr["UserName"].ToString(), dr["UserLvl"].ToString());
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


        SqlDataReader dr;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                

                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    if (row.Cells[1].Value.ToString() == admin)
                    {
                        //This makes sure the name of the user is transferred to the new form.
                        selectedUserName = row.Cells[0].Value;
                        //Opens the new form
                        mainmenuAdmin mainmenuAdmin = new mainmenuAdmin();
                        mainmenuAdmin.ShowDialog(); 
                    }

                    if (row.Cells[1].Value.ToString() == parent)
                    {
                        selectedUserName = row.Cells[0].Value;
                        mainmenuParent mainmenuParent = new mainmenuParent();
                        mainmenuParent.ShowDialog();                       
                    }

                    if (row.Cells[1].Value.ToString() == child)
                    {
                        selectedUserName = row.Cells[0].Value;
                        mainmenuChild mainmenuChild = new mainmenuChild();
                        mainmenuChild.ShowDialog();                        
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
            }           
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Program_Load(object sender, EventArgs e)
        {

        }

        private void userLvlList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                selectedUserName = row.Cells[0].Value;
            }
        }
    }
}
