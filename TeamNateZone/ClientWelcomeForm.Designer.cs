
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
            this.btnAdmin = new CustomControls.RJControls.rndButton();
            this.btnListClaims = new CustomControls.RJControls.rndButton();
            this.btnManageAccount = new CustomControls.RJControls.rndButton();
            this.btnlogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 507);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 45);
            this.label1.TabIndex = 20;
            this.label1.Text = "File a new claim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(408, 509);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 45);
            this.label2.TabIndex = 21;
            this.label2.Text = "View Existing";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(467, 552);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 45);
            this.label3.TabIndex = 22;
            this.label3.Text = "Claims";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(751, 509);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(298, 45);
            this.label4.TabIndex = 23;
            this.label4.Text = "Manage Account";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TeamNateZone.Properties.Resources.updatedPandaIcon;
            this.pictureBox1.Location = new System.Drawing.Point(9, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 129);
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
            this.btnFileClaim.Location = new System.Drawing.Point(40, 133);
            this.btnFileClaim.Name = "btnFileClaim";
            this.btnFileClaim.Size = new System.Drawing.Size(269, 373);
            this.btnFileClaim.TabIndex = 18;
            this.btnFileClaim.TextColor = System.Drawing.Color.White;
            this.btnFileClaim.UseVisualStyleBackColor = false;
            this.btnFileClaim.Click += new System.EventHandler(this.btnFileClaim_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.White;
            this.btnAdmin.BackgroundColor = System.Drawing.Color.White;
            this.btnAdmin.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnAdmin.BorderRadius = 10;
            this.btnAdmin.BorderSize = 5;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Mongolian Baiti", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.Black;
            this.btnAdmin.Location = new System.Drawing.Point(801, 30);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(101, 72);
            this.btnAdmin.TabIndex = 16;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.TextColor = System.Drawing.Color.Black;
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Visible = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
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
            this.btnListClaims.Location = new System.Drawing.Point(400, 134);
            this.btnListClaims.Name = "btnListClaims";
            this.btnListClaims.Size = new System.Drawing.Size(269, 373);
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
            this.btnManageAccount.Location = new System.Drawing.Point(761, 134);
            this.btnManageAccount.Name = "btnManageAccount";
            this.btnManageAccount.Size = new System.Drawing.Size(269, 373);
            this.btnManageAccount.TabIndex = 17;
            this.btnManageAccount.TextColor = System.Drawing.Color.White;
            this.btnManageAccount.UseVisualStyleBackColor = false;
            this.btnManageAccount.Click += new System.EventHandler(this.btnManageAccount_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Image = global::TeamNateZone.Properties.Resources.logoutIcon;
            this.btnlogout.Location = new System.Drawing.Point(944, 25);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(86, 86);
            this.btnlogout.TabIndex = 2;
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click_1);
            // 
            // ClientWelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1073, 675);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnFileClaim);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnListClaims);
            this.Controls.Add(this.btnManageAccount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "ClientWelcomeForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WelcomeForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControls.RJControls.rndButton btnListClaims;
        private CustomControls.RJControls.rndButton btnAdmin;
        private CustomControls.RJControls.rndButton btnManageAccount;
        private CustomControls.RJControls.rndButton btnFileClaim;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnlogout;
    }
}