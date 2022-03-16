using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamNateZone
{
    
    public partial class CMWelcomeForm : Form
    {
        User user;
        ManageAccount manage;
        public CMWelcomeForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }


        private void btnViewClientList_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Client List still in progress. Come back Later!", "Form not ready", MessageBoxButtons.OK);
            //this.Hide();
        }

        private void btnManageAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            manage = new ManageAccount(user);
            manage.Owner = this;
            manage.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }

        private Boolean isClosed;
        private void btnMenuOpen_Click(object sender, EventArgs e)
        {
            isClosed = (pnlDropDown.Height == pnlDropDown.MinimumSize.Height ? true : false);
            pnlDropDown.Height = (isClosed ? pnlDropDown.MaximumSize.Height : pnlDropDown.MinimumSize.Height);
            
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminConsole ac = new AdminConsole();
            ac.Show();
        }

        private void WelcomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnViewMessages_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Messaging system still in progress. Come back Later!", "Form not ready", MessageBoxButtons.OK);
            //this.Hide();
        }

    }
}
