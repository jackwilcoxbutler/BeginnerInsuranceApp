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
        claimList listClaims;
        CreateClaim fileClaim;
        ManageAccount manage;
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void welcomeLabel_Click(object sender, EventArgs e)
        {

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
            fileClaim = new CreateClaim();
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



    }
}
