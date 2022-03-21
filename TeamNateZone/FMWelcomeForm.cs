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
        private void btnViewClient_Click(object sender, EventArgs e)
        {
           FMCMViewUsers v = new FMCMViewUsers(user);
           v.Show();           
        }
        private void btnViewMessages_Click(object sender, EventArgs e)
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
