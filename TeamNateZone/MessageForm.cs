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
    public partial class MessageForm : Form
    {
        User user;
        ClientWelcomeForm welcomeForm;
        CMWelcomeForm cmwelcomeForm;
        FMWelcomeForm fmwelcomeForm;
        NewMessage Newmess;
        public MessageForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (user.getRole() == "Client")
            {
                welcomeForm = new ClientWelcomeForm(user);
                welcomeForm.Owner = this;
                welcomeForm.Show();
            }
            else if (user.getRole() == "Claims Manager")
            {
                cmwelcomeForm = new CMWelcomeForm(user);
                cmwelcomeForm.Owner = this;
                cmwelcomeForm.Show();
            }
            else if (user.getRole() == "Finance Manager")
            {
                fmwelcomeForm = new FMWelcomeForm(user);
                fmwelcomeForm.Owner = this;
                fmwelcomeForm.Show();
            }
            else if (user.getRole() == "Admin")
            {
                welcomeForm = new ClientWelcomeForm(user);
                welcomeForm.Owner = this;
                welcomeForm.Show();
            }
            else
            {
                MessageBox.Show("Error Occurred");
            }
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }

        private void MessageForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tEAM_ADataSet1.message' table. You can move, or remove it, as needed.
            // this.messageTableAdapter.Fill(this.tEAM_ADataSet1.message);
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            int account = user.getUserID();

            cn.ConnectionString =
                @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
            cmd.Connection = cn;
            cn.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM message", cn);
            // da.SelectCommand.Parameters.AddWithValue("userid", account);
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            cn.Close();
        }

        private void btnNewMessage_Click(object sender, EventArgs e)
        {
            Newmess = new NewMessage(user);
            Newmess.Owner = this;
            Newmess.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //this will open another form with the full message display
            MessageBox.Show("Messages still in progress. Come back Later!", "Form not ready", MessageBoxButtons.OK);
        }
    }
}
