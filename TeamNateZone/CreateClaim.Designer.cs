
namespace TeamNateZone
{
    partial class CreateClaim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateClaim));
            this.txtDate = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.btnFile = new System.Windows.Forms.Button();
            this.pnlDropDown = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnLogout2 = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnMail = new System.Windows.Forms.Button();
            this.pnlDropDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(196, 88);
            this.txtDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(285, 22);
            this.txtDate.TabIndex = 0;
            this.txtDate.TextChanged += new System.EventHandler(this.txtDate_TextChanged);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(61, 30);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(118, 37);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(124, 86);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(53, 25);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "Date";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.Location = new System.Drawing.Point(124, 137);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(112, 25);
            this.labelType.TabIndex = 3;
            this.labelType.Text = "Claim Type";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(263, 140);
            this.txtType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(263, 22);
            this.txtType.TabIndex = 4;
            // 
            // btnFile
            // 
            this.btnFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFile.Location = new System.Drawing.Point(329, 332);
            this.btnFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(116, 35);
            this.btnFile.TabIndex = 5;
            this.btnFile.Text = "File Claim";
            this.btnFile.UseVisualStyleBackColor = true;
            // 
            // pnlDropDown
            // 
            this.pnlDropDown.Controls.Add(this.btnSettings);
            this.pnlDropDown.Controls.Add(this.btnLogout2);
            this.pnlDropDown.Controls.Add(this.btnMenu);
            this.pnlDropDown.Controls.Add(this.btnMainMenu);
            this.pnlDropDown.Controls.Add(this.btnMail);
            this.pnlDropDown.Location = new System.Drawing.Point(739, 12);
            this.pnlDropDown.MaximumSize = new System.Drawing.Size(70, 345);
            this.pnlDropDown.MinimumSize = new System.Drawing.Size(70, 70);
            this.pnlDropDown.Name = "pnlDropDown";
            this.pnlDropDown.Size = new System.Drawing.Size(70, 70);
            this.pnlDropDown.TabIndex = 13;
            // 
            // btnSettings
            // 
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(3, 211);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(64, 64);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.UseVisualStyleBackColor = true;
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
            this.btnLogout2.Click += new System.EventHandler(this.btnLogout2_Click);
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
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
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
            // CreateClaim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TeamNateZone.Properties.Resources.vs5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(821, 447);
            this.Controls.Add(this.pnlDropDown);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtDate);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreateClaim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateClaim";
            this.pnlDropDown.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Panel pnlDropDown;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnLogout2;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnMail;
    }
}