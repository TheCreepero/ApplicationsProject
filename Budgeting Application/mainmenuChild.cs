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
        SqlDataReader dr2;
        int oldRowCount;

        //Command strings are here so that they can be accessed by all the methods
        string welcomeLabel = "Welcome, " + Convert.ToString(Program.selectedUserName) + "!";
        string listAccounts = "SELECT AccountName FROM [Account]";
        string listUsers = "SELECT UserName FROM [User]";
        string errorTitle = "An exception has occured!";

        public mainmenuChild()
        {
            InitializeComponent();
            label1.Text = welcomeLabel;
            BindData();
            LoadAccountData();
            filterCategoryCB.SelectedText = "Any";
            LoadTransactions();
        }

        DataTable eventTable = new DataTable();

        public void BindData()
        {
            DbConnection comboBoxUsers = new DbConnection();           
            try
            {
                filterCategoryCB.Items.Add("Any");
                comboBoxUsers.OpenConnection();
                dr = comboBoxUsers.DataReader(listAccounts);
                while (dr.Read())
                {
                    string text = dr["AccountName"].ToString();
                    this.comboBox1.Items.Add(text);
                    this.filterCategoryCB.Items.Add(text);
                }
                //This "resets" the connection
                comboBoxUsers.CloseConnection();
                comboBoxUsers.OpenConnection();
                dr2 = comboBoxUsers.DataReader(listUsers);
                while (dr2.Read())
                {
                    string text = dr2["UserName"].ToString();
                    comboBox2.Items.Add(text);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, errorTitle);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, errorTitle);
            }
            finally
            {
                comboBoxUsers.CloseConnection();
            }            
        }

        private void LoadAccountData()
        {
            userNameLabel.Text = Program.selectedUserName.ToString();
            string balanceQuery = "SELECT Amount from [Transaction] WHERE PayerName = '" + Program.selectedUserName.ToString() + "'";
            DbConnection loadBalance = new DbConnection();
            double sum = 0;
            double incomeSum = 0;
            double expenseSum = 0;
            try
            {
                loadBalance.OpenConnection();
                dr = loadBalance.DataReader(balanceQuery);
                while (dr.Read())
                {
                    sum += Convert.ToDouble(dr["Amount"]);
                    if (Convert.ToDouble(dr["Amount"]) > 0)
                    {
                        incomeSum += Convert.ToDouble(dr["Amount"]);
                    }
                    else if (Convert.ToDouble(dr["Amount"]) < 0)
                    {
                        expenseSum += Convert.ToDouble(dr["Amount"]);
                    }
                }
                accBalLabel.Text = sum.ToString() + "€";
                incomeLabel.Text = incomeSum.ToString() + "€";
                expenseLabel.Text = expenseSum.ToString() + "€";
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, errorTitle);
            }
            finally
            {
                loadBalance.CloseConnection();
            }
        }

        private void LoadTransactions()
        {
            DbConnection fetchTransactions = new DbConnection();
            string selectTransactions = "SELECT * FROM [Transaction] WHERE PayerName = '" + Program.selectedUserName.ToString() + "'";
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
                MessageBox.Show(ex.Message, errorTitle);
            }
            finally
            {
                fetchTransactions.CloseConnection();
                oldRowCount = dataGridView1.Rows.Count;
                GenerateReport();
            }
        }

        public void GenerateReport()
        {
            try
            {
                double sum = 0;
                double incomeSum = 0;
                double expenseSum = 0;

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value);
                    if (Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value) > 0)
                    {
                        incomeSum += Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value);
                    }
                    else if (Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value) < 0)
                    {
                        expenseSum += Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value);
                    }
                }

                balanceLabel.Text = sum.ToString() + '€';
                reportExpLabel.Text = expenseSum.ToString() + "€";
                reportIncomeLabel.Text = incomeSum.ToString() + "€";
                if (sum > 0)
                {
                    reportResultText.Text = "All good!";
                    reportResultText.ForeColor = Color.Green;
                    reportResultText.Font = new Font(reportResultText.Font, FontStyle.Bold);
                }
                else if (sum < 0)
                {
                    reportResultText.Text = "Reduce expenses!";
                    reportResultText.ForeColor = Color.Red;
                    reportResultText.Font = new Font(reportResultText.Font, FontStyle.Bold);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, errorTitle);
            }
        }

        private void fetchTransactions_Click(object sender, EventArgs e)
        {
            //This clears any existing records from the DataGrid before new data is loaded in
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            //This takes the transaction data from the DB and displays it in dataGridView1
            DbConnection fetchTransactions = new DbConnection();
            string selectTransactions = "SELECT * FROM [Transaction] WHERE PayerName = '" + Program.selectedUserName.ToString() + "'";
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
                MessageBox.Show(ex.Message, errorTitle);
            }
            finally
            {
                fetchTransactions.CloseConnection();
                oldRowCount = dataGridView1.Rows.Count;
                GenerateReport();
            }
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddEvent_Click(object sender, EventArgs e)
        {
            if (textBox1 == null || string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Incorrect input!", errorTitle);
            }
            else
            {
                dataGridView1.Rows.Add(textBox1.Text, comboBox1.Text, Program.selectedUserName, comboBox2.Text, dateTimePicker1.Value, textBox2.Text, textBox3.Text, textBox4.Text);
                string insertChanges = "INSERT INTO [Transaction] VALUES ('" + textBox1.Text + "', '" + comboBox1.Text + "', '" + Program.selectedUserName + "', '" + comboBox2.Text + "', '" + dateTimePicker1.Value + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "')";
                DbConnection insertToDb = new DbConnection();

                try
                {
                    insertToDb.OpenConnection();
                    insertToDb.ExcecuteQueries(insertChanges);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, errorTitle);
                }
                finally
                {
                    dataGridView1.Refresh();
                    insertToDb.CloseConnection();
                    LoadAccountData();
                    GenerateReport();
                }
            }
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
            filterCategoryCB.SelectedText = "Any";
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
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, errorTitle);
                }
                finally
                {
                    dataGridView1.Refresh();
                    deleteRow.CloseConnection();
                    LoadAccountData();
                    GenerateReport();
                }
            }
            try
            {
                int rowIndex = dataGridView1.CurrentRow.Index;
                dataGridView1.Rows.RemoveAt(rowIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, errorTitle);
            }
            
        }

        private void ownedTransactionsButton_Click(object sender, EventArgs e)
        {
            //Child users aren't allowed to see other users' accounts, except for those that are purchased FOR the child user.
            string selectTransactions = "SELECT * FROM [Transaction] WHERE OwnerName = '" + Program.selectedUserName.ToString() + "'";
            DbConnection fetchOwnedTransactions = new DbConnection();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            try
            {
                fetchOwnedTransactions.OpenConnection();
                dr = fetchOwnedTransactions.DataReader(selectTransactions);
                while (dr.Read())
                {
                    dataGridView1.Rows.Add(dr["Amount"].ToString(), dr["AccountName"].ToString(), dr["PayerName"].ToString(), dr["OwnerName"].ToString(), dr["Date"].ToString(), dr["Receiver"].ToString(), dr["ProductName"].ToString(), dr["Description"].ToString(), dr["EventID"].ToString());
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, errorTitle);
            }
            finally
            {
                fetchOwnedTransactions.CloseConnection();
                //I don't remember what this is for, but I'll keep it there in case it's something important.
                oldRowCount = dataGridView1.Rows.Count;
                GenerateReport();
            }
        }

        private void filterDatesButton_Click_1(object sender, EventArgs e)
        {
            //This clears the existing rows so that there are no duplicates.
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            //This constructs the query based on the selected filters
            string activeUser = comboBox2.Text;
            string filterDateQuery = "SELECT * FROM [Transaction] WHERE PayerName = '" + Program.selectedUserName + "' AND Date BETWEEN '" + dateTimePicker2.Value.ToString("MM.dd.yyyy") + "' AND '" + dateTimePicker3.Value.ToString("MM.dd.yyyy") + "'";           

            if (filterCategoryCB.Text != "Any")
            {
                filterDateQuery = "SELECT * FROM [Transaction] WHERE AccountName = '" + filterCategoryCB.Text + "' AND PayerName = '" + Program.selectedUserName + "' AND Date BETWEEN '" + dateTimePicker2.Value.ToString("MM.dd.yyyy") + "' AND '" + dateTimePicker3.Value.ToString("MM.dd.yyyy") + "'";               
            }
            DbConnection filterDatesConn = new DbConnection();
            try
            {
                filterDatesConn.OpenConnection();
                dr = filterDatesConn.DataReader(filterDateQuery);
                while (dr.Read())
                {
                    dataGridView1.Rows.Add(dr["Amount"].ToString(), dr["AccountName"].ToString(), dr["PayerName"].ToString(), dr["OwnerName"].ToString(), dr["Date"].ToString(), dr["Receiver"].ToString(), dr["ProductName"].ToString(), dr["Description"].ToString(), dr["EventID"].ToString());
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, errorTitle);
            }
            finally
            {
                filterDatesConn.CloseConnection();
                GenerateReport();
            }
        }

        private void filterButton_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string filterQuery = "SELECT * FROM [Transaction]";
            string activeUser = comboBox2.Text;
            //This constructs a query based on the filter selections
            if (filterCategoryCB.Text != "Any")
            {
                filterQuery = "SELECT * FROM [Transaction] WHERE AccountName = '" + filterCategoryCB.Text + "' AND PayerName = '" + Program.selectedUserName + "'";
            }
            else
            {
                filterQuery = "SELECT * FROM [Transaction] WHERE PayerName = '" + Program.selectedUserName + "'";
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
                MessageBox.Show(ex.Message, errorTitle);
            }
            finally
            {
                filterConnection.CloseConnection();
                GenerateReport();
            }
        }

        private void generateReportButton_Click(object sender, EventArgs e)
        {
            GenerateReport();
        }
    }
}
