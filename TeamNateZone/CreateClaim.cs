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
        Stream fileStream;
        byte[] Databytes;
        string extention;
        string fileName;
        string path;


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

        private void btnFile_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;

            if (datetime.Value > DateTime.Today.AddDays(1))
            {
                MessageBox.Show("Can't file a claim with a date in the future. Try again.","invalid data", buttons);
                datetime.ResetText();
                return;
            }
            else if(detailsTextBox.Text == "" || claimType.SelectedItem == null)
            {
                MessageBox.Show("Please enter a description and claim type", "invalid data", buttons);
                return;
            }
            if (fileStream != null)
            {
                using (BinaryReader br = new BinaryReader(fileStream))
                {
                    Databytes = br.ReadBytes((Int32)fileStream.Length);
                }
            }
            db.file_claim(user.getUserID(), user.getUsername(), user.getEmail(), claimType.SelectedItem.ToString(), detailsTextBox.Text, datetime.Value.ToString(), datetime.Value.ToString(), Databytes, extention, fileName);

            

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
                try
                {
                    fileStream = openFileDialog1.OpenFile();
                    path = openFileDialog1.FileName;
                    txtFileUpload.Text = path;
                    extention = path.Substring(path.LastIndexOf('.'));
                    fileName = Path.GetFileName(path);
                    extention = path.Substring(path.LastIndexOf('.'));
                    MessageBox.Show("Uploaded File!", "Success");
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
