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
    public partial class CreateClaim : Form
    {
        WelcomeForm welcomeForm;
        public CreateClaim()
        {
            InitializeComponent();
        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {
            DateTime thisDay = DateTime.Today;
            txtDate.ReadOnly = true;
            txtDate.Text = thisDay.ToShortDateString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            welcomeForm = new WelcomeForm();
            welcomeForm.Owner = this;
            welcomeForm.Show();
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

        private void btnLogout2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logout Successful");
            Application.Exit();
        }
    }
}
