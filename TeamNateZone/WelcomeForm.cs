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
    
    public partial class WelcomeForm : Form
    {
        User user;
        claimList listClaims;
        CreateClaim fileClaim;
        ManageAccount manage;
        public WelcomeForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btnListClaims_Click(object sender, EventArgs e)
        {
            this.Hide();
            listClaims = new claimList();
            listClaims.Owner = this;
            listClaims.Show();
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
            manage = new ManageAccount();
            manage.Owner = this;
            manage.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logout Successful");
            var newForm = new LoginForm();
            newForm.Show();
            this.Close();
            
        }

        private Boolean isClosed;
        private void menuButton_Click(object sender, EventArgs e)
        {
            if (pnlDropDown.Height == pnlDropDown.MinimumSize.Height)
                isClosed = true;
            else
                isClosed = false;

            if (isClosed == true)
            {
                pnlDropDown.Height = pnlDropDown.MaximumSize.Height;
            }
            else
            {
                pnlDropDown.Height = pnlDropDown.MinimumSize.Height;
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }
    }
}
