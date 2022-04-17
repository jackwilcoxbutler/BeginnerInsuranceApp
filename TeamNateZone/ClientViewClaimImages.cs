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
        User user,fm,cm;
        claimList claimListForm;
        Claim claim;
        dbHandler db;
        private int cid,cmid,fmid,uid,estAmt;
        private string cType, cDesc, stat, payStat,fmUser,cmUser;
        private DateTime start, end, update, estEnd;
        private DateTime minDateTime = new DateTime(1900, 1, 1);
        private DateTime maxDateTime = new DateTime(2100, 1, 1);
        public ClientViewClaimImages(User user, int cid)
        {
            InitializeComponent();
            this.user = user;
            this.cid = cid;
            this.db = new dbHandler(@"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True");
            claim = new Claim(cid);
            //setting up the image to display
            byte[] fileData = db.get_file_claims(cid.ToString());
            ShowClaimInfo();
            if (fileData != null)
            {
                Stream stream = new MemoryStream(fileData);
                Image img = System.Drawing.Bitmap.FromStream(stream);
                ClaimImgBox.BackgroundImage = img;
            }
            ClaimImgBox.Visible = true;
            
        }
    
        private void ShowClaimInfo()
        {
            fmUser = db.get_username(claim.fmID);
            cmUser = db.get_username(claim.cmID);
            claimDescTxtBox.Text = claim.claimDesc;
            claimIDTxt.Text = claim.claimID.ToString();
            startDateTxt.Text = claim.startDate.ToString();
            statusTxt.Text = claim.claimStatus;
            lastUpdateTxt.Text = claim.lastUpdate.ToString();
            claimTypeTxt.Text = claim.claimType;



            //get end date or estimated end date
            if (claim.endDate.Equals(minDateTime))
            {
                if (claim.estEndDate.Equals(maxDateTime))
                {
                    endDateTxt.Text = "N/A";
                    cmForClaimTxt.Text = "N/A";
                }
                else
                {
                    endDateTxt.Text = claim.estEndDate.ToString();
                    //cmForClaimTxt.Text = cmid.ToString();
                    cmForClaimTxt.Text = cmUser;
                }
            }
            else
            {
                endDateTxt.Text = claim.endDate.ToString();
                //cmForClaimTxt.Text = cmid.ToString();
                cmForClaimTxt.Text = cmUser;
            }

            if (claim.fmID == 0)
            {
                paymentStatTxt.Text = "N/A";
                estimatePaymentTxt.Text = "N/A";
                fmForClaimTxt.Text = "N/A";

            }
            else
            {
                if (claim.paymentStatus == "")
                {
                    paymentStatTxt.Text = "N/A";
                }
                else
                {
                    paymentStatTxt.Text = claim.paymentStatus;
                }

                if (claim.getEstimatedAmt(claim.claimID) == 0)
                {
                    estimatePaymentTxt.Text = "N/A";
                }
                else
                {
                    estimatePaymentTxt.Text = claim.getEstimatedAmt(claim.claimID).ToString();
                }
                //fmForClaimTxt.Text = fmid.ToString();
                fmForClaimTxt.Text = fmUser;
            }


        }
        //need to do a get name for cm and fm
        private void loadClaimInfo_btn_Click(object sender, EventArgs e)
        {
            fmUser = db.get_username(claim.fmID);
            cmUser = db.get_username(claim.cmID);
            claimDescTxtBox.Text = claim.claimDesc;
            claimIDTxt.Text = claim.claimID.ToString();
            startDateTxt.Text = claim.startDate.ToString();
            statusTxt.Text = claim.claimStatus;
            lastUpdateTxt.Text = claim.lastUpdate.ToString();
            claimTypeTxt.Text = claim.claimType;


           
            //get end date or estimated end date
            if (claim.endDate.Equals(minDateTime))
            {
                if (claim.estEndDate.Equals(maxDateTime))
                {
                    endDateTxt.Text = "N/A";
                    cmForClaimTxt.Text = "N/A";
                }
                else
                {
                    endDateTxt.Text = claim.estEndDate.ToString();
                    //cmForClaimTxt.Text = cmid.ToString();
                    cmForClaimTxt.Text = cmUser;
                }
            }
            else
            {
                endDateTxt.Text = claim.endDate.ToString();
                //cmForClaimTxt.Text = cmid.ToString();
                cmForClaimTxt.Text = cmUser; 
            }

            if (claim.fmID == 0)
            {
                paymentStatTxt.Text = "N/A";
                estimatePaymentTxt.Text = "N/A";
                fmForClaimTxt.Text = "N/A";

            }
            else
            {
                if (claim.paymentStatus == "")
                {
                    paymentStatTxt.Text = "N/A";
                }
                else
                {
                    paymentStatTxt.Text = claim.paymentStatus;
                }

                if (claim.getEstimatedAmt(claim.claimID) == 0)
                {
                    estimatePaymentTxt.Text = "N/A";
                }
                else
                {
                    estimatePaymentTxt.Text = claim.getEstimatedAmt(claim.claimID).ToString();
                }
                //fmForClaimTxt.Text = fmid.ToString();
                fmForClaimTxt.Text = fmUser;
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
