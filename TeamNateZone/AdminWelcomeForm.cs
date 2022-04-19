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
    public partial class AdminWelcomeForm : Form
    {
        User user;
        MessageForm message;
        AdminConsole adminConsole;

        public AdminWelcomeForm(User user)
        {
            InitializeComponent();
            this.user = user;

            lblWelcome.Text = "Welcome Admin: " + user.getFname() + " " + user.getLname();

        }
        private void btnViewClient_Click(object sender, EventArgs e)
        {
            AdminViewUsers v = new AdminViewUsers();
            v.Owner = this;
            v.Show();
        }
        private void btnViewMessages_Click(object sender, EventArgs e)
        {
            this.Hide();
            message = new MessageForm(user);
            message.Owner = this;
            message.Show();
        }

        private void btnManageAccount_Click(object sender, EventArgs e)
        {
            ManageAccount manage;
            this.Hide();
            manage = new ManageAccount(user);
            manage.Owner = this;
            manage.Show();
        }

        private void btnGrantPermissions_Click(object sender, EventArgs e)
        {
            adminConsole = new AdminConsole();
            adminConsole.Owner = this;
            adminConsole.Show();
            this.Hide();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }

        private void btnViewFolders_Click(object sender, EventArgs e)
        {
            folderPage folderScreen = new folderPage(user);
            folderScreen.Show();
            this.Hide();
        }
    }
}
