using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamNateZone
{
    public partial class claimList : Form
    {
        User user;
        ClientWelcomeForm welcomeForm;
        dbHandler db;
        public claimList(User user)
        {
            InitializeComponent();
            this.user = user;
            this.db = new dbHandler(@"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True");

        }

        private void btnReturnToWelcome_Click(object sender, EventArgs e)
        {
            this.Hide();
            welcomeForm = new ClientWelcomeForm(user);
            welcomeForm.Owner = this;
            welcomeForm.Show();
        }


        private void claimList_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True");

            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Claims WHERE UserID = @userid", cn);
            da.SelectCommand.Parameters.AddWithValue("userid", user.getUserID());
            DataTable dtbl = new DataTable();





            da.Fill(dtbl);



            dataGridView1.DataSource = dtbl;


            cn.Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(enterClaimIDTxt.Text.Trim(), out int result))
            {
                lblStatus.Text = "Please enter a Numerical Value";
                return;
            }

            string ClaimID = enterClaimIDTxt.Text;
            int ClaimUser = db.get_userFromClaim(ClaimID);
            Console.WriteLine(db.get_fileType_Claim(ClaimID));
            if (user.getUserID() != ClaimUser)
            {
                lblStatus.Text = "Please enter a valid Claim ID";
                return;
            }
            else if (string.IsNullOrEmpty(enterClaimIDTxt.Text))
            {
                lblStatus.Text = "Please enter a Claim ID to View Image";
            }
            else if (db.get_fileType_Claim(ClaimID) == ".jpg" || db.get_fileType_Claim(ClaimID) == ".png")
            {
                byte[] fileData = db.get_file_claims(ClaimID);

                Stream stream = new MemoryStream(fileData);

                Image img = System.Drawing.Bitmap.FromStream(stream);
                testPictureBox.BackgroundImage = img;
                testPictureBox.Visible = true;
                maximize_rndButton1.Visible = true;
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(" The File you are trying to view is not in the correct format to view \n If a file is attached, You can download the file using the download button");
            }


        }

        private void rndImageDownload_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(enterClaimIDTxt.Text.Trim(), out int result))
            {
                lblStatus.Text = "Please enter a Numerical Value";
                return;
            }

            string ClaimID = enterClaimIDTxt.Text;
            string fileName = db.get_filename_claim(ClaimID);

            int ClaimUser = db.get_userFromClaim(ClaimID);
            if (user.getUserID() != ClaimUser)
            {
                lblStatus.Text = "Please enter a valid Claim ID";
                return;
            }
            else if (!string.IsNullOrEmpty(fileName))
            {
                fileName = fileName.Trim();
                saveFileDialog1.FileName = fileName;
                saveFileDialog1.DefaultExt = db.get_fileType_Claim(ClaimID);
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    byte[] fileContent = db.get_file_claims(ClaimID);
                    File.WriteAllBytes(fileName, fileContent);
                    lblStatus.Text = "File downloaded Successfully";
                }
                else
                {
                    lblStatus.Text = "Download Canceled";
                }

            }
            else
            {
                lblStatus.Text = "No Attachment to download";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rndButton1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(enterClaimIDTxt.Text, out int result))
            {
                ClientViewClaimImages imageWindow = new ClientViewClaimImages(user, int.Parse(enterClaimIDTxt.Text.Trim()));
                imageWindow.Show();
            }
            else
            {
                lblStatus.Text = "Please Enter a numarical Claim Id ";
            }
            {

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Claim claim = new Claim((int)dataGridView1.SelectedRows[0].Cells[0].Value);
                ClientViewClaimImages form = new ClientViewClaimImages(claim.claimID);
                form.Show();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Claim claim = new Claim((int)dataGridView1.SelectedRows[0].Cells[0].Value);
                ClientViewClaimImages form = new ClientViewClaimImages(claim.claimID);
                form.Show();
            }
        }
    }
}
