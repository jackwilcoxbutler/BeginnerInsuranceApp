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
        AdminWelcomeForm AdminwelcomeForm;

        dbHandler db = new dbHandler(@"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True");

        public ManageAccount(User user)
        {
            InitializeComponent();
            this.user = user;

            //Initialize the display of the user info in the management screen.
            tbUserName.Text = user.getUsername();
            tbPassword.Text = user.getPassword();
            tbEmail.Text = user.getEmail();
            tbAddress.Text = user.getStreet();
            if(user.getCity() == "")
            {
                tbCity.Clear();
            }
            else
            {
                tbCity.Text = user.getCity();
            }
            if (user.getState() == "  ")
            {
                tbState.Clear();
            }
            else
            {
                tbState.Text = user.getState();
            }
            if (user.getZip() == "     ")
            {
                tbZip.Clear();
            }
            else
            {
                tbZip.Text = user.getZip();
            }
            //            String s = user.getCC();
            // WE SHOULD NOT ATTACH PAYMENT INFORMATION TO OUR LOCAL USER OBJECT
            /*
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
            */
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
                AdminwelcomeForm = new AdminWelcomeForm(user);
                AdminwelcomeForm.Owner = this;
                AdminwelcomeForm.Show();
            }
            else
            {
                MessageBox.Show("Error Occurred");
            }
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            if (txtVerify.Text == tbPassword.Text)
            {
                db.update_user_profile(user.getUserID(), tbEmail.Text, tbPassword.Text, tbAddress.Text, tbCity.Text, tbState.Text, tbZip.Text);
                // the following line will not work until the database is updated to include the new Payment table.
                // db.update_payment_info(user.getUserID(), tbCC.Text, tbCVV.Text, tbCCExp.Text);

                // Updates the information for the user locally. Avoid using `user = db.get_user_profile(user.getUsername())` to get the updated information due to potential synchronization issues.
                user.setPassword(tbPassword.Text);
                user.setEmail(tbEmail.Text);
                user.setStreet(tbAddress.Text);
                user.setCity(tbCity.Text);
                user.setState(tbState.Text);
                user.setZip(tbZip.Text);

                tbAddress.ReadOnly = true;
                tbPassword.ReadOnly = true;
                tbEmail.ReadOnly = true;
                tbCity.ReadOnly = true;
                tbState.ReadOnly = true;
                tbZip.ReadOnly = true;

                //Plan to make this a future release in the future. 
                //tbCC14.ReadOnly = true;
                //tbCC24.ReadOnly = true;
                //tbCC34.ReadOnly = true;
                //tbCVV.ReadOnly = true;
               // tbCCExp.ReadOnly = true;
                
                txtVerify.Clear();
                btnEdit.Visible= true;
                btnCancel.Visible = false;
                btnUpdatePassword.Visible = false;
                lbVerify.Visible = false;
                txtVerify.Visible = false;
                btnStartView.Visible = false;
                btnStopView.Visible = false;
                tbPassword.PasswordChar = '•';

                MessageBox.Show("User Information Updated.", "Success");
            }
            else
            {
                MessageBox.Show("Passwords do not match", "Try again");
                //cn.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            tbAddress.ReadOnly = false;
            tbPassword.ReadOnly = false;
            tbEmail.ReadOnly = false;
            tbCity.ReadOnly = false;
            tbState.ReadOnly = false;
            tbZip.ReadOnly = false;

            //Part of Future release on credit card info
            //tbCC14.ReadOnly = false;
            //tbCC24.ReadOnly = false;
            //tbCC34.ReadOnly = false;
            //tbCVV.ReadOnly = false;
            //tbCCExp.ReadOnly = false;

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
            
            //if (String.IsNullOrEmpty(Regex.Replace(user.getCC(), @"\s+", " ")))
            //{ }
            //else
            //{
            //    tbCC14.Text = user.getCC().Substring(0, 4);
            //    tbCC24.Text = user.getCC().Substring(4, 4);
            //    tbCC34.Text = user.getCC().Substring(8, 4);
            //}
            //tbCVV.Text = user.getCVV();
            //tbCCExp.Text = user.getCCExp();

            btnUpdatePassword.Visible = false;
            lbVerify.Visible = false;
            txtVerify.Visible = false;
            btnCancel.Visible = false;
            btnStartView.Visible = false;
            btnStopView.Visible = false;
            btnEdit.Visible = true;

            tbAddress.ReadOnly = true;
            tbPassword.ReadOnly = true;
            tbEmail.ReadOnly = true;
            tbCity.ReadOnly = true;
            tbState.ReadOnly = true;
            tbZip.ReadOnly = true;

            //Plan to make this a future release topic
            //tbCC14.ReadOnly = true;
            //tbCC24.ReadOnly = true;
            //tbCC34.ReadOnly = true;
            //tbCVV.ReadOnly = true;
            //tbCCExp.ReadOnly = true;
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
