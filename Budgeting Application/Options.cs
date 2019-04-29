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
    /*NOTE TO TEACHERS
    The changes made while debugging in Visual Studio aren't actually saved. This is because the changes are made to the database in
    the debug folder, and every time the program is rerun it gets overwritten. This is not a bug, and the compiled release version works as intended.
    It just means that you can't make any permanent changes to the application data through visual studio.
    */
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
            LoadUsers();
            BindData();
        }

        SqlDataReader dr;

        //This is for the if statement that defines which insertion query is used
        string selectedData = "user";

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

        private void addUserButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(addUserName.Text, userLvlSelect.Text);
            string insertData = null;
            if (selectedData == "user")
            {
                insertData = "INSERT INTO [User] (UserName, UserLvl) VALUES ('" + addUserName.Text + "', '" + userLvlSelect.Text + "')";
            }
            else if (selectedData == "account")
            {
                insertData = "INSERT INTO [Account] (AccountName, AccountType) VALUES ('" + addUserName.Text + "', '" + userLvlSelect.Text + "')";
            }
            DbConnection insertToUsers = new DbConnection();
            try
            {
                insertToUsers.OpenConnection();
                insertToUsers.ExcecuteQueries(insertData);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                insertToUsers.CloseConnection();
            }
            if (selectedData == "user")
            {
                LoadUsers();
            }
            else if (selectedData == "account")
            {
                LoadAccounts();
            }
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            if (selectedData == "user")
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to remove the users transactions as well?", "Transactions", MessageBoxButtons.YesNoCancel);

                if (dialogResult == DialogResult.Yes)
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
                        string userToDelete = row.Cells["Username"].Value.ToString();
                        string removeTransactions = "DELETE FROM [Transaction] WHERE PayerName = '" + userToDelete + "'";

                        DbConnection deleteData = new DbConnection();
                        try
                        {
                            deleteData.OpenConnection();
                            deleteData.ExcecuteQueries(removeTransactions);
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            deleteData.CloseConnection();
                        }
                    }
                    int rowIndex = dataGridView1.CurrentRow.Index;
                    dataGridView1.Rows.RemoveAt(rowIndex);


                }
                else if (dialogResult == DialogResult.No)
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
                else if (dialogResult == DialogResult.Cancel)
                {
                    MessageBox.Show("Nothing was deleted.");
                }
            }
            else if (selectedData == "account")
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    int rowIdToDelete = Convert.ToInt32(row.Cells["UserID"].Value);
                    string removeSelected = "DELETE FROM [Account] WHERE AccountID = '" + rowIdToDelete + "'";
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
            

        }

        private void addAccountButton_Click(object sender, EventArgs e)
        {
            addAccount account = new addAccount();
            account.ShowDialog();
        }

        private void updateUserButton_Click(object sender, EventArgs e)
        {            
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                int rowIdToDelete = Convert.ToInt32(row.Cells["UserID"].Value);
                string updateSelected = null;
                if (selectedData == "user")
                {
                    updateSelected = "UPDATE [User] SET UserName = '" + addUserName.Text + "', UserLvl = '" + userLvlSelect.Text + "' WHERE UserID = " + rowIdToDelete;
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
                        LoadUsers();
                    }
                }
                else if (selectedData == "account")
                {
                    updateSelected = "UPDATE [Account] SET AccountName = '" + addUserName.Text + "', AccountType = '" + userLvlSelect.Text + "' WHERE AccountID = " + rowIdToDelete;
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
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
            try
            {
                int rowIndex = dataGridView1.Rows[e.RowIndex].Index;
                addUserName.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
                userLvlSelect.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            }
            catch (ArgumentOutOfRangeException ex)
            {

            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void showUserButton_Click(object sender, EventArgs e)
        {
            //Changes the texts in the menu
            showUserButton.ForeColor = Color.Green;
            showAccountButton.ForeColor = Color.DarkRed;
            dataGridView1.Columns[0].HeaderText = "Username";
            dataGridView1.Columns[1].HeaderText = "User Level";
            label1.Text = "Username";
            label2.Text = "User Level";
            addUserButton.Text = "Add user";
            deleteUserButton.Text = "Delete user";
            userLvlSelect.Items.Clear();
            userLvlSelect.Items.Add("admin");
            userLvlSelect.Items.Add("parent");
            userLvlSelect.Items.Add("child");

            //This is for the if statement that defines which insertion query is used
            selectedData = "user";

            //Loads user data from database
            LoadUsers();
        }

        private void showAccountButton_Click(object sender, EventArgs e)
        {
            //Changes the texts in the menu
            showUserButton.ForeColor = Color.DarkRed;
            showAccountButton.ForeColor = Color.Green;
            dataGridView1.Columns[0].HeaderText = "Account Name";
            dataGridView1.Columns[1].HeaderText = "Account Type";
            label1.Text = "Account Name";
            label2.Text = "Account Type";
            addUserButton.Text = "Add account";
            deleteUserButton.Text = "Delete account";

            userLvlSelect.Items.Clear();
            userLvlSelect.Items.Add("Expenses");
            userLvlSelect.Items.Add("Income");

            //This is for the if statement that defines which insertion query is used
            selectedData = "account";

            //Loads account data from database
            LoadAccounts();
        }
    }
}
