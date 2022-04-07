
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
            this.labelDate = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.datetime = new System.Windows.Forms.DateTimePicker();
            this.claimType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.detailsTextBox = new System.Windows.Forms.RichTextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.txtFileUpload = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnMenu = new System.Windows.Forms.Button();
            this.pnlDropDown = new System.Windows.Forms.Panel();
            this.btnLogout2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnBack = new CustomControls.RJControls.rndButton();
            this.btnFile = new CustomControls.RJControls.rndButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlDropDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.YellowGreen;
            this.labelDate.Location = new System.Drawing.Point(86, 141);
            this.labelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(105, 38);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "Date :";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.BackColor = System.Drawing.Color.Transparent;
            this.labelType.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.ForeColor = System.Drawing.Color.YellowGreen;
            this.labelType.Location = new System.Drawing.Point(86, 231);
            this.labelType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(201, 38);
            this.labelType.TabIndex = 3;
            this.labelType.Text = "Claim Type :";
            // 
            // datetime
            // 
            this.datetime.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetime.Location = new System.Drawing.Point(234, 142);
            this.datetime.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.datetime.MaxDate = new System.DateTime(2069, 12, 28, 0, 0, 0, 0);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(460, 39);
            this.datetime.TabIndex = 6;
            this.datetime.TabStop = false;
            this.datetime.Value = new System.DateTime(2022, 3, 3, 0, 0, 0, 0);
            // 
            // claimType
            // 
            this.claimType.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.claimType.FormattingEnabled = true;
            this.claimType.Items.AddRange(new object[] {
            "Auto",
            "Home",
            "Life",
            "Other"});
            this.claimType.Location = new System.Drawing.Point(316, 238);
            this.claimType.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.claimType.Name = "claimType";
            this.claimType.Size = new System.Drawing.Size(376, 37);
            this.claimType.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.YellowGreen;
            this.label1.Location = new System.Drawing.Point(86, 317);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "Give us some details :";
            // 
            // detailsTextBox
            // 
            this.detailsTextBox.Location = new System.Drawing.Point(82, 358);
            this.detailsTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.detailsTextBox.Name = "detailsTextBox";
            this.detailsTextBox.Size = new System.Drawing.Size(668, 342);
            this.detailsTextBox.TabIndex = 9;
            this.detailsTextBox.Text = "";
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.OliveDrab;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpload.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.Location = new System.Drawing.Point(604, 745);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(150, 44);
            this.btnUpload.TabIndex = 11;
            this.btnUpload.Text = "upload files";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // txtFileUpload
            // 
            this.txtFileUpload.AllowDrop = true;
            this.txtFileUpload.Enabled = false;
            this.txtFileUpload.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileUpload.Location = new System.Drawing.Point(82, 745);
            this.txtFileUpload.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtFileUpload.Name = "txtFileUpload";
            this.txtFileUpload.Size = new System.Drawing.Size(522, 39);
            this.txtFileUpload.TabIndex = 12;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "jpg";
            this.openFileDialog1.FileName = "img";
            this.openFileDialog1.Filter = "Image files (*.jpg)|*.jpg|iPhone Images (*.heic)|*.heic";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.White;
            this.btnMenu.Image = global::TeamNateZone.Properties.Resources.menuImageIcon;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(104, 112);
            this.btnMenu.TabIndex = 16;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pnlDropDown
            // 
            this.pnlDropDown.Controls.Add(this.btnMenu);
            this.pnlDropDown.Controls.Add(this.btnLogout2);
            this.pnlDropDown.Controls.Add(this.button3);
            this.pnlDropDown.Controls.Add(this.button1);
            this.pnlDropDown.Controls.Add(this.button2);
            this.pnlDropDown.Location = new System.Drawing.Point(752, 12);
            this.pnlDropDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlDropDown.MaximumSize = new System.Drawing.Size(104, 544);
            this.pnlDropDown.MinimumSize = new System.Drawing.Size(104, 109);
            this.pnlDropDown.Name = "pnlDropDown";
            this.pnlDropDown.Size = new System.Drawing.Size(104, 109);
            this.pnlDropDown.TabIndex = 17;
            // 
            // btnLogout2
            // 
            this.btnLogout2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout2.Image = global::TeamNateZone.Properties.Resources.logoutIcon;
            this.btnLogout2.Location = new System.Drawing.Point(4, 438);
            this.btnLogout2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogout2.Name = "btnLogout2";
            this.btnLogout2.Size = new System.Drawing.Size(96, 100);
            this.btnLogout2.TabIndex = 1;
            this.btnLogout2.UseVisualStyleBackColor = true;
            this.btnLogout2.Click += new System.EventHandler(this.btnLogout2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::TeamNateZone.Properties.Resources.settingsIcon;
            this.button3.Location = new System.Drawing.Point(4, 333);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 100);
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::TeamNateZone.Properties.Resources.homeIcon;
            this.button1.Location = new System.Drawing.Point(4, 130);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 94);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::TeamNateZone.Properties.Resources.mailIcon;
            this.button2.Location = new System.Drawing.Point(4, 230);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 100);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.YellowGreen;
            this.btnBack.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.btnBack.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBack.BorderRadius = 15;
            this.btnBack.BorderSize = 0;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(520, 841);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(228, 66);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.TextColor = System.Drawing.Color.White;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnFile
            // 
            this.btnFile.BackColor = System.Drawing.Color.YellowGreen;
            this.btnFile.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.btnFile.BorderColor = System.Drawing.Color.White;
            this.btnFile.BorderRadius = 15;
            this.btnFile.BorderSize = 0;
            this.btnFile.FlatAppearance.BorderSize = 0;
            this.btnFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFile.ForeColor = System.Drawing.Color.White;
            this.btnFile.Location = new System.Drawing.Point(134, 841);
            this.btnFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(322, 66);
            this.btnFile.TabIndex = 13;
            this.btnFile.Text = "File Claim";
            this.btnFile.TextColor = System.Drawing.Color.White;
            this.btnFile.UseVisualStyleBackColor = false;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TeamNateZone.Properties.Resources.updatedPandaIcon;
            this.pictureBox2.Location = new System.Drawing.Point(14, 12);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 123);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // CreateClaim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(888, 925);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.txtFileUpload);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.claimType);
            this.Controls.Add(this.datetime);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.pnlDropDown);
            this.Controls.Add(this.detailsTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreateClaim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Make a claim";
            this.pnlDropDown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.DateTimePicker datetime;
        private System.Windows.Forms.ComboBox claimType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox detailsTextBox;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox txtFileUpload;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private CustomControls.RJControls.rndButton btnFile;
        private CustomControls.RJControls.rndButton btnBack;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel pnlDropDown;
        private System.Windows.Forms.Button btnLogout2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}