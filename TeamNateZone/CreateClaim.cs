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
        List<Stream> images = new List<Stream>();
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

        private void btnFile_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            string status = "Submitted";
            try
            {
                cn.ConnectionString =
                    @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
                cmd.Connection = cn;

                cmd.CommandText = "INSERT INTO Claims(UserID, Username, UserEmail, Claim_Type, Claim_Description, StartDate, LastUpdate, Status) VALUES (@id, @username, @email, @type, @desc, @date, @update, @stat)";
                cmd.Parameters.AddWithValue("@id", user.getUserID());
                cmd.Parameters.AddWithValue("@username", user.getUsername());
                cmd.Parameters.AddWithValue("@email", user.getEmail());
                cmd.Parameters.AddWithValue("@type", claimType.SelectedItem.ToString()); // may not have to ToString(), will try later
                cmd.Parameters.AddWithValue("@desc", detailsTextBox.Text);
                cmd.Parameters.AddWithValue("@date", datetime.Value.ToString()); // again, may not need to ToString()
                cmd.Parameters.AddWithValue("@update", datetime.Value.ToString());
                cmd.Parameters.AddWithValue("@stat", status);

                cn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                cn.Close();
                // restart connection for media upload
                foreach (Stream image in images)
                {
                    SqlCommand statement = new SqlCommand($"INSERT INTO ClaimMedia(UID,content) VALUES ({user.getUserID()},{image})", cn);
                }

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
        
        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Image img = Image.FromFile(openFileDialog1.FileName);
                try
                {
                    // hold in local memory until user actually files claim
                    Stream image = openFileDialog1.OpenFile();
                    images.Add(image);
                    txtFileUpload.Text = openFileDialog1.FileName;
                    //var filePath = openFileDialog1.FileName;
                    /*
                    using (Stream content = openFileDialog1.OpenFile())
                    {
                        // store str object in database
                        //StreamReader reader = new StreamReader(content);
                        SqlConnection cn = new SqlConnection();
                        SqlCommand cmd = new SqlCommand();

                        cn.ConnectionString = @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
                        cmd.Connection = cn;

                        cmd.CommandText = "INSERT INTO ClaimMedia(UID,content) VALUES (@ui,@img)";
                        cmd.Parameters.AddWithValue("@ui", user.getUserID());
                        cmd.Parameters.AddWithValue("@img", content);

                        cn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    */
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
