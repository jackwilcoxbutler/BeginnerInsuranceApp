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
        //not tested yet 
        private void storeSignInInfo(string first, string last, string address, string city, string state, string zip, string userName, string passWord, string eMail)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            int clearance = 0;

            try
            {
                cn.ConnectionString =
                    @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
                cmd.Connection = cn;

                cmd.CommandText = "INSERT INTO SignInInfo(Email, Password, fName, lName, Street, City, State, Zip, clearance, Username) VALUES (@email, @password, @f, @l, @str, @city, @st, @zip5, @clear, @username);";
                cmd.Parameters.AddWithValue("@email", eMail);
                cmd.Parameters.AddWithValue("@password", passWord);
                cmd.Parameters.AddWithValue("@f", first);
                cmd.Parameters.AddWithValue("@l", last);
                cmd.Parameters.AddWithValue("@str", address);
                cmd.Parameters.AddWithValue("@city", city);
                cmd.Parameters.AddWithValue("@st", state);
                cmd.Parameters.AddWithValue("@zip5", zip);
                cmd.Parameters.AddWithValue("@clear", clearance);
                cmd.Parameters.AddWithValue("@username", userName);

                cn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
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
        private string getAlreadyDeclaredEmail(string eMail)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            try
            {
                cn.ConnectionString =
                    @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
                cmd.Connection = cn;

                cmd.CommandText = "SELECT Email FROM SignInInfo WHERE Email = @email";

                cmd.Parameters.AddWithValue("@email", eMail);

                cn.Open();

                dr = cmd.ExecuteReader();

                dr.Read();

                try
                {
                    return dr.GetString(0);
                }
                catch (Exception e)
                {
                    return "";
                }
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

        private string getAlreadyDeclaredUsername(string userName)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            try
            {
                cn.ConnectionString =
                    @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
                cmd.Connection = cn;

                cmd.CommandText = "SELECT Username FROM SignInInfo WHERE Username = @username";

                cmd.Parameters.AddWithValue("@username", userName);

                cn.Open();

                dr = cmd.ExecuteReader();

                dr.Read();

                try
                {
                    return dr.GetString(0);
                }
                catch (Exception e)
                {
                    return "";
                }
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
            try
            {
                if (txtPassword.Text.Equals("") || txtUsername.Text.Equals("") || txtVerifyPassword.Text.Equals("") ||
                    txtEmail.Text.Equals("") || txtFname.Text.Equals("") || txtLname.Text.Equals(""))
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
                else if (txtEmail.Text.Equals(getAlreadyDeclaredEmail(txtEmail.Text)) ||
                         txtUsername.Text.Equals(getAlreadyDeclaredUsername(txtUsername.Text)))
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
                    MessageBox.Show(message);
                    storeSignInInfo(txtFname.Text, txtLname.Text, txtAddress.Text, txtCity.Text, comboState.SelectedItem.ToString(), txtZip.Text, txtUsername.Text, txtPassword.Text, txtEmail.Text);
                    User user = new User(getUserID(txtUsername.Text), txtFname.Text, txtLname.Text, txtUsername.Text, txtPassword.Text, txtEmail.Text, 0);
                    WelcomeForm wf = new WelcomeForm(user);
                    this.Close();
                    wf.Show();
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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            LoginForm lf = (LoginForm)this.Owner;
            this.Close();
            lf.Show();
        }

        private void txtVerifyPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnRegister_Click(sender, e);
            }
        }
    }
}
