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
            BindData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        DataTable eventTable = new DataTable();

        public void BindData()
        {
            DbConnection comboBoxUsers = new DbConnection();
            string listUsers = "SELECT AccountName FROM [Account]";

            try
            {
                comboBoxUsers.OpenConnection();
                dr = comboBoxUsers.DataReader(listUsers);
                while (dr.Read())
                {
                    string text = dr["AccountName"].ToString();
                    this.comboBox1.Items.Add(text);
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
            dataGridView1.Rows.Add(textBox1.Text, comboBox1.Text, textBox7.Text, textBox6.Text, dateTimePicker1.Value, textBox2.Text, textBox3.Text, textBox4.Text);
            string insertChanges = "INSERT INTO [Transaction] VALUES ('" + textBox1.Text + "', '" + comboBox1.Text + "', '" + textBox7.Text + "', '" + textBox6.Text + "', '" + dateTimePicker1.Value + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "')";
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
                insertToDb.CloseConnection();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mainmenuChild_Load(object sender, EventArgs e)
        {
            eventTable.Columns.Add("Amount", typeof(float));
            eventTable.Columns.Add("Account Name", typeof(string));
            eventTable.Columns.Add("Payer Name", typeof(string));
            eventTable.Columns.Add("Purchase Owner", typeof(string));
            eventTable.Columns.Add("Date", typeof(DateTime));
            eventTable.Columns.Add("Receiver", typeof(string));
            eventTable.Columns.Add("Product Name", typeof(string));
            eventTable.Columns.Add("Description", typeof(string));
        }

        private void balanceLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
