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

        private void addUserButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(addUserName.Text, userLvlSelect.Text);
        }
    }
}
