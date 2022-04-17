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
        private int cid,cmid,fmid,uid,estAmt;
        private string cType, cDesc, stat, payStat, fmLast, fmFirst, cmLast, cmFirst;
        private DateTime start, end, update, estEnd;
        private DateTime minDateTime = new DateTime(1900, 1, 1);
        private DateTime maxDateTime = new DateTime(2100, 1, 1);
        public ClientViewClaimImages(User user, int cid)
        {
            InitializeComponent();
            this.user = user;
            this.cid = cid;
            this.db = new dbHandler(@"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True");

            //setting up the image to display
            byte[] fileData = db.get_file_claims(cid.ToString());

            Stream stream = new MemoryStream(fileData);

            Image img = System.Drawing.Bitmap.FromStream(stream);
            ClaimImgBox.BackgroundImage = img;
            ClaimImgBox.Visible = true;
            
        }
        public void setClaimInfo(int claimid)
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

                cmd.Parameters.AddWithValue("@cid", claimid);

                connection.Open();

                dr = cmd.ExecuteReader();

                dr.Read();
                
                //uid
                try
                {
                    this.uid = dr.GetInt32(1); //userid
                }
                catch (Exception e)
                {
                    this.uid = 0;
                }
                //cmid
                try
                {
                    this.cmid = dr.GetInt32(11); //cmid
                }
                catch (Exception e)
                {
                    this.cmid = 0;
                }
                //fmid
                try
                {
                    this.fmid = dr.GetInt32(12); //fmid
                }
                catch (Exception e)
                {
                    this.fmid = 0;
                }
                //claimtype
                try
                {
                    this.cType = dr.GetString(4); //claim type
                }
                catch (Exception e)
                {
                    this.cType = "";
                }
                //claim desc
                try
                {
                    this.cDesc = dr.GetString(5); //claim desc
                }
                catch (Exception e)
                {
                    this.cDesc = "";
                }
                //status
                try
                {
                    this.stat = dr.GetString(8); //status
                }
                catch (Exception e)
                {
                    this.stat = "";
                }
                //payment status
                try
                {
                    this.payStat = dr.GetString(10); //payment status
                }
                catch (Exception e)
                {
                    this.payStat = "";
                }
                //start date
                try
                {
                    this.start = dr.GetDateTime(6); //start date
                }
                catch (Exception e)
                {
                    this.start = minDateTime;
                }
                //end date
                try
                {
                    this.end = dr.GetDateTime(7); //end date
                }
                catch (Exception e)
                {
                    this.end = minDateTime;
                }
                //est end date
                try
                {
                    this.estEnd = dr.GetDateTime(13); //est end datee
                }
                catch (Exception e)
                {
                    this.estEnd = maxDateTime;
                }
                //last update
                try
                {
                    this.update = dr.GetDateTime(9); //last update
                }
                catch (Exception e)
                {
                    this.update = minDateTime;
                }
                
                this.estAmt = dr.GetInt32(14); //estimated amount
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Occurred--set ");
            }
            finally
            {
                connection.Close();
            }
        }
        
        //need to do a get name for cm and fm
        private void loadClaimInfo_btn_Click(object sender, EventArgs e)
        {
            setClaimInfo(this.cid);
            fmFirst = getFMFNane(fmid);
            fmLast = getFMLNane(fmid);
            cmFirst = getCMFNane(cmid);
            cmLast = getCMLNane(cmid);
            claimDescTxtBox.Text = cDesc; // not displaying
            claimIDTxt.Text = cid.ToString();
            claimTypeTxt.Text = cType; //not displaying
            startDateTxt.Text = start.ToString();
            statusTxt.Text = stat; //not displaying
            lastUpdateTxt.Text = update.ToString();
            //get end date or estimated end date
            if (end.Equals(minDateTime))
            {
                if (estEnd.Equals(maxDateTime))
                {
                    endDateTxt.Text = "N/A";
                    cmForClaimTxt.Text = "N/A";
                }
                else
                {
                    endDateTxt.Text = estEnd.ToString();
                    //cmForClaimTxt.Text = cmid.ToString();
                    cmForClaimTxt.Text = cmFirst + " " + cmLast;
                }
            }
            else
            {
                endDateTxt.Text = end.ToString();
                //cmForClaimTxt.Text = cmid.ToString();
                cmForClaimTxt.Text = cmFirst + " " + cmLast; 
            }

            if (fmid == 0)
            {
                paymentStatTxt.Text = "N/A";
                estimatePaymentTxt.Text = "N/A";
                fmForClaimTxt.Text = "N/A";

            }
            else
            {
                if (payStat == "")
                {
                    paymentStatTxt.Text = "N/A";
                }
                else
                {
                    paymentStatTxt.Text = payStat;
                }

                if (estAmt == 0)
                {
                    estimatePaymentTxt.Text = "N/A";
                }
                else
                {
                    estimatePaymentTxt.Text = estAmt.ToString();
                }
                //fmForClaimTxt.Text = fmid.ToString();
                fmForClaimTxt.Text = fmFirst + " " + fmLast;
            }
            

        }
        private void claimIDTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void fmForClaimTxt_TextChanged(object sender, EventArgs e)
        {

        }
        public string getCMFNane(int cmid)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {
                cn.ConnectionString =
                    @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
                cmd.Connection = cn;
                cmd.CommandText = "SELECT fName FROM SignInInfo WHERE UserId = @cmid";
                cmd.Parameters.AddWithValue("@cmid", cmid);
                cn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                return dr.GetString(0);
            }
            catch (Exception err)
            {
                return "";
            }
            finally
            {
                cn.Close();
            }
        }
        public string getCMLNane(int cmid)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {
                cn.ConnectionString =
                    @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
                cmd.Connection = cn;
                cmd.CommandText = "SELECT lName FROM SignInInfo WHERE UserId = @cmid";
                cmd.Parameters.AddWithValue("@cmid", cmid);
                cn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                return dr.GetString(0);
            }
            catch (Exception err)
            {
                return "";
            }
            finally
            {
                cn.Close();
            }
        }
        public string getFMFNane(int fmid)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {
                cn.ConnectionString =
                    @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
                cmd.Connection = cn;
                cmd.CommandText = "SELECT fName FROM SignInInfo WHERE UserId = @fmid";
                cmd.Parameters.AddWithValue("@fmid", fmid);
                cn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                return dr.GetString(0);
            }
            catch (Exception err)
            {
                return "";
            }
            finally
            {
                cn.Close();
            }
        }
        public string getFMLNane(int fmid)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {
                cn.ConnectionString =
                    @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
                cmd.Connection = cn;
                cmd.CommandText = "SELECT lName FROM SignInInfo WHERE UserId = @fmid";
                cmd.Parameters.AddWithValue("@fmid", fmid);
                cn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                return dr.GetString(0);
            }
            catch (Exception err)
            {
                return "";
            }
            finally
            {
                cn.Close();
            }
        }

    }
}
