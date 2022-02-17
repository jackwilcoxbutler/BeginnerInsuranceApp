
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.pbPanda = new System.Windows.Forms.PictureBox();
            this.btnFileClaim = new System.Windows.Forms.Button();
            this.btnListClaims = new System.Windows.Forms.Button();
            this.btnManageAccount = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlDropDown = new System.Windows.Forms.Panel();
            this.btnLogout2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnMenuOpen = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPanda)).BeginInit();
            this.pnlDropDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(218, 40);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(152, 36);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome!";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbPanda
            // 
            this.pbPanda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPanda.Image = global::TeamNateZone.Properties.Resources.Panda_Logo;
            this.pbPanda.Location = new System.Drawing.Point(251, 96);
            this.pbPanda.Margin = new System.Windows.Forms.Padding(1);
            this.pbPanda.Name = "pbPanda";
            this.pbPanda.Size = new System.Drawing.Size(80, 80);
            this.pbPanda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPanda.TabIndex = 7;
            this.pbPanda.TabStop = false;
            // 
            // btnFileClaim
            // 
            this.btnFileClaim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFileClaim.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFileClaim.Location = new System.Drawing.Point(107, 204);
            this.btnFileClaim.Margin = new System.Windows.Forms.Padding(2);
            this.btnFileClaim.Name = "btnFileClaim";
            this.btnFileClaim.Size = new System.Drawing.Size(107, 79);
            this.btnFileClaim.TabIndex = 8;
            this.btnFileClaim.Text = "File a New Claim";
            this.btnFileClaim.UseVisualStyleBackColor = true;
            this.btnFileClaim.Click += new System.EventHandler(this.btnFileClaim_Click);
            // 
            // btnListClaims
            // 
            this.btnListClaims.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListClaims.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListClaims.Location = new System.Drawing.Point(239, 204);
            this.btnListClaims.Margin = new System.Windows.Forms.Padding(2);
            this.btnListClaims.Name = "btnListClaims";
            this.btnListClaims.Size = new System.Drawing.Size(107, 79);
            this.btnListClaims.TabIndex = 9;
            this.btnListClaims.Text = "View Existing Claims";
            this.btnListClaims.UseVisualStyleBackColor = true;
            this.btnListClaims.Click += new System.EventHandler(this.btnListClaims_Click);
            // 
            // btnManageAccount
            // 
            this.btnManageAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnManageAccount.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageAccount.Location = new System.Drawing.Point(369, 204);
            this.btnManageAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnManageAccount.Name = "btnManageAccount";
            this.btnManageAccount.Size = new System.Drawing.Size(107, 79);
            this.btnManageAccount.TabIndex = 10;
            this.btnManageAccount.Text = "Manage Account";
            this.btnManageAccount.UseVisualStyleBackColor = true;
            this.btnManageAccount.Click += new System.EventHandler(this.btnManageAccount_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Panda Insurance";
            // 
            // pnlDropDown
            // 
            this.pnlDropDown.Controls.Add(this.btnLogout2);
            this.pnlDropDown.Controls.Add(this.button3);
            this.pnlDropDown.Controls.Add(this.btnMenuOpen);
            this.pnlDropDown.Controls.Add(this.button1);
            this.pnlDropDown.Controls.Add(this.button2);
            this.pnlDropDown.Location = new System.Drawing.Point(511, 10);
            this.pnlDropDown.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDropDown.MaximumSize = new System.Drawing.Size(52, 283);
            this.pnlDropDown.MinimumSize = new System.Drawing.Size(52, 57);
            this.pnlDropDown.Name = "pnlDropDown";
            this.pnlDropDown.Size = new System.Drawing.Size(52, 57);
            this.pnlDropDown.TabIndex = 13;
            // 
            // btnLogout2
            // 
            this.btnLogout2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout2.Image = global::TeamNateZone.Properties.Resources.logoutIcon;
            this.btnLogout2.Location = new System.Drawing.Point(2, 228);
            this.btnLogout2.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout2.Name = "btnLogout2";
            this.btnLogout2.Size = new System.Drawing.Size(48, 52);
            this.btnLogout2.TabIndex = 1;
            this.btnLogout2.UseVisualStyleBackColor = true;
            this.btnLogout2.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::TeamNateZone.Properties.Resources.settingsIcon;
            this.button3.Location = new System.Drawing.Point(2, 173);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 52);
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnMenuOpen
            // 
            this.btnMenuOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuOpen.Image = global::TeamNateZone.Properties.Resources.menuImageIcon;
            this.btnMenuOpen.Location = new System.Drawing.Point(2, 2);
            this.btnMenuOpen.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenuOpen.Name = "btnMenuOpen";
            this.btnMenuOpen.Size = new System.Drawing.Size(48, 52);
            this.btnMenuOpen.TabIndex = 1;
            this.btnMenuOpen.UseVisualStyleBackColor = true;
            this.btnMenuOpen.Click += new System.EventHandler(this.btnMenuOpen_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::TeamNateZone.Properties.Resources.homeIcon;
            this.button1.Location = new System.Drawing.Point(2, 67);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 49);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::TeamNateZone.Properties.Resources.mailIcon;
            this.button2.Location = new System.Drawing.Point(2, 119);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 52);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnAdmin
            // 
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdmin.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(437, 10);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(64, 57);
            this.btnAdmin.TabIndex = 14;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Visible = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TeamNateZone.Properties.Resources.vs5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(572, 381);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.pnlDropDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnManageAccount);
            this.Controls.Add(this.btnListClaims);
            this.Controls.Add(this.btnFileClaim);
            this.Controls.Add(this.pbPanda);
            this.Controls.Add(this.welcomeLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "WelcomeForm";
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WelcomeForm_FormClosing);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlDropDown;
        private System.Windows.Forms.Button btnLogout2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnMenuOpen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAdmin;
    }
}