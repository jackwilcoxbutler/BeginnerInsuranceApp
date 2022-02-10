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
    public partial class ManageAccount : Form
    {
        WelcomeForm welcomeForm;
        public ManageAccount()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            welcomeForm = new WelcomeForm();
            welcomeForm.Owner = this;
            welcomeForm.Show();
        }

        private void btnLogout2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logout Successful");
            Application.Exit();
        }

        private Boolean isClosed;
        private void btnMenu_Click(object sender, EventArgs e)
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
    }
}
