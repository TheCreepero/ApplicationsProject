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
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
            LoadUsers();
            BindData();
        }

        private void BindData()
        {
            userLvlSelect.Items.Add("admin");
            userLvlSelect.Items.Add("parent");
            userLvlSelect.Items.Add("child");
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }

        SqlDataReader dr;
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
                    dataGridView1.Rows.Add(dr["UserName"].ToString(), dr["UserLvl"].ToString(), dr["UserID"]);
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

        private void addUserButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(addUserName.Text, userLvlSelect.Text);
            string insertUser = "INSERT INTO [User] (UserName, UserLvl) VALUES ('" + addUserName.Text + "', '" + userLvlSelect.Text + "')";
            DbConnection insertToUsers = new DbConnection();

            try
            {
                insertToUsers.OpenConnection();
                insertToUsers.ExcecuteQueries(insertUser);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                insertToUsers.CloseConnection();
                LoadUsers();
            }
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                int rowIdToDelete = Convert.ToInt32(row.Cells["UserID"].Value);
                string removeSelected = "DELETE FROM [User] WHERE UserID = '" + rowIdToDelete + "'";

                DbConnection deleteRow = new DbConnection();
                try
                {
                    deleteRow.OpenConnection();
                    deleteRow.ExcecuteQueries(removeSelected);
                }
                catch (SqlException ex)
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

        private void addAccountButton_Click(object sender, EventArgs e)
        {
            addAccount account = new addAccount();
            account.ShowDialog();
        }
    }
}