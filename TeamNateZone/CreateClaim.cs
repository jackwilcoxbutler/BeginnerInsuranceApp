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
    public partial class CreateClaim : Form
    {
        User user;
        WelcomeForm welcomeForm;
        public CreateClaim(User user)
        {
            InitializeComponent();
            this.user = user;
        }
        /* commenting out until we determine if the datetime box deprecates this

        private void txtDate_TextChanged(object sender, EventArgs e)
        {
            DateTime thisDay = DateTime.Today;
            txtDate.ReadOnly = true;
            txtDate.Text = thisDay.ToShortDateString();
        }
        */
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            welcomeForm = new WelcomeForm(user);
            welcomeForm.Owner = this;
            welcomeForm.Show();
        }

<<<<<<< HEAD
        private void btnFile_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {
                cn.ConnectionString =
                    @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
                cmd.Connection = cn;

                cmd.CommandText = "INSERT INTO Claims(UserID, Username, UserEmail, Claim_Type, Claim_Description, StartDate) VALUES (@id, @username, @email, @type, @desc, @date)";
                cmd.Parameters.AddWithValue("@id", user.getUserID());
                cmd.Parameters.AddWithValue("@username", user.getUsername());
                cmd.Parameters.AddWithValue("@email", user.getEmail());
                cmd.Parameters.AddWithValue("@type", claimType.SelectedItem.ToString()); // may not have to ToString(), will try later
                cmd.Parameters.AddWithValue("@desc", detailsTextBox.Text);
                cmd.Parameters.AddWithValue("@date", datetime.Value.ToString()); // again, may not need to ToString()

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

            MessageBox.Show("Your claim has been successfully submitted! Check your list of claims to track its status.", "Success!");
            welcomeForm = new WelcomeForm(user);
            this.Hide();
            welcomeForm.Show();
=======
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

        private void btnLogout2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logout Successful");
            var newForm = new LoginForm();
            newForm.Show();
            this.Close();
>>>>>>> 451c61d8e2e8013e8809ed46785e7f94e1848e92
        }
    }
}
