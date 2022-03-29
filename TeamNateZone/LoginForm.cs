using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TeamNateZone
{
    public partial class LoginForm : Form
    {
        ClientWelcomeForm clientWelcomeForm;
        RegistrationForm registrationForm;
        FMWelcomeForm fmWelcomeForm;
        CMWelcomeForm cmWelcomeForm;
        User user = new User(); // this is why we need default constructor :D
        dbHandler db = new dbHandler(@"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True");
        public LoginForm()
        {
            InitializeComponent();
        }
        
        private void LoginForm_FormClosing(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registrationForm = new RegistrationForm();
            registrationForm.Owner = this;
            registrationForm.Show();
            this.Hide();
        }

        private void txtPassword_KeyDown(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                btnLogin_Click_1(sender, e);
            }
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string enteredPW = txtPassword.Text;

            try
            {
                if (txtUsername.Text == "" || txtPassword.Text == "")
                {
                    string message = "Username or Password Blank";
                    string title = "Login Failed";
                    MessageBoxButtons buttons = MessageBoxButtons.RetryCancel;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Cancel)
                    {
                        Application.Exit();
                    }
                }
                else if (enteredPW == db.check_password(txtUsername.Text))
                {
                    user = db.get_user_information(txtUsername.Text);
                    this.Hide();
                    if (user.getClearance() == 0 ||  user.getClearance() == 3)//needs to be changed when new welcome forms are built
                    {
                        clientWelcomeForm = new ClientWelcomeForm(user);
                        clientWelcomeForm.Owner = this;
                        clientWelcomeForm.Show();
                    }
                    else if(user.getClearance() == 1)
                    {
                        cmWelcomeForm = new CMWelcomeForm(user);
                        cmWelcomeForm.Owner = this;
                        cmWelcomeForm.Show();
                    }
                    else if(user.getClearance() == 2)
                    {
                        fmWelcomeForm = new FMWelcomeForm(user);
                        fmWelcomeForm.Owner = this;
                        fmWelcomeForm.Show();
                    }
                }
                else
                {
                    string message = "Incorrect username or password";
                    string title = "Login Failed";
                    MessageBoxButtons buttons = MessageBoxButtons.RetryCancel;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Cancel)
                    {
                        Application.Exit();
                    }
                   
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Occurred - login");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {


            string message = "Do you want to cancel this login attempt?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

