
namespace TeamNateZone
{
    partial class ManageAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageAccount));
            this.labelTitle = new System.Windows.Forms.Label();
            this.pnlDropDown = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnLogout2 = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnMail = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlDropDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Red;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(207, 19);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(787, 85);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Account Management";
            // 
            // pnlDropDown
            // 
            this.pnlDropDown.Controls.Add(this.btnSettings);
            this.pnlDropDown.Controls.Add(this.btnLogout2);
            this.pnlDropDown.Controls.Add(this.btnMenu);
            this.pnlDropDown.Controls.Add(this.btnMainMenu);
            this.pnlDropDown.Controls.Add(this.btnMail);
            this.pnlDropDown.Location = new System.Drawing.Point(1030, 19);
            this.pnlDropDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlDropDown.MaximumSize = new System.Drawing.Size(105, 539);
            this.pnlDropDown.MinimumSize = new System.Drawing.Size(105, 109);
            this.pnlDropDown.Name = "pnlDropDown";
            this.pnlDropDown.Size = new System.Drawing.Size(105, 109);
            this.pnlDropDown.TabIndex = 13;
            // 
            // btnSettings
            // 
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(4, 330);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(96, 100);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnLogout2
            // 
            this.btnLogout2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout2.Image = global::TeamNateZone.Properties.Resources.logoutIcon;
            this.btnLogout2.Location = new System.Drawing.Point(4, 433);
            this.btnLogout2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogout2.Name = "btnLogout2";
            this.btnLogout2.Size = new System.Drawing.Size(96, 100);
            this.btnLogout2.TabIndex = 1;
            this.btnLogout2.UseVisualStyleBackColor = true;
            this.btnLogout2.Click += new System.EventHandler(this.btnLogout2_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Image = global::TeamNateZone.Properties.Resources.menuImageIcon;
            this.btnMenu.Location = new System.Drawing.Point(4, 5);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(96, 100);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMenu.Image = global::TeamNateZone.Properties.Resources.homeIcon;
            this.btnMainMenu.Location = new System.Drawing.Point(4, 128);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(96, 94);
            this.btnMainMenu.TabIndex = 1;
            this.btnMainMenu.UseVisualStyleBackColor = true;
            // 
            // btnMail
            // 
            this.btnMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMail.Image = global::TeamNateZone.Properties.Resources.mailIcon;
            this.btnMail.Location = new System.Drawing.Point(4, 225);
            this.btnMail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMail.Name = "btnMail";
            this.btnMail.Size = new System.Drawing.Size(96, 100);
            this.btnMail.TabIndex = 1;
            this.btnMail.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // ManageAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1154, 609);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlDropDown);
            this.Controls.Add(this.labelTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ManageAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageAccount";
            this.pnlDropDown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel pnlDropDown;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnLogout2;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnMail;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}