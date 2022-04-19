
namespace TeamNateZone
{
    partial class FMWelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMWelcomeForm));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnlogout = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnViewClient = new CustomControls.RJControls.rndButton();
            this.btnViewMessages = new CustomControls.RJControls.rndButton();
            this.btnManageAccount = new CustomControls.RJControls.rndButton();
            this.btnManageFinances = new CustomControls.RJControls.rndButton();
            this.lblFolders = new System.Windows.Forms.Label();
            this.btnViewFolders = new CustomControls.RJControls.rndButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(813, 522);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 36);
            this.label4.TabIndex = 32;
            this.label4.Text = "Manage Account";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(489, 663);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 52);
            this.label3.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(558, 522);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 36);
            this.label2.TabIndex = 30;
            this.label2.Text = "View Messages";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 522);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 36);
            this.label1.TabIndex = 29;
            this.label1.Text = "View Client List";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1062, 522);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 36);
            this.label5.TabIndex = 34;
            this.label5.Text = "Manage Finances";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TeamNateZone.Properties.Resources.updatedPandaIcon;
            this.pictureBox1.Location = new System.Drawing.Point(10, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // btnlogout
            // 
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Image = global::TeamNateZone.Properties.Resources.logoutIcon;
            this.btnlogout.Location = new System.Drawing.Point(1186, 9);
            this.btnlogout.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(96, 108);
            this.btnlogout.TabIndex = 2;
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Gadugi", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Black;
            this.lblWelcome.Location = new System.Drawing.Point(147, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(592, 54);
            this.lblWelcome.TabIndex = 40;
            this.lblWelcome.Text = "Welcome Finance Manager";
            // 
            // btnViewClient
            // 
            this.btnViewClient.BackColor = System.Drawing.Color.White;
            this.btnViewClient.BackgroundColor = System.Drawing.Color.White;
            this.btnViewClient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewClient.BackgroundImage")));
            this.btnViewClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewClient.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnViewClient.BorderRadius = 30;
            this.btnViewClient.BorderSize = 5;
            this.btnViewClient.FlatAppearance.BorderSize = 0;
            this.btnViewClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewClient.ForeColor = System.Drawing.Color.White;
            this.btnViewClient.ImageIndex = 0;
            this.btnViewClient.Location = new System.Drawing.Point(294, 171);
            this.btnViewClient.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnViewClient.Name = "btnViewClient";
            this.btnViewClient.Size = new System.Drawing.Size(231, 332);
            this.btnViewClient.TabIndex = 33;
            this.btnViewClient.TextColor = System.Drawing.Color.White;
            this.btnViewClient.UseVisualStyleBackColor = false;
            this.btnViewClient.Click += new System.EventHandler(this.btnViewClient_Click);
            // 
            // btnViewMessages
            // 
            this.btnViewMessages.BackColor = System.Drawing.Color.White;
            this.btnViewMessages.BackgroundColor = System.Drawing.Color.White;
            this.btnViewMessages.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewMessages.BackgroundImage")));
            this.btnViewMessages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnViewMessages.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnViewMessages.BorderRadius = 30;
            this.btnViewMessages.BorderSize = 5;
            this.btnViewMessages.FlatAppearance.BorderSize = 0;
            this.btnViewMessages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewMessages.ForeColor = System.Drawing.Color.White;
            this.btnViewMessages.ImageIndex = 0;
            this.btnViewMessages.Location = new System.Drawing.Point(552, 171);
            this.btnViewMessages.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnViewMessages.Name = "btnViewMessages";
            this.btnViewMessages.Size = new System.Drawing.Size(231, 335);
            this.btnViewMessages.TabIndex = 27;
            this.btnViewMessages.TextColor = System.Drawing.Color.White;
            this.btnViewMessages.UseVisualStyleBackColor = false;
            this.btnViewMessages.Click += new System.EventHandler(this.btnViewMessages_Click);
            // 
            // btnManageAccount
            // 
            this.btnManageAccount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
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
            this.btnManageAccount.Location = new System.Drawing.Point(813, 171);
            this.btnManageAccount.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnManageAccount.Name = "btnManageAccount";
            this.btnManageAccount.Size = new System.Drawing.Size(231, 335);
            this.btnManageAccount.TabIndex = 25;
            this.btnManageAccount.TextColor = System.Drawing.Color.White;
            this.btnManageAccount.UseVisualStyleBackColor = false;
            this.btnManageAccount.Click += new System.EventHandler(this.btnManageAccount_Click);
            // 
            // btnManageFinances
            // 
            this.btnManageFinances.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnManageFinances.BackColor = System.Drawing.Color.White;
            this.btnManageFinances.BackgroundColor = System.Drawing.Color.White;
            this.btnManageFinances.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnManageFinances.BackgroundImage")));
            this.btnManageFinances.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnManageFinances.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnManageFinances.BorderRadius = 30;
            this.btnManageFinances.BorderSize = 5;
            this.btnManageFinances.FlatAppearance.BorderSize = 0;
            this.btnManageFinances.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageFinances.ForeColor = System.Drawing.Color.White;
            this.btnManageFinances.ImageIndex = 0;
            this.btnManageFinances.Location = new System.Drawing.Point(1074, 172);
            this.btnManageFinances.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnManageFinances.Name = "btnManageFinances";
            this.btnManageFinances.Size = new System.Drawing.Size(222, 335);
            this.btnManageFinances.TabIndex = 26;
            this.btnManageFinances.TextColor = System.Drawing.Color.White;
            this.btnManageFinances.UseVisualStyleBackColor = false;
            this.btnManageFinances.Click += new System.EventHandler(this.btnManageFinances_Click);
            // 
            // lblFolders
            // 
            this.lblFolders.AutoSize = true;
            this.lblFolders.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolders.Location = new System.Drawing.Point(9, 522);
            this.lblFolders.Name = "lblFolders";
            this.lblFolders.Size = new System.Drawing.Size(267, 36);
            this.lblFolders.TabIndex = 42;
            this.lblFolders.Text = "View Claim Folders";
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
            this.btnViewFolders.Location = new System.Drawing.Point(33, 171);
            this.btnViewFolders.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnViewFolders.Name = "btnViewFolders";
            this.btnViewFolders.Size = new System.Drawing.Size(231, 332);
            this.btnViewFolders.TabIndex = 43;
            this.btnViewFolders.TextColor = System.Drawing.Color.White;
            this.btnViewFolders.UseVisualStyleBackColor = false;
            this.btnViewFolders.Click += new System.EventHandler(this.btnViewFolders_Click);
            // 
            // FMWelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1329, 678);
            this.Controls.Add(this.btnViewFolders);
            this.Controls.Add(this.lblFolders);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnViewClient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnViewMessages);
            this.Controls.Add(this.btnManageAccount);
            this.Controls.Add(this.btnManageFinances);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FMWelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.rndButton btnViewMessages;
        private CustomControls.RJControls.rndButton btnManageAccount;
        private CustomControls.RJControls.rndButton btnManageFinances;
        private CustomControls.RJControls.rndButton btnViewClient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblFolders;
        private CustomControls.RJControls.rndButton btnViewFolders;
    }
}