using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TeamNateZone
{
    public partial class RegistrationForm : Form
    {
        struct clearances {
            public const int CLIENT = 0;
            public const int CM = 1;
            public const int FM = 2;
            public const int ADMIN  = 3;


        }
        int clearance;
        dbHandler db = new dbHandler(@"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True");
        public RegistrationForm()
        {
            InitializeComponent();

        }
        public RegistrationForm(int val)
        {
            InitializeComponent();
            this.clearance = val;
            if(clearance == 1)
            {
                lblUserType.Text = "Register A New Claims Manager";
            }
            if(clearance == 2)
            {
                lblUserType.Text = "Register A New Financial Manager";
            }
            else
            {
                lblUserType.Text = "";
            }
        }


        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword.Text == "" || txtUsername.Text == "" || txtVerifyPassword.Text == "" ||
                                txtEmail.Text == "")
                {
                    string message = "ERROR : Required Field is blank";
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
                else if (txtEmail.Text == db.get_email(txtEmail.Text) ||
                         txtUsername.Text == db.get_username(txtUsername.Text))
                {
                    string message = "ERROR : Username or Email already in use. Click retry to return to login page.";
                    string title = "Registration Failed";
                    MessageBoxButtons buttons = MessageBoxButtons.RetryCancel;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Cancel)
                    {
                        Application.Exit();
                    }
                    else
                    {
                        LoginForm lf = (LoginForm) this.Owner;
                        this.Close();
                        lf.Show();
                    }
                }
                else if (txtPassword.Text == txtVerifyPassword.Text)
                {
                    string message = "Registration Successful! Logging you in...";
                    //this allows User to be able to type in the state in the comboBox so they are able to Type or select
                    string stateTxt;
                    if (comboState.Items.Contains(comboState.Text))
                    {
                        stateTxt = comboState.Text;
                    }
                    else
                    {
                        stateTxt = "";
                    }

                    if (clearance > clearances.CLIENT)
                    {
                        db.store_privileged_user_information(txtFname.Text, txtLname.Text, txtAddress.Text, txtCity.Text, stateTxt, txtZip.Text, txtUsername.Text, txtPassword.Text, txtEmail.Text, clearance);
                        MessageBox.Show("Successfully registered new manager!", "Success");
                        this.Close();
                    }
                    else {
                        db.store_user_information(txtFname.Text, txtLname.Text, txtAddress.Text, txtCity.Text, stateTxt, txtZip.Text, txtUsername.Text, txtPassword.Text, txtEmail.Text);
                        MessageBox.Show(message);
                        User user = db.get_user_information(txtUsername.Text);
                        ClientWelcomeForm wf = new ClientWelcomeForm(user);
                        this.Close();
                        wf.Show();
                    }
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
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Occurred");
            }
        }

        private void btnReturn_Click_1(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            this.Close();
            lf.Show();
        }

        private void txtVerifyPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnRegister_Click_1(sender, e);
            }
        }
    }
}
