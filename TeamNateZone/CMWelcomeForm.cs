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
        AllClaimList AlllistClaims;
        ManageAccount manage;
        MessageForm message;
        public CMWelcomeForm(User user)
        {
            InitializeComponent();
            this.user = user;

            lblWelcome.Text = "Welcome Claims Manager: " + user.getFname() + " " + user.getLname();
        }


        private void btnViewClientList_Click(object sender, EventArgs e)
        {
            ViewUsersWithActiveClaims v = new ViewUsersWithActiveClaims(user);
            v.Show();
        }

        private void btnManageAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            manage = new ManageAccount(user);
            manage.Owner = this;
            manage.Show();
        }

        private void WelcomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnViewMessages_Click(object sender, EventArgs e)
        {
            this.Hide();
            message = new MessageForm(user);
            message.Owner = this;
            message.Show();
        }

        private void rndButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AlllistClaims = new AllClaimList(user);
            AlllistClaims.Owner = this;
            AlllistClaims.Show();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }
    }
}
