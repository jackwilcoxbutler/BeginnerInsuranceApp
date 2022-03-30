
namespace TeamNateZone
{
    partial class AdminWelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminWelcomeForm));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewClientList = new CustomControls.RJControls.rndButton();
            this.btnViewMessages = new CustomControls.RJControls.rndButton();
            this.btnManageAccount = new CustomControls.RJControls.rndButton();
            this.btnGrantPermissions = new CustomControls.RJControls.rndButton();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnlogout = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(656, 568);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(312, 46);
            this.label4.TabIndex = 32;
            this.label4.Text = "Manage Account";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(489, 662);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 52);
            this.label3.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 568);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 46);
            this.label1.TabIndex = 29;
            this.label1.Text = "View Client List";
            // 
            // btnViewClientList
            // 
            this.btnViewClientList.BackColor = System.Drawing.Color.White;
            this.btnViewClientList.BackgroundColor = System.Drawing.Color.White;
            this.btnViewClientList.BackgroundImage = global::TeamNateZone.Properties.Resources.clipBoard;
            this.btnViewClientList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnViewClientList.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnViewClientList.BorderRadius = 30;
            this.btnViewClientList.BorderSize = 5;
            this.btnViewClientList.FlatAppearance.BorderSize = 0;
            this.btnViewClientList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewClientList.ForeColor = System.Drawing.Color.White;
            this.btnViewClientList.ImageIndex = 0;
            this.btnViewClientList.Location = new System.Drawing.Point(38, 140);
            this.btnViewClientList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnViewClientList.Name = "btnViewClientList";
            this.btnViewClientList.Size = new System.Drawing.Size(266, 402);
            this.btnViewClientList.TabIndex = 27;
            this.btnViewClientList.TextColor = System.Drawing.Color.White;
            this.btnViewClientList.UseVisualStyleBackColor = false;
            this.btnViewClientList.Click += new System.EventHandler(this.btnViewClient_Click);
            // 
            // btnViewMessages
            // 
            this.btnViewMessages.BackColor = System.Drawing.Color.White;
            this.btnViewMessages.BackgroundColor = System.Drawing.Color.White;
            this.btnViewMessages.BackgroundImage = global::TeamNateZone.Properties.Resources.message;
            this.btnViewMessages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewMessages.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnViewMessages.BorderRadius = 30;
            this.btnViewMessages.BorderSize = 5;
            this.btnViewMessages.FlatAppearance.BorderSize = 0;
            this.btnViewMessages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewMessages.ForeColor = System.Drawing.Color.White;
            this.btnViewMessages.ImageIndex = 0;
            this.btnViewMessages.Location = new System.Drawing.Point(342, 146);
            this.btnViewMessages.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnViewMessages.Name = "btnViewMessages";
            this.btnViewMessages.Size = new System.Drawing.Size(282, 405);
            this.btnViewMessages.TabIndex = 25;
            this.btnViewMessages.TextColor = System.Drawing.Color.White;
            this.btnViewMessages.UseVisualStyleBackColor = false;
            this.btnViewMessages.Click += new System.EventHandler(this.btnViewMessages_Click);
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
            this.btnManageAccount.Location = new System.Drawing.Point(665, 146);
            this.btnManageAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnManageAccount.Name = "btnManageAccount";
            this.btnManageAccount.Size = new System.Drawing.Size(291, 409);
            this.btnManageAccount.TabIndex = 26;
            this.btnManageAccount.TextColor = System.Drawing.Color.White;
            this.btnManageAccount.UseVisualStyleBackColor = false;
            this.btnManageAccount.Click += new System.EventHandler(this.btnManageAccount_Click);
            // 
            // btnGrantPermissions
            // 
            this.btnGrantPermissions.BackColor = System.Drawing.Color.White;
            this.btnGrantPermissions.BackgroundColor = System.Drawing.Color.White;
            this.btnGrantPermissions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGrantPermissions.BackgroundImage")));
            this.btnGrantPermissions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGrantPermissions.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnGrantPermissions.BorderRadius = 30;
            this.btnGrantPermissions.BorderSize = 5;
            this.btnGrantPermissions.FlatAppearance.BorderSize = 0;
            this.btnGrantPermissions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrantPermissions.ForeColor = System.Drawing.Color.White;
            this.btnGrantPermissions.ImageIndex = 0;
            this.btnGrantPermissions.Location = new System.Drawing.Point(1000, 149);
            this.btnGrantPermissions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGrantPermissions.Name = "btnGrantPermissions";
            this.btnGrantPermissions.Size = new System.Drawing.Size(291, 416);
            this.btnGrantPermissions.TabIndex = 33;
            this.btnGrantPermissions.TextColor = System.Drawing.Color.White;
            this.btnGrantPermissions.UseVisualStyleBackColor = false;
            this.btnGrantPermissions.Click += new System.EventHandler(this.btnGrantPermissions_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(974, 568);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(333, 46);
            this.label5.TabIndex = 34;
            this.label5.Text = "Grant Permissions";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TeamNateZone.Properties.Resources.updatedPandaIcon;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // btnlogout
            // 
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Image = global::TeamNateZone.Properties.Resources.logoutIcon;
            this.btnlogout.Location = new System.Drawing.Point(1187, 10);
            this.btnlogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(97, 108);
            this.btnlogout.TabIndex = 2;
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(343, 568);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(282, 46);
            this.label6.TabIndex = 37;
            this.label6.Text = "View Messages";
            // 
            // AdminWelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1330, 679);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGrantPermissions);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnViewClientList);
            this.Controls.Add(this.btnViewMessages);
            this.Controls.Add(this.btnManageAccount);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminWelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FMWelcomeScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.rndButton btnViewClientList;
        private CustomControls.RJControls.rndButton btnViewMessages;
        private CustomControls.RJControls.rndButton btnManageAccount;
        private CustomControls.RJControls.rndButton btnGrantPermissions;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Label label6;
    }
}