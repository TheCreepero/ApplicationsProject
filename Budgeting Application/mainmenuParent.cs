﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Budgeting_Application
{
    public partial class mainmenuParent : Form
    {
        SqlDataReader dr;
        SqlDataReader dr2;
        SqlDataReader dr3;
        SqlDataReader dr4;
        SqlDataReader dr5;
        int oldRowCount;
        string welcomeLabel = "Welcome, " + Convert.ToString(Program.selectedUserName) + "!";

        public mainmenuParent()
        {
            InitializeComponent();
            label1.Text = welcomeLabel;
            BindData();
            comboBox2.Items.Add("All");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        DataTable eventTable = new DataTable();

        public void BindData()
        {
            DbConnection comboBoxUsers = new DbConnection();
            string listAccounts = "SELECT AccountName FROM [Account]";
            string listUsers = "SELECT UserName FROM [User]";
            try
            {
                comboBoxUsers.OpenConnection();
                dr = comboBoxUsers.DataReader(listAccounts);
                while (dr.Read())
                {
                    string accounts = dr["AccountName"].ToString();
                    this.comboBox1.Items.Add(accounts);
                    filterCategoryCB.Items.Add(accounts);

                }
                //"Resets" the connection
                comboBoxUsers.CloseConnection();
                comboBoxUsers.OpenConnection();

                dr2 = comboBoxUsers.DataReader(listUsers);
                while (dr2.Read())
                {
                    string users = dr2["UserName"].ToString();
                    this.comboBox2.Items.Add(users);
                    comboBox3.Items.Add(users);
                    comboBox4.Items.Add(users);
                    filterOwnerCB.Items.Add(users);
                }               
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                comboBoxUsers.CloseConnection();
            }
        }

        private void fetchTransactions_Click(object sender, EventArgs e)
        {
            //This clears any existing records from the DataGrid before new data is loaded in
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            //This takes the transaction data from the DB and displays it in dataGridView1
            DbConnection fetchTransactions = new DbConnection();
            string selectTransactions = "SELECT * FROM [Transaction] WHERE PayerName = '" + comboBox2.SelectedItem.ToString() + "'";

            //This "if" structure is needed for the selection of all transactions
            string userSelection = comboBox2.SelectedItem.ToString();            
            if (userSelection == "All")
            {
                selectTransactions = "SELECT * FROM [Transaction]";
            }

            //Transactions are loaded
            try
            {
                fetchTransactions.OpenConnection();
                dr = fetchTransactions.DataReader(selectTransactions);
                while (dr.Read())
                {
                    dataGridView1.Rows.Add(dr["Amount"].ToString(), dr["AccountName"].ToString(), dr["PayerName"].ToString(), dr["OwnerName"].ToString(), dr["Date"].ToString(), dr["Receiver"].ToString(), dr["ProductName"].ToString(), dr["Description"].ToString(), dr["EventID"].ToString());
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fetchTransactions.CloseConnection();
                oldRowCount = dataGridView1.Rows.Count;
            }

            //This counts the sum of all transactions and shows it in a label below the DataGrid
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
            }
         
            balanceLabel.Text = sum.ToString() + '€';
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveChanges_Click(object sender, EventArgs e) 
        {

        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addEvent_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddEvent_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = Convert.ToDateTime(dateTimePicker1.Text);

            //The date function doesn't work!
            dataGridView1.Rows.Add(textBox1.Text, comboBox1.Text, comboBox3.Text, comboBox4.Text, DateTime.Today, textBox2.Text, textBox3.Text, textBox4.Text);
            string insertChanges = "INSERT INTO [Transaction] VALUES ('" + textBox1.Text + "', '" + comboBox1.Text + "', '" + comboBox3.Text + "', '" + comboBox4.Text + "', '" + DateTime.Today + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "')";
            DbConnection insertToDb = new DbConnection();

            try
            {
                insertToDb.OpenConnection();
                insertToDb.ExcecuteQueries(insertChanges);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dataGridView1.Refresh();
                insertToDb.CloseConnection();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mainmenuParent_Load(object sender, EventArgs e)
        {
            eventTable.Columns.Add("Amount", typeof(float));
            eventTable.Columns.Add("Account Name", typeof(string));
            eventTable.Columns.Add("Payer Name", typeof(string));
            eventTable.Columns.Add("Purchase Owner", typeof(string));
            eventTable.Columns.Add("Date", typeof(DateTime));
            eventTable.Columns.Add("Receiver", typeof(string));
            eventTable.Columns.Add("Product Name", typeof(string));
            eventTable.Columns.Add("Description", typeof(string));
            //filterCategoryCB.SelectedItem = null;
        }

        private void balanceLabel_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {            
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                int rowIdToDelete = Convert.ToInt32(row.Cells["EventID"].Value);
                string removeSelected = "DELETE FROM [Transaction] WHERE EventID = '" + rowIdToDelete + "'";

                DbConnection deleteRow = new DbConnection();
                try
                {
                    deleteRow.OpenConnection();
                    deleteRow.ExcecuteQueries(removeSelected);
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    dataGridView1.Refresh();
                    deleteRow.CloseConnection();
                }
            }

            int rowIndex = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows.RemoveAt(rowIndex);
            
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            //This structure needs to be changed for the child user so that not choosing any filters doesn't show ALL transactions.
            string filterQuery = "SELECT * FROM [Transaction]";
            string activeUser = comboBox2.Text;

            //This constructs a query based on the filter selections
            if (filterCategoryCB != null)
            {
                filterQuery = "SELECT * FROM [Transaction] WHERE AccountName = '" + filterCategoryCB.Text + "' AND PayerName = '" + comboBox2.Text + "'";
                if (activeUser == "All")
                {
                    filterQuery = "SELECT * FROM [Transaction] WHERE AccountName = '" + filterCategoryCB.Text + "'";
                }
                if (filterOwnerCB != null)
                {
                    filterQuery = "SELECT * FROM [Transaction] WHERE AccountName = '" + filterCategoryCB.Text + "' AND OwnerName = '" + filterOwnerCB.Text + "' AND PayerName = '" + comboBox2.Text + "'";
                    if (activeUser == "All")
                    {
                        filterQuery = "SELECT * FROM [Transaction] WHERE AccountName = '" + filterCategoryCB.Text + "' AND OwnerName = '" + filterOwnerCB.Text + "'";
                    }
                }
            }
            else if (filterOwnerCB != null)
            {
                filterQuery = "SELECT * FROM [Transaction] WHERE OwnerName = '" + filterOwnerCB.Text + "' AND PayerName = '" + comboBox2.Text + "'";
                if (activeUser == "All")
                {
                    filterQuery = "SELECT * FROM [Transaction] WHERE OwnerName = '" + filterOwnerCB.Text + "'";
                }
            }
            DbConnection filterConnection = new DbConnection();
            try
            {
                filterConnection.OpenConnection();
                dr = filterConnection.DataReader(filterQuery);

                while (dr.Read())
                {
                    dataGridView1.Rows.Add(dr["Amount"].ToString(), dr["AccountName"].ToString(), dr["PayerName"].ToString(), dr["OwnerName"].ToString(), dr["Date"].ToString(), dr["Receiver"].ToString(), dr["ProductName"].ToString(), dr["Description"].ToString(), dr["EventID"].ToString());
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                filterConnection.CloseConnection();
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
