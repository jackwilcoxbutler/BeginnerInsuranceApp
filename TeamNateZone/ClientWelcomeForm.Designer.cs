﻿
namespace TeamNateZone
{
    partial class ClientWelcomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientWelcomeForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFileClaim = new CustomControls.RJControls.rndButton();
            this.btnListClaims = new CustomControls.RJControls.rndButton();
            this.btnManageAccount = new CustomControls.RJControls.rndButton();
            this.btnlogout = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnViewMessages = new CustomControls.RJControls.rndButton();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnViewFolders = new CustomControls.RJControls.rndButton();
            this.lblFolders = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(404, 752);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 48);
            this.label1.TabIndex = 20;
            this.label1.Text = "File a new claim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(800, 752);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 48);
            this.label2.TabIndex = 21;
            this.label2.Text = "View Existing";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(842, 798);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 48);
            this.label3.TabIndex = 22;
            this.label3.Text = "Claims";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1492, 752);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(323, 48);
            this.label4.TabIndex = 23;
            this.label4.Text = "Manage Account";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TeamNateZone.Properties.Resources.updatedPandaIcon;
            this.pictureBox1.Location = new System.Drawing.Point(14, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btnFileClaim
            // 
            this.btnFileClaim.BackColor = System.Drawing.Color.White;
            this.btnFileClaim.BackgroundColor = System.Drawing.Color.White;
            this.btnFileClaim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFileClaim.BackgroundImage")));
            this.btnFileClaim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFileClaim.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnFileClaim.BorderRadius = 30;
            this.btnFileClaim.BorderSize = 5;
            this.btnFileClaim.FlatAppearance.BorderSize = 0;
            this.btnFileClaim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileClaim.ForeColor = System.Drawing.Color.White;
            this.btnFileClaim.ImageIndex = 0;
            this.btnFileClaim.Location = new System.Drawing.Point(394, 283);
            this.btnFileClaim.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFileClaim.Name = "btnFileClaim";
            this.btnFileClaim.Size = new System.Drawing.Size(310, 452);
            this.btnFileClaim.TabIndex = 18;
            this.btnFileClaim.TextColor = System.Drawing.Color.White;
            this.btnFileClaim.UseVisualStyleBackColor = false;
            this.btnFileClaim.Click += new System.EventHandler(this.btnFileClaim_Click);
            // 
            // btnListClaims
            // 
            this.btnListClaims.BackColor = System.Drawing.Color.White;
            this.btnListClaims.BackgroundColor = System.Drawing.Color.White;
            this.btnListClaims.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnListClaims.BackgroundImage")));
            this.btnListClaims.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnListClaims.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnListClaims.BorderRadius = 30;
            this.btnListClaims.BorderSize = 5;
            this.btnListClaims.FlatAppearance.BorderSize = 0;
            this.btnListClaims.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListClaims.ForeColor = System.Drawing.Color.White;
            this.btnListClaims.ImageIndex = 0;
            this.btnListClaims.Location = new System.Drawing.Point(768, 288);
            this.btnListClaims.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnListClaims.Name = "btnListClaims";
            this.btnListClaims.Size = new System.Drawing.Size(310, 446);
            this.btnListClaims.TabIndex = 15;
            this.btnListClaims.TextColor = System.Drawing.Color.White;
            this.btnListClaims.UseVisualStyleBackColor = false;
            this.btnListClaims.Click += new System.EventHandler(this.btnListClaims_Click_1);
            // 
            // btnManageAccount
            // 
            this.btnManageAccount.BackColor = System.Drawing.Color.White;
            this.btnManageAccount.BackgroundColor = System.Drawing.Color.White;
            this.btnManageAccount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnManageAccount.BackgroundImage")));
            this.btnManageAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnManageAccount.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnManageAccount.BorderRadius = 30;
            this.btnManageAccount.BorderSize = 5;
            this.btnManageAccount.FlatAppearance.BorderSize = 0;
            this.btnManageAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageAccount.ForeColor = System.Drawing.Color.White;
            this.btnManageAccount.ImageIndex = 0;
            this.btnManageAccount.Location = new System.Drawing.Point(1504, 283);
            this.btnManageAccount.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnManageAccount.Name = "btnManageAccount";
            this.btnManageAccount.Size = new System.Drawing.Size(310, 452);
            this.btnManageAccount.TabIndex = 17;
            this.btnManageAccount.TextColor = System.Drawing.Color.White;
            this.btnManageAccount.UseVisualStyleBackColor = false;
            this.btnManageAccount.Click += new System.EventHandler(this.btnManageAccount_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Image = global::TeamNateZone.Properties.Resources.logoutIcon;
            this.btnlogout.Location = new System.Drawing.Point(1708, 38);
            this.btnlogout.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(128, 135);
            this.btnlogout.TabIndex = 2;
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1152, 752);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(289, 48);
            this.label5.TabIndex = 32;
            this.label5.Text = "View Messages";
            // 
            // btnViewMessages
            // 
            this.btnViewMessages.BackColor = System.Drawing.Color.White;
            this.btnViewMessages.BackgroundColor = System.Drawing.Color.White;
            this.btnViewMessages.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewMessages.BackgroundImage")));
            this.btnViewMessages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewMessages.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnViewMessages.BorderRadius = 30;
            this.btnViewMessages.BorderSize = 5;
            this.btnViewMessages.FlatAppearance.BorderSize = 0;
            this.btnViewMessages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewMessages.ForeColor = System.Drawing.Color.White;
            this.btnViewMessages.ImageIndex = 0;
            this.btnViewMessages.Location = new System.Drawing.Point(1142, 290);
            this.btnViewMessages.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnViewMessages.Name = "btnViewMessages";
            this.btnViewMessages.Size = new System.Drawing.Size(310, 442);
            this.btnViewMessages.TabIndex = 31;
            this.btnViewMessages.TextColor = System.Drawing.Color.White;
            this.btnViewMessages.UseVisualStyleBackColor = false;
            this.btnViewMessages.Click += new System.EventHandler(this.btnViewMessages_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Gadugi", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Black;
            this.lblWelcome.Location = new System.Drawing.Point(264, 13);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(314, 77);
            this.lblWelcome.TabIndex = 39;
            this.lblWelcome.Text = "Welcome";
            // 
            // btnViewFolders
            // 
            this.btnViewFolders.BackColor = System.Drawing.Color.White;
            this.btnViewFolders.BackgroundColor = System.Drawing.Color.White;
            this.btnViewFolders.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewFolders.BackgroundImage")));
            this.btnViewFolders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewFolders.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnViewFolders.BorderRadius = 30;
            this.btnViewFolders.BorderSize = 5;
            this.btnViewFolders.FlatAppearance.BorderSize = 0;
            this.btnViewFolders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewFolders.ForeColor = System.Drawing.Color.White;
            this.btnViewFolders.ImageIndex = 0;
            this.btnViewFolders.Location = new System.Drawing.Point(30, 283);
            this.btnViewFolders.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnViewFolders.Name = "btnViewFolders";
            this.btnViewFolders.Size = new System.Drawing.Size(310, 452);
            this.btnViewFolders.TabIndex = 40;
            this.btnViewFolders.TextColor = System.Drawing.Color.White;
            this.btnViewFolders.UseVisualStyleBackColor = false;
            this.btnViewFolders.Click += new System.EventHandler(this.btnViewFolders_Click);
            // 
            // lblFolders
            // 
            this.lblFolders.AutoSize = true;
            this.lblFolders.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolders.Location = new System.Drawing.Point(12, 752);
            this.lblFolders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFolders.Name = "lblFolders";
            this.lblFolders.Size = new System.Drawing.Size(357, 48);
            this.lblFolders.TabIndex = 41;
            this.lblFolders.Text = "View Claim Folders";
            // 
            // ClientWelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1848, 998);
            this.Controls.Add(this.lblFolders);
            this.Controls.Add(this.btnViewFolders);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnViewMessages);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnFileClaim);
            this.Controls.Add(this.btnListClaims);
            this.Controls.Add(this.btnManageAccount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ClientWelcomeForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WelcomeForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControls.RJControls.rndButton btnListClaims;
        private CustomControls.RJControls.rndButton btnManageAccount;
        private CustomControls.RJControls.rndButton btnFileClaim;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Label label5;
        private CustomControls.RJControls.rndButton btnViewMessages;
        private System.Windows.Forms.Label lblWelcome;
        private CustomControls.RJControls.rndButton btnViewFolders;
        private System.Windows.Forms.Label lblFolders;
    }
}