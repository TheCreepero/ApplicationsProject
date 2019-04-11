using System;
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
    public partial class mainmenuChild : Form
    {
        SqlDataReader dr;
        string welcomeLabel = "Welcome, " + Convert.ToString(Program.selectedUserName) + "!";

        public mainmenuChild()
        {
            InitializeComponent();
            label1.Text = welcomeLabel;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fetchTransactions_Click(object sender, EventArgs e)
        {
            DbConnection fetchTransactions = new DbConnection();
            string selectTransactions = "SELECT * FROM [Transaction] WHERE PayerName = '" + Program.selectedUserName.ToString() + "'";

            try
            {
                fetchTransactions.OpenConnection();

                dr = fetchTransactions.DataReader(selectTransactions);

                while (dr.Read())
                {
                    dataGridView1.Rows.Add(dr["Amount"].ToString(), dr["AccountName"].ToString(), dr["PayerName"].ToString(), dr["OwnerName"].ToString(), dr["Date"].ToString(), dr["Receiver"].ToString(), dr["ProductName"].ToString(), dr["Description"].ToString());
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fetchTransactions.CloseConnection();
            }
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
