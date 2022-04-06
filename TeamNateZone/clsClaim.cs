﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace TeamNateZone
{
    class Claim
    {
        //Claim ID, user ID, claim Type, claim Description, start Date, end date, status, last update, payment status, 
        //lastUpdate, payment status, CM ID, FM ID, Estimated End Date 

        //Data
        int userID { get; set; }
        public int claimID { get; set; }
        int cmID { get; set; }
        int fmID { get; set; }
        string claimType { get; set; }
        string claimDesc { get; set; }
        string claimStatus { get; set; }
        string paymentStatus { get; set; }
        DateTime startDate { get; set; }
        DateTime endDate { get; set; }
        DateTime estEndDate { get; set; }
        DateTime lastUpdate { get; set; }

        dbHandler db;

        //Constructor 
        public Claim( int userID, int cmID,int fmID, string claimType, string claimDesc, string claimStatus, 
                     string paymentStatus, DateTime startDate, DateTime endDate, DateTime estEndDate, DateTime lastUpdate) //created by claim form
        {
            this.claimID = claimID;
            this.userID = userID;
            this.cmID = cmID;
            this.fmID = fmID;
            this.claimType = claimType;
            this.claimDesc = claimDesc;
            this.claimStatus = claimStatus;
            this.paymentStatus = paymentStatus;
            this.startDate = startDate;
            this.endDate= endDate;
            this.estEndDate= estEndDate;
            this.lastUpdate = lastUpdate;
            this.db = new dbHandler(@"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True");

        }

        public Claim(int userID, string claimType,string claimDesc, DateTime startDate)
        {
            this.userID = userID;
            this.claimType = claimType;
            this.claimDesc = claimDesc;
            this.startDate = startDate;
            this.db = new dbHandler(@"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True");

        }
        //Need a default constructor 

        //Need a constructor that takes in parameters 
        public Claim(int claimID)
        {
            this.claimID = claimID;
            userID = getUserID(claimID);
            cmID = getCmID(claimID);
            fmID = getFmID(claimID);
            claimType = getClaimType(claimID);
            claimDesc = getClaimDesc(claimID);
            claimStatus = getClaimStatus(claimID);
            paymentStatus = getPaymentStatus(claimID);
            startDate = getStartDate(claimID);
            endDate = getEndDate(claimID);
            estEndDate = getEstEndDate(claimID);
            lastUpdate = getLastUpdate(claimID);
            this.db = new dbHandler(@"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True");

        }

        /*set methods
        private void setUserID(int value) => userID = value;
        private void setClaimID(int value) => claimID = value;
        private void  setCmID(int value) => cmID = value;
        private void setFmID(int value) => fmID = value;
        private void setClaimType(string value) => claimType = value;
        private void setClaimDesc(string value) => claimDesc = value;
        private void setClaimStatus(string value) => claimStatus = value;
        private void setPaymentStatus(string value) => paymentStatus = value;
        private void setStartDate(DateTime value) => startDate = value;
        private void setEndDate(DateTime value) => endDate = value;
        private void setEstEndDate(DateTime value) => estEndDate = value;
        private void setLastUpdate(DateTime value) => lastUpdate = value;
        */

        //get functions to pull data from the database
        private int getUserID(int claimID)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {
                cn.ConnectionString =
                    @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
                cmd.Connection = cn;
                cmd.CommandText = "SELECT UserID FROM Claim WHERE ClaimID = @claimID";
                cmd.Parameters.AddWithValue("@claimID", claimID);
                cn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                return dr.GetInt32(0);
            }
            catch (Exception err)
            {
                return 0;
            }
            finally
            {
                cn.Close();
            }
        }

        private int getFmID(int claimID)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {
                cn.ConnectionString =
                    @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
                cmd.Connection = cn;
                cmd.CommandText = "SELECT FmID FROM Claim WHERE ClaimID = @claimID";
                cmd.Parameters.AddWithValue("@claimID", claimID);
                cn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                return dr.GetInt32(0);
            }
            catch (Exception err)
            {
                return 0;
            }
            finally
            {
                cn.Close();
            }
        }

        private int getCmID(int claimID)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {
                cn.ConnectionString =
                    @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
                cmd.Connection = cn;
                cmd.CommandText = "SELECT CmID FROM Claim WHERE ClaimID = @claimID";
                cmd.Parameters.AddWithValue("@claimID", claimID);
                cn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                return dr.GetInt32(0);
            }
            catch (Exception err)
            {
                return 0;
            }
            finally
            {
                cn.Close();
            }
        }


        private string getClaimType(int claimID)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {
                cn.ConnectionString =
                    @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Claim_Type FROM Claim WHERE ClaimID = @claimID";
                cmd.Parameters.AddWithValue("@claimID", claimID);
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

        private string getClaimDesc(int claimID)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {
                cn.ConnectionString =
                    @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Claim_Description FROM Claim WHERE ClaimID = @claimID";
                cmd.Parameters.AddWithValue("@claimID", claimID);
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

        private string getClaimStatus(int claimID)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {
                cn.ConnectionString =
                    @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Status FROM Claim WHERE ClaimID = @claimID";
                cmd.Parameters.AddWithValue("@claimID", claimID);
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

        private string getPaymentStatus(int claimID)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {
                cn.ConnectionString =
                    @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
                cmd.Connection = cn;
                cmd.CommandText = "SELECT PaymentStatus FROM Claim WHERE ClaimID = @claimID";
                cmd.Parameters.AddWithValue("@claimID", claimID);
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

        //DateTime data type needs to go through some testing
        private DateTime getStartDate(int claimID)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {
                cn.ConnectionString =
                    @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
                cmd.Connection = cn;
                cmd.CommandText = "SELECT StartDate FROM Claim WHERE ClaimID = @claimID";
                cmd.Parameters.AddWithValue("@claimID", claimID);
                cn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                return dr.GetDateTime(0);
            }
            catch (Exception err)
            {
                return new DateTime(1900,1,1);
            }
            finally
            {
                cn.Close();
            }
        }

        private DateTime getEndDate(int claimID)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {
                cn.ConnectionString =
                    @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
                cmd.Connection = cn;
                cmd.CommandText = "SELECT EndDate FROM Claim WHERE ClaimID = @claimID";
                cmd.Parameters.AddWithValue("@claimID", claimID);
                cn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                return dr.GetDateTime(0);
            }
            catch (Exception err)
            {
                return new DateTime(1900, 1, 1);
            }
            finally
            {
                cn.Close();
            }
        }

        private DateTime getEstEndDate(int claimID)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {
                cn.ConnectionString =
                    @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
                cmd.Connection = cn;
                cmd.CommandText = "SELECT EstimatedEndDate FROM Claim WHERE ClaimID = @claimID";
                cmd.Parameters.AddWithValue("@claimID", claimID);
                cn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                return dr.GetDateTime(0);
            }
            catch (Exception err)
            {
                return new DateTime(2100, 1, 1);
            }
            finally
            {
                cn.Close();
            }
        }

        private DateTime getLastUpdate(int claimID)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {
                cn.ConnectionString =
                    @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
                cmd.Connection = cn;
                cmd.CommandText = "SELECT LastUpdate FROM Claim WHERE ClaimID = @claimID";
                cmd.Parameters.AddWithValue("@claimID", claimID);
                cn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                return dr.GetDateTime(0);
            }
            catch (Exception err)
            {
                return new DateTime(1900, 1, 1);
            }
            finally
            {
                cn.Close();
            }
        }

        public bool fileClaim(User user)
        {
                SqlConnection cn = new SqlConnection();
                SqlCommand cmd = new SqlCommand();
                SqlDataReader dr;
                string status = "Submitted";
                try { 
                    cn.ConnectionString =
                        @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
                    cmd.Connection = cn;

                    cmd.CommandText = "INSERT INTO Claims(UserID, Username, UserEmail, Claim_Type, Claim_Description, StartDate, Status) VALUES (@id, @username, @email, @type, @desc, @date, @stat)";
                    cmd.Parameters.AddWithValue("@id", userID);
                    cmd.Parameters.AddWithValue("@username", user.getUsername());
                    cmd.Parameters.AddWithValue("@email", user.getEmail());
                    cmd.Parameters.AddWithValue("@type", claimType); // may not have to ToString(), will try later
                    cmd.Parameters.AddWithValue("@desc", claimDesc);
                    cmd.Parameters.AddWithValue("@date", startDate); // again, may not need to ToString()
                    cmd.Parameters.AddWithValue("@stat", status);

                    cn.Open();
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    cn.Close();

           
            }
            catch (Exception err)
                {
                    return false;
                    MessageBox.Show(err.Message, "Error Occurred");
                }
                finally
                {
                    cn.Close();
                }
            return true;
        }

        public bool estimateAmt(int amt,int claimID)
        {
            if (db.update_Claim(amt, claimID))
            {
                return true;
            }
            return false;
        }

    }
}
