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
using System.Text.RegularExpressions;

namespace TeamNateZone
{
    public partial class ManageAccount : Form
    {
        User user;
        ClientWelcomeForm welcomeForm;
        CMWelcomeForm cmwelcomeForm;
        FMWelcomeForm fmwelcomeForm;
        
        public ManageAccount(User user)
        {
            InitializeComponent();
            this.user = user;

            //Initialize the display of the user info in the management screen. 
            tbUserName.Text = user.getUsername();
            tbPassword.Text = user.getPassword();
            tbEmail.Text = user.getEmail();
            tbAddress.Text = user.getStreet();
            tbCity.Text = user.getCity();
            tbState.Text = user.getState();
            tbZip.Text = user.getZip();
            String s = user.getCC();
           
            if(!String.IsNullOrWhiteSpace(s))
            {
            //}
            //else 
            //{ 
                tbCC14.Text = user.getCC().Substring(0, 4);
                tbCC24.Text = user.getCC().Substring(4, 4);
                tbCC34.Text = user.getCC().Substring(8, 4);
            }
            tbCVV.Text = user.getCVV();
            tbCCExp.Text = user.getCCExp();

            btnUpdatePassword.Visible = false;
            lbVerify.Visible = false;
            txtVerify.Visible = false;
            btnCancel.Visible = false;
            btnStartView.Visible = false;
            btnStopView.Visible = false;

        }
        private void btnlogout_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }


        private void btnBackAM_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (user.getRole() == "Client")
            {
                welcomeForm = new ClientWelcomeForm(user);
                welcomeForm.Owner = this;
                welcomeForm.Show();
            }
            else if(user.getRole() == "Claims Manager")
            {
                cmwelcomeForm = new CMWelcomeForm(user);
                cmwelcomeForm.Owner = this;
                cmwelcomeForm.Show();
            }
            else if (user.getRole() == "Finance Manager")
            {
                fmwelcomeForm = new FMWelcomeForm(user);
                fmwelcomeForm.Owner = this;
                fmwelcomeForm.Show();
            }
            else if (user.getRole() == "Admin")
            {
                welcomeForm = new ClientWelcomeForm(user);
                welcomeForm.Owner = this;
                welcomeForm.Show();
            }
            else
            {
                MessageBox.Show("Error Occurred");
            }
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
            user.setCC(tbCC14.Text + tbCC24.Text + tbCC34.Text);
            user.setCCExp(tbCCExp.Text);
            user.setCVV(tbCVV.Text);

            string email = tbEmail.Text;
            string password = tbPassword.Text;
            string street = tbAddress.Text;
            string city = tbCity.Text;
            string state = tbState.Text;
            string zip = tbZip.Text;
            string cc = tbCC14.Text + tbCC24.Text + tbCC34.Text;
            string cvv = tbCVV.Text;
            string ccexp = tbCCExp.Text; 

            //Updates the information in the SignInInfo Table in the Database 
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            if (txtVerify.Text == tbPassword.Text)
            {
                try
                {
                    cn.ConnectionString =
                        @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
                    cmd.Connection = cn;

                    
                    cmd.CommandText = "UPDATE SignInInfo SET Email = @email, Password = @password, street = @str, city = @city, state = @st, zip = @zip5, CreditNumber = @cc, CVV = @cvv, CCExpiration = @ccexp WHERE UserID = @uid";
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@str", street);
                    cmd.Parameters.AddWithValue("@city", city);
                    cmd.Parameters.AddWithValue("@st", state);
                    cmd.Parameters.AddWithValue("@zip5", zip);
                    cmd.Parameters.AddWithValue("uid", user.getUserID());
                    cmd.Parameters.AddWithValue("@cc", cc);
                    cmd.Parameters.AddWithValue("@ccexp", ccexp);
                    cmd.Parameters.AddWithValue("@cvv", cvv);


                    cn.Open();
                    dr = cmd.ExecuteReader();
                    dr.Read();

                    tbAddress.ReadOnly = true;
                    tbPassword.ReadOnly = true;
                    tbEmail.ReadOnly = true;
                    tbCity.ReadOnly = true;
                    tbState.ReadOnly = true;
                    tbZip.ReadOnly = true;
                    tbCC14.ReadOnly = true;
                    tbCC24.ReadOnly = true;
                    tbCC34.ReadOnly = true;
                    tbCVV.ReadOnly = true;
                    tbCCExp.ReadOnly = true;

                    btnUpdatePassword.Visible = false;
                    lbVerify.Visible = false;
                    txtVerify.Visible = false;
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
            else
            {
                MessageBox.Show("Passwords do not match", "Try again");
                cn.Close();
            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            tbAddress.ReadOnly = false;
            tbPassword.ReadOnly = false;
            tbEmail.ReadOnly = false;
            tbCity.ReadOnly = false;
            tbState.ReadOnly = false;
            tbZip.ReadOnly = false;
            tbCC14.ReadOnly = false;
            tbCC24.ReadOnly = false;
            tbCC34.ReadOnly = false;
            tbCVV.ReadOnly = false;
            tbCCExp.ReadOnly = false;

            btnUpdatePassword.Visible = true;
            lbVerify.Visible = true;
            txtVerify.Visible = true;
            btnEdit.Visible = false;
            btnCancel.Visible = true;
            btnStartView.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbUserName.Text = user.getUsername();
            tbPassword.Text = user.getPassword();
            tbEmail.Text = user.getEmail();
            tbAddress.Text = user.getStreet();
            tbCity.Text = user.getCity();
            tbState.Text = user.getState();
            tbZip.Text = user.getZip();
            if (String.IsNullOrEmpty(Regex.Replace(user.getCC(), @"\s+", " ")))
            {}
            else
            {
                tbCC14.Text = user.getCC().Substring(0, 4);
                tbCC24.Text = user.getCC().Substring(4, 4);
                tbCC34.Text = user.getCC().Substring(8, 4);
            }
            tbCVV.Text = user.getCVV();
            tbCCExp.Text = user.getCCExp();

            btnUpdatePassword.Visible = false;
            lbVerify.Visible = false;
            txtVerify.Visible = false;
            btnCancel.Visible = false;
            btnStartView.Visible = false;
            btnStopView.Visible = false;
            btnEdit.Visible = true;

        }

        private void btnStartView_Click(object sender, EventArgs e)
        {
            txtVerify.PasswordChar = '\0';
            tbPassword.PasswordChar = '\0';
            btnStartView.Visible = false;
            btnStopView.Visible = true;

        }

        private void btnStopView_Click(object sender, EventArgs e)
        {
            txtVerify.PasswordChar = '•';
            tbPassword.PasswordChar = '•';
            btnStartView.Visible = true;
            btnStopView.Visible = false;
        }
    }
}
