﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamNateZone
{
    public partial class FMWelcomeForm : Form
    {
        User user;
        MessageForm message;
        FMManageFinance claimView;

        public FMWelcomeForm(User user)
        {
            InitializeComponent();
            this.user = user;

            lblWelcome.Text = "Welcome Financial Manager: " + user.getFname() + " " + user.getLname();

        }
        private void btnViewMessages_Click(object sender, EventArgs e)
        {
            this.Hide();
            message = new MessageForm(user);
            message.Owner = this;
            message.Show();          
        }
        private void btnManageAccount_Click(object sender, EventArgs e)
        {
            ManageAccount manage;
            this.Hide();
            manage = new ManageAccount(user);
            manage.Owner = this;
            manage.Show();
        }

        private void btnManageFinances_Click(object sender, EventArgs e)
        {
            claimView = new FMManageFinance(user);
            claimView.Owner = this;
            claimView.Show();
            this.Hide();
        }

        private void btnViewClient_Click(object sender, EventArgs e)
        {
            ViewUsersWithActiveClaims v = new ViewUsersWithActiveClaims(user);
            v.Show();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnViewFolders_Click(object sender, EventArgs e)
        {
            //The following will be implemented in the next issue of the program
            /*
            folderPage folderScreen = new folderPage(user);
            folderScreen.Show();
            this.Hide();
            */
            MessageBox.Show("The Following File Viewer System will be implemented in the next program release");

        }
    }
}
