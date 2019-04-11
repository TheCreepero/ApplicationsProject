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
        int oldRowCount;
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
                oldRowCount = dataGridView1.Rows.Count;
            }
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveChanges_Click(object sender, EventArgs e) //UNFINISHED
        {            
            SqlConnection con = new System.Data.SqlClient.SqlConnection();
            con.ConnectionString = DbConnection.connectionString;
            SqlDataAdapter da = new SqlDataAdapter();
            string insertChanges = "INSERT INTO [Transactions](Amount, AccountName, PayerName, OwnerName, Date, Receiver, ProductName, Description) VALUES (@Amount, @AccountName, @PayerName, @OwnerName, @Date, @Receiver, @ProductName, @Description)";

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(insertChanges, con);
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    //CONTINUE HERE

                    da.InsertCommand = cmd;
                    cmd.ExecuteNonQuery();
                    oldRowCount++;
                }                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addEvent_Click(object sender, EventArgs e)
        {

        }
    }
}
