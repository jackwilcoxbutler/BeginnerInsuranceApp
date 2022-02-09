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
        public RegistrationForm()
        {
            InitializeComponent();
        }

        //not tested yet 
        private void storeSignInInfo(string userName, string passWord, string eMail)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            string clearAnce = "client";

            try
            {
                cn.ConnectionString =
                    @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
                cmd.Connection = cn;

                cmd.CommandText = "INSERT INTO SignInInfo(Email, Password, clearance, Username) VALUES (@email, @password, @clear, @username);";


                cmd.Parameters.AddWithValue("@username", userName);
                cmd.Parameters.AddWithValue("@email", eMail);
                cmd.Parameters.AddWithValue("@password", passWord);
                cmd.Parameters.AddWithValue("@clear", clearAnce);

                cn.Open();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Occurred");
            }
            finally
            {
                cn.Close();
            }
        }

        //not tested yet 
        private string getAlreadyDeclaredAccount(string userName, string eMail)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            try
            {
                cn.ConnectionString =
                    @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
                cmd.Connection = cn;

                cmd.CommandText = "SELECT Email, Username FROM SignInInfo WHERE Username = @username OR Email = @email";

                cmd.Parameters.AddWithValue("@username", userName);
                cmd.Parameters.AddWithValue("@email", eMail);

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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "" || txtUsername.Text == "" || txtVerifyPassword.Text == "" || txtEmail.Text == "")
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
            //may have to test to see if this stuff works just started adding some stuff if it doesnt
            //work you can comment it out and continue on with other testing 
            else if (txtEmail.Text == getAlreadyDeclaredAccount(txtUsername.Text, txtEmail.Text) ||
                     txtUsername.Text == getAlreadyDeclaredAccount(txtUsername.Text, txtEmail.Text))
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
                    LoginForm lf = (LoginForm)this.Owner;
                    this.Close();
                    lf.Show();
                }
            }
            /*else if(txtPassword.Text == "test")//FUNCTION TO QUERY FOR EMAIL AND USERNAME)
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
                    LoginForm lf = (LoginForm)this.Owner;
                    this.Close();
                    lf.Show();
                }
            }*/
            else if (txtPassword.Text == txtVerifyPassword.Text)
            {
                string message = "Registration Successful! Click return to log into application.";
                MessageBox.Show(message);
                //search database to see if username or email already exists
                //if not, add username email and password to signininfo database
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
