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
        User user;
        claimList listClaims;
        CreateClaim fileClaim;
        ManageAccount manage;
        public ClientWelcomeForm(User user)
        {
            InitializeComponent();
            this.user = user;
            if(user.getClearance() == 3)
            {
                btnAdmin.Visible = true;
            }
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
        private void btnMenuOpen_Click(object sender, EventArgs e)
        {
            if (pnlDropDown.Height == pnlDropDown.MinimumSize.Height)
                isClosed = true;
            else
                isClosed = false;

            if(isClosed == true)
            {
                pnlDropDown.Height = pnlDropDown.MaximumSize.Height;
            }
            else
            {
                pnlDropDown.Height = pnlDropDown.MinimumSize.Height;
            }
            
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

        private void btnListClaims_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            listClaims = new claimList(user);
            listClaims.Owner = this;
            listClaims.Show();
        }

    }
}
