using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budgeting_Application
{
    public partial class addAccount : Form
    {
        public addAccount()
        {
            InitializeComponent();
            BindData();
            LoadAccounts();
        }

        SqlDataReader dr;
        private void dgv_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }

        private void LoadAccounts()
        {
            DbConnection listAccountsButton = new DbConnection();
            string listUsers = "SELECT AccountName, AccountType FROM [Account]";

            try
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();

                listAccountsButton.OpenConnection();
                dr = listAccountsButton.DataReader(listUsers);
                while (dr.Read())
                {
                    dataGridView1.Rows.Add(dr["AccountName"].ToString(), dr["AccountType"].ToString());
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                listAccountsButton.CloseConnection();
            }
        }

        private void BindData()
        {
            accTypeBox.Items.Add("Expenses");
            accTypeBox.Items.Add("Income");
        }

        private void addCategoryButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(accNameText.Text, accTypeBox.Text);
            string insertUser = "INSERT INTO [Account] VALUES ('" + accNameText.Text + "', '" + accTypeBox.Text + "')";
            DbConnection insertToAccounts = new DbConnection();

            try
            {
                insertToAccounts.OpenConnection();
                insertToAccounts.ExcecuteQueries(insertUser);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                insertToAccounts.CloseConnection();
                LoadAccounts();
            }
        }
    }
}
