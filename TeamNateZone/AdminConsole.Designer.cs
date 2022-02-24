﻿
namespace TeamNateZone
{
    partial class AdminConsole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminConsole));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new CustomControls.RJControls.rndButton();
            this.btnRegisterCM = new CustomControls.RJControls.rndButton();
            this.btnRegisterFM = new CustomControls.RJControls.rndButton();
            this.btnViewAll = new CustomControls.RJControls.rndButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gadugi", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(561, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin Console";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.BackgroundColor = System.Drawing.Color.Red;
            this.btnExit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnExit.BorderRadius = 15;
            this.btnExit.BorderSize = 0;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(724, 270);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 41);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.TextColor = System.Drawing.Color.White;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRegisterCM
            // 
            this.btnRegisterCM.BackColor = System.Drawing.Color.Red;
            this.btnRegisterCM.BackgroundColor = System.Drawing.Color.Red;
            this.btnRegisterCM.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRegisterCM.BorderRadius = 15;
            this.btnRegisterCM.BorderSize = 0;
            this.btnRegisterCM.FlatAppearance.BorderSize = 0;
            this.btnRegisterCM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterCM.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterCM.ForeColor = System.Drawing.Color.White;
            this.btnRegisterCM.Location = new System.Drawing.Point(132, 136);
            this.btnRegisterCM.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegisterCM.Name = "btnRegisterCM";
            this.btnRegisterCM.Size = new System.Drawing.Size(150, 97);
            this.btnRegisterCM.TabIndex = 5;
            this.btnRegisterCM.Text = "Register New CM";
            this.btnRegisterCM.TextColor = System.Drawing.Color.White;
            this.btnRegisterCM.UseVisualStyleBackColor = false;
            this.btnRegisterCM.Click += new System.EventHandler(this.btnRegisterCM_Click);
            // 
            // btnRegisterFM
            // 
            this.btnRegisterFM.BackColor = System.Drawing.Color.Red;
            this.btnRegisterFM.BackgroundColor = System.Drawing.Color.Red;
            this.btnRegisterFM.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRegisterFM.BorderRadius = 15;
            this.btnRegisterFM.BorderSize = 0;
            this.btnRegisterFM.FlatAppearance.BorderSize = 0;
            this.btnRegisterFM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterFM.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterFM.ForeColor = System.Drawing.Color.White;
            this.btnRegisterFM.Location = new System.Drawing.Point(345, 136);
            this.btnRegisterFM.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegisterFM.Name = "btnRegisterFM";
            this.btnRegisterFM.Size = new System.Drawing.Size(150, 97);
            this.btnRegisterFM.TabIndex = 6;
            this.btnRegisterFM.Text = "Register New FM";
            this.btnRegisterFM.TextColor = System.Drawing.Color.White;
            this.btnRegisterFM.UseVisualStyleBackColor = false;
            this.btnRegisterFM.Click += new System.EventHandler(this.btnRegisterFM_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.BackColor = System.Drawing.Color.Red;
            this.btnViewAll.BackgroundColor = System.Drawing.Color.Red;
            this.btnViewAll.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnViewAll.BorderRadius = 15;
            this.btnViewAll.BorderSize = 0;
            this.btnViewAll.FlatAppearance.BorderSize = 0;
            this.btnViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAll.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAll.ForeColor = System.Drawing.Color.White;
            this.btnViewAll.Location = new System.Drawing.Point(549, 136);
            this.btnViewAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(150, 97);
            this.btnViewAll.TabIndex = 7;
            this.btnViewAll.Text = "View All Users";
            this.btnViewAll.TextColor = System.Drawing.Color.White;
            this.btnViewAll.UseVisualStyleBackColor = false;
            // 
            // AdminConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(828, 332);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.btnRegisterFM);
            this.Controls.Add(this.btnRegisterCM);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AdminConsole";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.AdminConsole_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomControls.RJControls.rndButton btnExit;
        private CustomControls.RJControls.rndButton btnRegisterCM;
        private CustomControls.RJControls.rndButton btnRegisterFM;
        private CustomControls.RJControls.rndButton btnViewAll;
    }
}