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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "" || txtUsername.Text == "" || txtVerifyPassword.Text == "")
            {
                string message = "ERROR : Password or Username is blank";
                string title = "Registration Failed";
                MessageBoxButtons buttons = MessageBoxButtons.RetryCancel;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Cancel)
                {
                    Application.Exit();
                }
                else
                {
                    txtPassword.Clear();
                    txtVerifyPassword.Clear();
                }

            }
            else if (txtPassword.Text == txtVerifyPassword.Text)
            {
                string message = "Registration Successful! Click return to log into application.";
                MessageBox.Show(message);
                //search database to see if username already exists
                //if not, add username and password to login database
            }
            else
            {
                string message = "ERROR : Passwords do not match";
                string title = "Registration Failed";
                MessageBoxButtons buttons = MessageBoxButtons.RetryCancel;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Cancel)
                {
                    Application.Exit();
                }
                else
                {

                    txtPassword.Clear();
                    txtVerifyPassword.Clear();
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            LoginForm lf = (LoginForm)this.Owner;
            this.Close();
            lf.Show();
        }
    }
}
