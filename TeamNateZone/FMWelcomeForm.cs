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
    public partial class FMWelcomeForm : Form
    {
        User user;

        public FMWelcomeForm(User user)
        {
            InitializeComponent();
            this.user = user;

        }
        private Boolean isClosed;
        private void btnMenuOpen_Click(object sender, EventArgs e)
        {
            isClosed = (pnlDropDown.Height == pnlDropDown.MinimumSize.Height ? true : false);
            pnlDropDown.Height = (isClosed ? pnlDropDown.MaximumSize.Height : pnlDropDown.MinimumSize.Height);

        }
        private void btnViewClient_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Client View still in progress. Come back Later!", "Form not ready", MessageBoxButtons.OK);
        }
        private void btnMessages_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Messages still in progress. Come back Later!", "Form not ready", MessageBoxButtons.OK);

        }

        private void btnManageAccount_Click(object sender, EventArgs e)
        {
            ManageAccount manage;
            this.Hide();
            manage = new ManageAccount(user);
            manage.Owner = this;
            manage.Show();
        }

        private void btnManageFinances_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Financial Management still in progress. Come back Later!", "Form not ready", MessageBoxButtons.OK);
        }
    }
}
