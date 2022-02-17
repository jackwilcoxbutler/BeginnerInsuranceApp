using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamNateZone
{
    public partial class LoginForm : Form
    {
        WelcomeForm welcomeForm;
        RegistrationForm registrationForm;
        User user = new User(); // this is why we need default constructor :D
        public LoginForm()
        {
            InitializeComponent();
        }
        private int getUserPermissions(string username)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            try
            {
                cn.ConnectionString =
                    @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
                cmd.Connection = cn;
                cmd.CommandText = "SELECT clearance FROM SignInInfo WHERE Username = @username";
                cmd.Parameters.AddWithValue("@username", username);
                cn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                return dr.GetInt32(0);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Occurred");
                return 0;
            }
            finally
            {
                cn.Close();
            }
        }
        private int getUserID(string username)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {
                cn.ConnectionString =
                    @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
                cmd.Connection = cn;

                cmd.CommandText = "SELECT UserID FROM SignInInfo WHERE Username = @username";

                cmd.Parameters.AddWithValue("@username", username);
                cn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                return dr.GetInt32(0);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Occurred");
                return 0; // this may lead to erroneous results..
            }
            finally
            {
                cn.Close();
            }
        }
        private string getUserEmail(string username)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            try
            {
                cn.ConnectionString =
                    @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Email FROM SignInInfo WHERE Username = @username";
                cmd.Parameters.AddWithValue("@username", username);
                cn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                return dr.GetString(0);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Occurred");
                return null;
            }
            finally
            {
                cn.Close();
            }
        }
        private string getFname(string username)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            try
            {
                cn.ConnectionString =
                    @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
                cmd.Connection = cn;
                cmd.CommandText = "SELECT fName FROM SignInInfo WHERE Username = @username";
                cmd.Parameters.AddWithValue("@username", username);
                cn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                return dr.GetString(0);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Occurred");
                return null;
            }
            finally
            {
                cn.Close();
            }
        }
        private string getLname(string username)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            try
            {
                cn.ConnectionString =
                    @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
                cmd.Connection = cn;
                cmd.CommandText = "SELECT lName FROM SignInInfo WHERE Username = @username";
                cmd.Parameters.AddWithValue("@username", username);
                cn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                return dr.GetString(0);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Occurred");
                return null;
            }
            finally
            {
                cn.Close();
            }
        }
        private String getAuthorizedPassword(string userName)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {
                cn.ConnectionString =
                    @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
                cmd.Connection = cn;

                cmd.CommandText = "SELECT Password FROM SignInInfo WHERE Username = @username OR Email = @username";

                cmd.Parameters.AddWithValue("@username", userName);

                cn.Open();

                dr= cmd.ExecuteReader();

                dr.Read();

                return dr.GetString(0);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Occurred");
                return null;
            }
            finally
            {
                cn.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string enteredPW = txtPassword.Text;

            try
            {
                //if (usernames.Contains(txtUsername.Text) && passwords.Contains(txtPassword.Text)){
                if (txtUsername.Text == "" || txtPassword.Text == "") {
                    string message = "Username or Password Blank";
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
                else if (enteredPW == getAuthorizedPassword(txtUsername.Text)) {
                    // verified user, assign info to User object (log in)
                    user.setUserID(getUserID(txtUsername.Text));
                    user.setUsername(txtUsername.Text);
                    user.setFname(getFname(txtUsername.Text));
                    user.setLname(getLname(txtUsername.Text));
                    user.setPassword(txtPassword.Text);
                    user.setEmail(getUserEmail(txtUsername.Text));
                    user.setUserType(getUserPermissions(txtUsername.Text));

                    this.Hide();
                    welcomeForm = new WelcomeForm(user);
                    welcomeForm.Owner = this; // why are we setting a form owner? 
                    welcomeForm.Show();
                }
                else {
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
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Occurred");
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
                btnLogin_Click(sender, e);

            }
        }
    }
}
