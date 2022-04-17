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

namespace TeamNateZone
{
    
    public partial class ClientViewClaimImages : Form
    {
        User user;
        claimList claimListForm;
        dbHandler db;
        Claim claim;
        private int cid;
        public ClientViewClaimImages(User user, int cid)
        {
            InitializeComponent();
            this.user = user;
            //Claim c = new Claim();
            this.claim = new Claim(cid);

            this.claim.initializeClaim(cid);
            //setClaim(cid);
            this.cid = cid;
            this.db = new dbHandler(@"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True");

            //setting up the image to display
            byte[] fileData = db.get_file_claims(cid.ToString());

            Stream stream = new MemoryStream(fileData);

            Image img = System.Drawing.Bitmap.FromStream(stream);
            ClaimImgBox.BackgroundImage = img;
            ClaimImgBox.Visible = true;
            
        }
       /* public  void setClaim(int cid)
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {
                connection.ConnectionString =
                    @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
                cmd.Connection = connection;

                cmd.CommandText = "SELECT * FROM Claims WHERE ClaimId = @cid";

                cmd.Parameters.AddWithValue("@ClaimId", cid);

                connection.Open();

                dr = cmd.ExecuteReader();

                dr.Read();
                Claim c = new Claim(
                    dr.GetInt32(1), //userid
                    dr.GetInt32(11), //cmid
                    dr.GetInt32(12), //fmid
                    dr.GetString(4), //claim type
                    dr.GetString(5), //claim desc
                    dr.GetString(8), //status
                    dr.GetString(10), //payment status
                    dr.GetDateTime(6), //start date
                    dr.GetDateTime(7), //end date
                    dr.GetDateTime(13), //est end datee
                    dr.GetDateTime(9),//last update
                    dr.GetInt32(0)); //claim id

                claim = c;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Occurred");
            }
            finally
            {
                connection.Close();
            }
        }
        */
        //need to do a get name for cm and fm
        private void loadClaimInfo_btn_Click(object sender, EventArgs e)
        {
            //things not popping up on load button clicked:
            //1: claims Desc
            //2: claim type
            //3: claim status
            DateTime minDateTime = new DateTime(1900, 1, 1);
            DateTime maxDateTime = new DateTime(2100, 1, 1);
            claimDescTxtBox.Text = claim.getClaimDesc(cid); // not displaying
            claimIDTxt.Text = cid.ToString();
            claimTypeTxt.Text = claim.getClaimType(cid); //not displaying
            startDateTxt.Text = claim.getStartDate(cid).ToString();
            statusTxt.Text = claim.getClaimStatus(cid); //not displaying
            lastUpdateTxt.Text = claim.getLastUpdate(cid).ToString(); 
            //get end date or estimated end date
            if (claim.getEndDate(cid).Equals(minDateTime))
            {
                if (claim.getEstEndDate(cid).Equals(maxDateTime))
                {
                    endDateTxt.Text = "N/A";
                    cmForClaimTxt.Text = "N/A";
                }
                else
                {
                    endDateTxt.Text = claim.getEstEndDate(cid).ToString();
                    cmForClaimTxt.Text = claim.getCMFNane(claim.getCmID(cid)) + " " + claim.getCMLNane(claim.getCmID(cid));
                }
            }
            else
            {
                endDateTxt.Text = claim.getEndDate(cid).ToString();
                cmForClaimTxt.Text = claim.getCMFNane(claim.getCmID(cid)) + " " + claim.getCMLNane(claim.getCmID(cid));
            }

            if (claim.getFmID(cid) == 0)
            {
                paymentStatTxt.Text = "N/A";
                estimatePaymentTxt.Text = "N/A";
                fmForClaimTxt.Text = "N/A";

            }
            else
            {
                if (claim.getPaymentStatus(cid) == "")
                {
                    paymentStatTxt.Text = "N/A";
                }
                else
                {
                    paymentStatTxt.Text = claim.getPaymentStatus(cid);
                }

                if (claim.getEstimatedAmt(cid) == 0)
                {
                    estimatePaymentTxt.Text = "N/A";
                }
                else
                {
                    estimatePaymentTxt.Text = claim.getEstimatedAmt(cid).ToString();
                }

                fmForClaimTxt.Text = claim.getFMFNane(claim.getFmID(cid)) + " "+ claim.getFMLNane(claim.getFmID(cid));
            }
            
        }
        private void claimIDTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void fmForClaimTxt_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
