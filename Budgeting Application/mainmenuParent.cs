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
    public partial class mainmenuParent : Form
    {
        string welcomeLabel = "Welcome, " + Convert.ToString(Program.selectedUserName) + "!";

        public mainmenuParent()
        {
            InitializeComponent();
            label1.Text = welcomeLabel;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
