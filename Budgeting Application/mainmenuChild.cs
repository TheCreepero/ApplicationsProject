using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budgeting_Application
{
    public partial class mainmenuChild : Form
    {
        private DataGridView transactionTable = new DataGridView();
        string welcomeLabel = "Welcome, " + Convert.ToString(Program.selectedUserName) + "!";

        public mainmenuChild()
        {
            InitializeComponent();
            label1.Text = welcomeLabel;
            transactionTable.Dock = DockStyle.Fill;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
