
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
            this.btnViewClientList = new CustomControls.RJControls.rndButton();
            this.btnViewMessages = new CustomControls.RJControls.rndButton();
            this.btnManageAccount = new CustomControls.RJControls.rndButton();
            this.btnManageFinances = new CustomControls.RJControls.rndButton();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnlogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(561, 454);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(298, 45);
            this.label4.TabIndex = 32;
            this.label4.Text = "Manage Account";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(435, 530);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 45);
            this.label3.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 45);
            this.label2.TabIndex = 30;
            this.label2.Text = "View Messages";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 454);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 45);
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
            this.btnViewClientList.Location = new System.Drawing.Point(34, 112);
            this.btnViewClientList.Name = "btnViewClientList";
            this.btnViewClientList.Size = new System.Drawing.Size(236, 322);
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
            this.btnViewMessages.Location = new System.Drawing.Point(304, 117);
            this.btnViewMessages.Name = "btnViewMessages";
            this.btnViewMessages.Size = new System.Drawing.Size(251, 324);
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
            this.btnManageAccount.Location = new System.Drawing.Point(591, 117);
            this.btnManageAccount.Name = "btnManageAccount";
            this.btnManageAccount.Size = new System.Drawing.Size(259, 327);
            this.btnManageAccount.TabIndex = 26;
            this.btnManageAccount.TextColor = System.Drawing.Color.White;
            this.btnManageAccount.UseVisualStyleBackColor = false;
            this.btnManageAccount.Click += new System.EventHandler(this.btnManageAccount_Click);
            // 
            // btnManageFinances
            // 
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
            this.btnManageFinances.Location = new System.Drawing.Point(889, 119);
            this.btnManageFinances.Name = "btnManageFinances";
            this.btnManageFinances.Size = new System.Drawing.Size(259, 333);
            this.btnManageFinances.TabIndex = 33;
            this.btnManageFinances.TextColor = System.Drawing.Color.White;
            this.btnManageFinances.UseVisualStyleBackColor = false;
            this.btnManageFinances.Click += new System.EventHandler(this.btnManageFinances_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(866, 454);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(303, 45);
            this.label5.TabIndex = 34;
            this.label5.Text = "Manage Finances";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TeamNateZone.Properties.Resources.updatedPandaIcon;
            this.pictureBox1.Location = new System.Drawing.Point(9, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // btnlogout
            // 
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Image = global::TeamNateZone.Properties.Resources.logoutIcon;
            this.btnlogout.Location = new System.Drawing.Point(1055, 8);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(86, 86);
            this.btnlogout.TabIndex = 2;
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // FMWelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 543);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnManageFinances);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnViewClientList);
            this.Controls.Add(this.btnViewMessages);
            this.Controls.Add(this.btnManageAccount);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FMWelcomeForm";
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
        private CustomControls.RJControls.rndButton btnManageFinances;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnlogout;
    }
}