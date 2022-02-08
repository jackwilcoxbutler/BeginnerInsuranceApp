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
                welcomeForm.Owner = this;
                welcomeForm.Show();
            }
            else{
                /*this.Hide();
                failedLogin = new FailedLogin();
                failedLogin.Owner = this;
                failedLogin.Show();*/
                string message = "Incorrect username or password";
                string title = "Login Failed";
                MessageBoxButtons buttons = MessageBoxButtons.RetryCancel;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Cancel)
                {
                    Application.Exit();
                }
                else
                {
                    // Do something  
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            /* this.Hide();
             cancelLogin = new CancelLogin();
             cancelLogin.Owner = this;
             cancelLogin.Show();*/
            string message = "Do you want to cancel this login attempt?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                // Do something  
            }
        }

        private void LoginForm_FormClosing(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
