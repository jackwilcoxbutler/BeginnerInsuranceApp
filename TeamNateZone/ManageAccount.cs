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
    public partial class ManageAccount : Form
    {
        User user;
        ClientWelcomeForm welcomeForm;
        public ManageAccount(User user)
        {
            InitializeComponent();
            this.user = user;

            //Initialize the display of the user info in the management screen. 
            tbPassword.Text = user.getPassword();
            tbEmail.Text = user.getEmail();
            tbAddress.Text = user.getStreet();
            tbCity.Text = user.getCity();
            tbState.Text = user.getState();
            tbZip.Text = user.getZip();
        }

        private void btnLogout2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logout Successful");
            var newForm = new LoginForm();
            newForm.Show();
            this.Close();
        }

        private Boolean isClosed;
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (pnlDropDown.Height == pnlDropDown.MinimumSize.Height)
                isClosed = true;
            else
                isClosed = false;

            if (isClosed == true)
            {
                pnlDropDown.Height = pnlDropDown.MaximumSize.Height;
            }
            else
            {
                pnlDropDown.Height = pnlDropDown.MinimumSize.Height;
            }
        }

        private void btnBackAM_Click(object sender, EventArgs e)
        {
            this.Hide();
            welcomeForm = new ClientWelcomeForm(user);
            welcomeForm.Owner = this;
            welcomeForm.Show();
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            //Updates the information for the user in the table. 
            user.setPassword(tbPassword.Text);
            user.setEmail(tbEmail.Text);
            user.setStreet(tbAddress.Text);
            user.setCity(tbCity.Text);
            user.setState(tbState.Text);
            user.setZip(tbZip.Text);

            string email = tbEmail.Text;
            string password = tbPassword.Text;
            string street = tbAddress.Text;
            string city = tbCity.Text;
            string state = tbState.Text;
            string zip = tbZip.Text;

            //Updates the information in the SignInInfo Table in the Database 
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {
                cn.ConnectionString =
                    @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
                cmd.Connection = cn;

                cmd.CommandText = "UPDATE SignInInfo SET Email = @email, Password = @password, street = @str, city = @city, state = @st, zip = @zip5 WHERE UserID = @uid";
                cmd.Parameters.AddWithValue("@email", email );
                cmd.Parameters.AddWithValue("@password", password );
                cmd.Parameters.AddWithValue("@str", street);
                cmd.Parameters.AddWithValue("@city", city);
                cmd.Parameters.AddWithValue("@st", state );
                cmd.Parameters.AddWithValue("@zip5", zip);
                cmd.Parameters.AddWithValue("uid", user.getUserID());

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
                MessageBox.Show("Account details updated!", "Success");
                cn.Close();
            }
        }

    }
}
