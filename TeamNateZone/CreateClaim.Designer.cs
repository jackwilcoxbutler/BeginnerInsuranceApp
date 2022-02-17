
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
            this.btnBack = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.btnFile = new System.Windows.Forms.Button();
            this.datetime = new System.Windows.Forms.DateTimePicker();
            this.claimType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.detailsTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(288, 469);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 30);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDate.Location = new System.Drawing.Point(43, 73);
            this.labelDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(46, 18);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "Date";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.BackColor = System.Drawing.Color.Transparent;
            this.labelType.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelType.Location = new System.Drawing.Point(43, 120);
            this.labelType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(102, 18);
            this.labelType.TabIndex = 3;
            this.labelType.Text = "Claim Type";
            // 
            // btnFile
            // 
            this.btnFile.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFile.Location = new System.Drawing.Point(160, 470);
            this.btnFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(124, 29);
            this.btnFile.TabIndex = 5;
            this.btnFile.Text = "File Claim";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // datetime
            // 
            this.datetime.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetime.Location = new System.Drawing.Point(145, 72);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(232, 21);
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
            this.claimType.Location = new System.Drawing.Point(145, 118);
            this.claimType.Name = "claimType";
            this.claimType.Size = new System.Drawing.Size(232, 23);
            this.claimType.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(43, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Give us some details..";
            // 
            // detailsTextBox
            // 
            this.detailsTextBox.Location = new System.Drawing.Point(41, 186);
            this.detailsTextBox.Name = "detailsTextBox";
            this.detailsTextBox.Size = new System.Drawing.Size(336, 179);
            this.detailsTextBox.TabIndex = 9;
            this.detailsTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(36, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Panda Insurance";
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(302, 386);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 25);
            this.btnUpload.TabIndex = 11;
            this.btnUpload.Text = "upload files";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(46, 387);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 23);
            this.textBox1.TabIndex = 12;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CreateClaim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TeamNateZone.Properties.Resources.vs5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(444, 523);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.detailsTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.claimType);
            this.Controls.Add(this.datetime);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.btnBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreateClaim";
            this.Text = "Make a claim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.DateTimePicker datetime;
        private System.Windows.Forms.ComboBox claimType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox detailsTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}