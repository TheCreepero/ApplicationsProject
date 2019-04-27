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
            string listUsers = "SELECT AccountName, AccountType, AccountID FROM [Account]";

            try
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();

                listAccountsButton.OpenConnection();
                dr = listAccountsButton.DataReader(listUsers);
                while (dr.Read())
                {
                    dataGridView1.Rows.Add(dr["AccountName"].ToString(), dr["AccountType"].ToString(), dr["AccountID"].ToString());
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
            string insertUser = "INSERT INTO [Account] (AccountName, AccountType) VALUES ('" + accNameText.Text + "', '" + accTypeBox.Text + "')";
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

        private void updateAccountButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                int rowIdToUpdate = Convert.ToInt32(row.Cells["AccountID"].Value);
                string updateSelected = "UPDATE [Account] SET AccountName = '" + accNameText.Text + "', AccountType = '" + accTypeBox.Text + "' WHERE AccountID = " + rowIdToUpdate;
                DbConnection updateUser = new DbConnection();

                try
                {
                    updateUser.OpenConnection();
                    updateUser.ExcecuteQueries(updateSelected);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    updateUser.CloseConnection();
                    LoadAccounts();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dataGridView1.Rows[e.RowIndex].Index;
            accNameText.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            accTypeBox.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
        }
    }
}
