﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamNateZone
{
    public partial class claimList : Form
    {
        User user;
        WelcomeForm welcomeForm;
        public claimList(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btnReturnToWelcome_Click(object sender, EventArgs e)
        {
            this.Hide();
            welcomeForm = new WelcomeForm(user);
            welcomeForm.Owner = this;
            welcomeForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void claimList_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            //SqlDataReader dr;
            int account = user.getUserID();

            cn.ConnectionString =
                @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
            cmd.Connection = cn;
            //cmd.CommandText = "SELECT * FROM Claims WHERE UserID = @userid";
            //cmd.Parameters.AddWithValue("@userid", account);
            cn.Open();
            //dr = cmd.ExecuteReader();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Claims WHERE UserID = @userid", cn);
            da.SelectCommand.Parameters.AddWithValue("@userid", account);
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);
            dataGridView1.DataSource = dtbl;

            // TODO: This line of code loads data into the 'tEAM_A_Claims_Dataset.Claims' table. You can move, or remove it, as needed.
            //this.claimsTableAdapter.Fill(this.tEAM_A_Claims_Dataset.Claims);

        }
    }
}
