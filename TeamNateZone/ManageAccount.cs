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
        dbHandler db = new dbHandler(@"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True");
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
            tbCC.Text = user.getCC();
            tbCVV.Text = user.getCVV();
            tbCCExp.Text = user.getCCExp();
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
