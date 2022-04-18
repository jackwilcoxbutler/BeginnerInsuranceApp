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
    
    public partial class ClientWelcomeForm : Form
    {
        struct clearances {
            public const int CLI = 0;
            public const int CM = 1;
            public const int FM = 2;
            public const int ADM = 3;
        }
        
        User user;
        claimList listClaims;
        CreateClaim fileClaim;
        ManageAccount manage;
        MessageForm message;
        public ClientWelcomeForm(User user)
        {
            InitializeComponent();
            this.user = user;

            lblWelcome.Text = "Welcome Client: " + user.getFname() + " " + user.getLname();
        }


        private void btnFileClaim_Click(object sender, EventArgs e)
        {
            this.Hide();
            fileClaim = new CreateClaim(user);
            fileClaim.Owner = this;
            fileClaim.Show();
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

        private void WelcomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnListClaims_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            listClaims = new claimList(user);
            listClaims.Owner = this;
            listClaims.Show();
        }

        private void btnlogout_Click_1(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }

        private void btnViewMessages_Click(object sender, EventArgs e)
        {
            this.Hide();
            message = new MessageForm(user);
            message.Owner = this;
            message.Show();
        }

        private void label2_Click(object sender, EventArgs e) { }

        private void btnViewFolders_Click(object sender, EventArgs e)
        {
            folderPage folderScreen = new folderPage(user);
            folderScreen.Show();
        }
    }
}
