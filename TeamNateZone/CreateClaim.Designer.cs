
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnFile = new CustomControls.RJControls.rndButton();
            this.btnBack = new CustomControls.RJControls.rndButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.Red;
            this.labelDate.Location = new System.Drawing.Point(86, 140);
            this.labelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(94, 38);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "Date";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.BackColor = System.Drawing.Color.Transparent;
            this.labelType.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.ForeColor = System.Drawing.Color.Red;
            this.labelType.Location = new System.Drawing.Point(86, 231);
            this.labelType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(201, 38);
            this.labelType.TabIndex = 3;
            this.labelType.Text = "Claim Type";
            // 
            // datetime
            // 
            this.datetime.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetime.Location = new System.Drawing.Point(290, 138);
            this.datetime.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(460, 35);
            this.datetime.TabIndex = 6;
            this.datetime.Value = new System.DateTime(2022, 2, 9, 22, 38, 4, 0);
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
            this.claimType.Location = new System.Drawing.Point(290, 227);
            this.claimType.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.claimType.Name = "claimType";
            this.claimType.Size = new System.Drawing.Size(460, 37);
            this.claimType.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(86, 317);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "Give us some details..";
            // 
            // detailsTextBox
            // 
            this.detailsTextBox.Location = new System.Drawing.Point(82, 358);
            this.detailsTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.detailsTextBox.Name = "detailsTextBox";
            this.detailsTextBox.Size = new System.Drawing.Size(668, 341);
            this.detailsTextBox.TabIndex = 9;
            this.detailsTextBox.Text = "";
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(604, 742);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(150, 48);
            this.btnUpload.TabIndex = 11;
            this.btnUpload.Text = "upload files";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(82, 749);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(522, 39);
            this.textBox1.TabIndex = 12;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnFile
            // 
            this.btnFile.BackColor = System.Drawing.Color.Red;
            this.btnFile.BackgroundColor = System.Drawing.Color.Red;
            this.btnFile.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnFile.BorderRadius = 15;
            this.btnFile.BorderSize = 0;
            this.btnFile.FlatAppearance.BorderSize = 0;
            this.btnFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFile.ForeColor = System.Drawing.Color.White;
            this.btnFile.Location = new System.Drawing.Point(174, 895);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(322, 65);
            this.btnFile.TabIndex = 13;
            this.btnFile.Text = "File Claim";
            this.btnFile.TextColor = System.Drawing.Color.White;
            this.btnFile.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.BackgroundColor = System.Drawing.Color.Red;
            this.btnBack.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBack.BorderRadius = 15;
            this.btnBack.BorderSize = 0;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(540, 895);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(229, 65);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.TextColor = System.Drawing.Color.White;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // CreateClaim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(888, 1006);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.detailsTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.claimType);
            this.Controls.Add(this.datetime);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelDate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CreateClaim";
            this.Text = "Make a claim";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private CustomControls.RJControls.rndButton btnFile;
        private CustomControls.RJControls.rndButton btnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}