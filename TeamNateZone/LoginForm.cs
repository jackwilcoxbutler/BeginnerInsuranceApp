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
    public partial class LoginForm : Form
    {
        string[] usernames = { "Jack" };
        string[] passwords = { "Wilcox" };
        WelcomeForm welcomeForm;
        FailedLogin failedLogin;
        CancelLogin cancelLogin;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (usernames.Contains(txtUsername.Text) && passwords.Contains(txtPassword.Text)){
                this.Hide();
                welcomeForm = new WelcomeForm();
                welcomeForm.Show();
            }
            else{
                this.Hide();
                failedLogin = new FailedLogin();
                failedLogin.Show();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            cancelLogin = new CancelLogin();
            cancelLogin.Show();
        }

        private void LoginForm_FormClosing(object sender,EventArgs e)
        {
            Application.Exit();
        }

    }
}
