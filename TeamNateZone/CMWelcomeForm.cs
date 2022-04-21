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


        private void btnViewAllClaims_Click(object sender, EventArgs e)
        {
            this.Hide();
            claimList newForm = new claimList(user);
            newForm.Owner = this;
            newForm.Show();
            this.Hide();
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

        // View Client List
        private void rndButton1_Click(object sender, EventArgs e)
        {
            ViewUsersWithActiveClaims v = new ViewUsersWithActiveClaims(user);
            v.Show();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }

        private void btnViewFolders_Click(object sender, EventArgs e)
        {
            //The following will be implemented in the next issue of the program
            /*
            folderPage folderScreen = new folderPage(user);
            folderScreen.Show();
            this.Hide();
            */
            MessageBox.Show("The Following File Viewer System will be implemented in the next program release");

        }
    }
}
