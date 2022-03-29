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
using System.IO;
using System.Security;


namespace TeamNateZone
{
    public partial class CreateClaim : Form
    {
        User user;
        Claim claim;
        ClientWelcomeForm welcomeForm;
        // images list will become a data member of the upcoming View Profile form //
        List<Stream> images = new List<Stream>();
        dbHandler db = new dbHandler(@"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True");
        public CreateClaim(User user)
        {
            InitializeComponent();
            this.user = user;
            datetime.Value = DateTime.Now;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            welcomeForm = new ClientWelcomeForm(user);
            welcomeForm.Owner = this;
            welcomeForm.Show();
        }

        private async void btnFile_Click(object sender, EventArgs e)
        {
            db.file_claim(user.getUserID(), user.getUsername(), user.getEmail(), claimType.SelectedItem.ToString(), detailsTextBox.Text, datetime.Value.ToString(), datetime.Value.ToString());

            // this will be the functionality for uploading media to the database from the upcoming View Profile form //
            // foreach (Stream image in images)
            // {
            //     SqlCommand statement = new SqlCommand($"INSERT INTO ClaimMedia(UID,content) VALUES ({user.getUserID()},{image})", cn);
            // }
            MessageBox.Show("Your claim has been successfully submitted! Check your list of claims to track its status.", "Success!");
            welcomeForm = new ClientWelcomeForm(user);
            this.Close();
            welcomeForm.Show();


        //    claim = new Claim(user.getUserID(), claimType.SelectedItem.ToString(), detailsTextBox.Text, datetime.Value);
        //    if (claim.fileClaim(user))
        //    {
        //        MessageBox.Show("Your claim has been successfully submitted! Check your list of claims to track its status.", "Success!");

            //        welcomeForm = new ClientWelcomeForm(user);
            //        this.Close();
            //        welcomeForm.Show();
            //    }
            //WORKS JUST NEED TO ADD IMAGE HANDLING
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

        private void btnLogout2_Click(object sender, EventArgs e)
        {
            var newForm = new LoginForm();
            newForm.Show();
            this.Close();

        }

        // this functionality will migrate to View Profile form once it is created //
        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // hold in local memory until user actually files claim
                    Stream image = openFileDialog1.OpenFile();
                    images.Add(image);
                    txtFileUpload.Text = openFileDialog1.FileName;
                    MessageBox.Show("Uploaded image!", "Success");
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }
    }
 }
