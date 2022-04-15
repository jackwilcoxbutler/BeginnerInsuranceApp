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
            //int indexOfClaimCell = dataGridView1.CurrentCell.RowIndex;
            ////indexOfClaimCell--;

            //while (dataGridView1.Rows[indexOfClaimCell].Cells[0].FormattedValue.ToString() != enterClaimIDTxt.Text)
            //{
            //    indexOfClaimCell++;
            //}
            //SqlConnection cn = new SqlConnection();
            //SqlCommand cmd = new SqlCommand();
            //SqlDataReader dr;
            //try
            //{
            //    cn.ConnectionString =
            //        @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
            //    cmd.Connection = cn;
            //    cmd.CommandText = "SELECT content FROM ClaimMedia WHERE UID=@uid";
            //    cmd.Parameters.AddWithValue("@uid", user.getUserID());
            //    cn.Open();
            //    dr = cmd.ExecuteReader();
            //    //dr.Read();
            //    //            dr.Read(); // advance to second image (panda)
            //    //check to see if they typed in a correct claim ID
            //    if (indexOfClaimCell <= dataGridView1.RowCount)
            //    {
            //        //loop through to the proper claim in the datagrindtable to find corrisponding submitted images
            //        for (int i = 0; i < indexOfClaimCell; i++)
            //        {
            //            dr.Read();
            //        }
            //        Image img = System.Drawing.Bitmap.FromStream(dr.GetStream(0));
            //        testPictureBox.Image = img;
            //        testPictureBox.Visible = true;
            //    }


            //    //Image img = System.Drawing.Bitmap.FromStream(dr.GetStream(0));
            //    //testPictureBox.Image = img;
            //    //testPictureBox.Visible = true;
            //}
            //catch(Exception err) 
            //{
            //    lblStatus.Text = "No Image available to view";
            //}
            //finally
            //{
            //    cn.Close();
            //}
            //SaveFileDialog dialog = new SaveFileDialog();
            lblStatus.Text = "work in progess. Come back later";
        }

        private void rndImageDownload_Click(object sender, EventArgs e)
        {
            string ClaimID = enterClaimIDTxt.Text;
            string fileName = db.get_filename_claim(ClaimID);

            if (!string.IsNullOrEmpty(fileName))
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
                    lblStatus.Text = "There has been a error downloading your file. Please speak with an Admin";
                }
            }
            else
            {
                lblStatus.Text = "No Attachemt to download";
            }          
        }
    }
}
