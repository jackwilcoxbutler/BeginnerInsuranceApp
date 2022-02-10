
namespace TeamNateZone
{
    partial class WelcomeForm
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.pbPanda = new System.Windows.Forms.PictureBox();
            this.btnFileClaim = new System.Windows.Forms.Button();
            this.btnListClaims = new System.Windows.Forms.Button();
            this.btnManageAccount = new System.Windows.Forms.Button();
            this.pnlDropDown = new System.Windows.Forms.Panel();
            this.btnLogout2 = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnMail = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPanda)).BeginInit();
            this.pnlDropDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(291, 49);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(192, 45);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome!";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.welcomeLabel.Click += new System.EventHandler(this.welcomeLabel_Click);
            // 
            // pbPanda
            // 
            this.pbPanda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPanda.Image = global::TeamNateZone.Properties.Resources.Panda_Logo;
            this.pbPanda.Location = new System.Drawing.Point(335, 118);
            this.pbPanda.Margin = new System.Windows.Forms.Padding(2);
            this.pbPanda.Name = "pbPanda";
            this.pbPanda.Size = new System.Drawing.Size(107, 98);
            this.pbPanda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPanda.TabIndex = 7;
            this.pbPanda.TabStop = false;
            // 
            // btnFileClaim
            // 
            this.btnFileClaim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFileClaim.Location = new System.Drawing.Point(143, 251);
            this.btnFileClaim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFileClaim.Name = "btnFileClaim";
            this.btnFileClaim.Size = new System.Drawing.Size(142, 98);
            this.btnFileClaim.TabIndex = 8;
            this.btnFileClaim.Text = "File a New Claim";
            this.btnFileClaim.UseVisualStyleBackColor = true;
            this.btnFileClaim.Click += new System.EventHandler(this.btnFileClaim_Click);
            // 
            // btnListClaims
            // 
            this.btnListClaims.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListClaims.Location = new System.Drawing.Point(319, 251);
            this.btnListClaims.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListClaims.Name = "btnListClaims";
            this.btnListClaims.Size = new System.Drawing.Size(142, 98);
            this.btnListClaims.TabIndex = 9;
            this.btnListClaims.Text = "View Existing Claims";
            this.btnListClaims.UseVisualStyleBackColor = true;
            this.btnListClaims.Click += new System.EventHandler(this.btnListClaims_Click);
            // 
            // btnManageAccount
            // 
            this.btnManageAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageAccount.Location = new System.Drawing.Point(492, 251);
            this.btnManageAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManageAccount.Name = "btnManageAccount";
            this.btnManageAccount.Size = new System.Drawing.Size(142, 98);
            this.btnManageAccount.TabIndex = 10;
            this.btnManageAccount.Text = "Manage Account";
            this.btnManageAccount.UseVisualStyleBackColor = true;
            this.btnManageAccount.Click += new System.EventHandler(this.btnManageAccount_Click);
            // 
            // pnlDropDown
            // 
            this.pnlDropDown.Controls.Add(this.btnSettings);
            this.pnlDropDown.Controls.Add(this.btnLogout2);
            this.pnlDropDown.Controls.Add(this.btnMenu);
            this.pnlDropDown.Controls.Add(this.btnMainMenu);
            this.pnlDropDown.Controls.Add(this.btnMail);
            this.pnlDropDown.Location = new System.Drawing.Point(681, 12);
            this.pnlDropDown.MaximumSize = new System.Drawing.Size(70, 345);
            this.pnlDropDown.MinimumSize = new System.Drawing.Size(70, 70);
            this.pnlDropDown.Name = "pnlDropDown";
            this.pnlDropDown.Size = new System.Drawing.Size(70, 70);
            this.pnlDropDown.TabIndex = 12;
            // 
            // btnLogout2
            // 
            this.btnLogout2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout2.Image = global::TeamNateZone.Properties.Resources.logoutIcon;
            this.btnLogout2.Location = new System.Drawing.Point(3, 277);
            this.btnLogout2.Name = "btnLogout2";
            this.btnLogout2.Size = new System.Drawing.Size(64, 64);
            this.btnLogout2.TabIndex = 1;
            this.btnLogout2.UseVisualStyleBackColor = true;
            this.btnLogout2.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Image = global::TeamNateZone.Properties.Resources.menuImageIcon;
            this.btnMenu.Location = new System.Drawing.Point(3, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(64, 64);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMenu.Image = global::TeamNateZone.Properties.Resources.homeIcon;
            this.btnMainMenu.Location = new System.Drawing.Point(3, 82);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(64, 60);
            this.btnMainMenu.TabIndex = 1;
            this.btnMainMenu.UseVisualStyleBackColor = true;
            // 
            // btnMail
            // 
            this.btnMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMail.Image = global::TeamNateZone.Properties.Resources.mailIcon;
            this.btnMail.Location = new System.Drawing.Point(3, 144);
            this.btnMail.Name = "btnMail";
            this.btnMail.Size = new System.Drawing.Size(64, 64);
            this.btnMail.TabIndex = 1;
            this.btnMail.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Image = global::TeamNateZone.Properties.Resources.settingsIcon;
            this.btnSettings.Location = new System.Drawing.Point(3, 211);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(64, 64);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TeamNateZone.Properties.Resources.vs5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(763, 469);
            this.Controls.Add(this.pnlDropDown);
            this.Controls.Add(this.btnManageAccount);
            this.Controls.Add(this.btnListClaims);
            this.Controls.Add(this.btnFileClaim);
            this.Controls.Add(this.pbPanda);
            this.Controls.Add(this.welcomeLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome!";
            ((System.ComponentModel.ISupportInitialize)(this.pbPanda)).EndInit();
            this.pnlDropDown.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.PictureBox pbPanda;
        private System.Windows.Forms.Button btnFileClaim;
        private System.Windows.Forms.Button btnListClaims;
        private System.Windows.Forms.Button btnManageAccount;
        private System.Windows.Forms.Panel pnlDropDown;
        private System.Windows.Forms.Button btnLogout2;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnMail;
        private System.Windows.Forms.Button btnSettings;
    }
}