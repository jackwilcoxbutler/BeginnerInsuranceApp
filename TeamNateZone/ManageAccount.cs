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
            tbCity.Text = user.getCity();
            tbState.Text = user.getState();
            tbZip.Text = user.getZip();
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
        }
    }
}
