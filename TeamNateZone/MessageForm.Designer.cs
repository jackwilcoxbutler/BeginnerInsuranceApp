
namespace TeamNateZone
{
    partial class MessageForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tEAM_A_Claims_Dataset = new TeamNateZone.TEAM_A_Claims_Dataset();
            this.tEAMAClaimsDatasetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.messageBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tEAM_ADataSet = new TeamNateZone.TEAM_ADataSet();
            this.messageTableAdapter = new TeamNateZone.TEAM_ADataSetTableAdapters.messageTableAdapter();
            this.btnlogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tEAMADataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.messageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBack = new CustomControls.RJControls.rndButton();
            this.btnNewMessage = new CustomControls.RJControls.rndButton();
            this.txtRefresh = new CustomControls.RJControls.rndButton();
            this.btnSent = new CustomControls.RJControls.rndButton();
            this.btnInbox = new CustomControls.RJControls.rndButton();
            this.sender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reveiver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tEAM_A_Claims_Dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAMAClaimsDatasetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAM_ADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAMADataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tEAM_A_Claims_Dataset
            // 
            this.tEAM_A_Claims_Dataset.DataSetName = "TEAM_A_Claims_Dataset";
            this.tEAM_A_Claims_Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tEAMAClaimsDatasetBindingSource
            // 
            this.tEAMAClaimsDatasetBindingSource.DataSource = this.tEAM_A_Claims_Dataset;
            this.tEAMAClaimsDatasetBindingSource.Position = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(169, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(318, 44);
            this.label5.TabIndex = 32;
            this.label5.Text = "Messaging Center";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sender,
            this.reveiver,
            this.Subject,
            this.message,
            this.date});
            this.dataGridView1.DataSource = this.messageBindingSource1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(13, 147);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1023, 416);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // messageBindingSource1
            // 
            this.messageBindingSource1.DataMember = "message";
            this.messageBindingSource1.DataSource = this.tEAM_ADataSet;
            // 
            // tEAM_ADataSet
            // 
            this.tEAM_ADataSet.DataSetName = "TEAM_ADataSet";
            this.tEAM_ADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // messageTableAdapter
            // 
            this.messageTableAdapter.ClearBeforeFill = true;
            // 
            // btnlogout
            // 
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Image = global::TeamNateZone.Properties.Resources.logoutIcon;
            this.btnlogout.Location = new System.Drawing.Point(950, 12);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(86, 86);
            this.btnlogout.TabIndex = 33;
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TeamNateZone.Properties.Resources.updatedPandaIcon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // messageBindingSource
            // 
            this.messageBindingSource.DataMember = "message";
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
            this.btnBack.Location = new System.Drawing.Point(911, 103);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(125, 39);
            this.btnBack.TabIndex = 34;
            this.btnBack.Text = "Back";
            this.btnBack.TextColor = System.Drawing.Color.White;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNewMessage
            // 
            this.btnNewMessage.BackColor = System.Drawing.Color.YellowGreen;
            this.btnNewMessage.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.btnNewMessage.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNewMessage.BorderRadius = 15;
            this.btnNewMessage.BorderSize = 0;
            this.btnNewMessage.FlatAppearance.BorderSize = 0;
            this.btnNewMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewMessage.ForeColor = System.Drawing.Color.White;
            this.btnNewMessage.Location = new System.Drawing.Point(177, 96);
            this.btnNewMessage.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewMessage.Name = "btnNewMessage";
            this.btnNewMessage.Size = new System.Drawing.Size(212, 45);
            this.btnNewMessage.TabIndex = 29;
            this.btnNewMessage.Text = "New Message";
            this.btnNewMessage.TextColor = System.Drawing.Color.White;
            this.btnNewMessage.UseVisualStyleBackColor = false;
            this.btnNewMessage.Click += new System.EventHandler(this.btnNewMessage_Click);
            // 
            // txtRefresh
            // 
            this.txtRefresh.BackColor = System.Drawing.Color.YellowGreen;
            this.txtRefresh.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.txtRefresh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.txtRefresh.BorderRadius = 15;
            this.txtRefresh.BorderSize = 0;
            this.txtRefresh.FlatAppearance.BorderSize = 0;
            this.txtRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRefresh.ForeColor = System.Drawing.Color.White;
            this.txtRefresh.Location = new System.Drawing.Point(746, 103);
            this.txtRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.txtRefresh.Name = "txtRefresh";
            this.txtRefresh.Size = new System.Drawing.Size(145, 39);
            this.txtRefresh.TabIndex = 36;
            this.txtRefresh.Text = "Refresh";
            this.txtRefresh.TextColor = System.Drawing.Color.White;
            this.txtRefresh.UseVisualStyleBackColor = false;
            this.txtRefresh.Click += new System.EventHandler(this.txtRefresh_Click);
            // 
            // btnSent
            // 
            this.btnSent.BackColor = System.Drawing.Color.YellowGreen;
            this.btnSent.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.btnSent.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSent.BorderRadius = 15;
            this.btnSent.BorderSize = 0;
            this.btnSent.FlatAppearance.BorderSize = 0;
            this.btnSent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSent.ForeColor = System.Drawing.Color.White;
            this.btnSent.Location = new System.Drawing.Point(583, 103);
            this.btnSent.Margin = new System.Windows.Forms.Padding(2);
            this.btnSent.Name = "btnSent";
            this.btnSent.Size = new System.Drawing.Size(145, 39);
            this.btnSent.TabIndex = 37;
            this.btnSent.Text = "Sent";
            this.btnSent.TextColor = System.Drawing.Color.White;
            this.btnSent.UseVisualStyleBackColor = false;
            this.btnSent.Click += new System.EventHandler(this.btnSent_Click);
            // 
            // btnInbox
            // 
            this.btnInbox.BackColor = System.Drawing.Color.YellowGreen;
            this.btnInbox.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.btnInbox.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnInbox.BorderRadius = 15;
            this.btnInbox.BorderSize = 0;
            this.btnInbox.FlatAppearance.BorderSize = 0;
            this.btnInbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInbox.ForeColor = System.Drawing.Color.White;
            this.btnInbox.Location = new System.Drawing.Point(419, 103);
            this.btnInbox.Margin = new System.Windows.Forms.Padding(2);
            this.btnInbox.Name = "btnInbox";
            this.btnInbox.Size = new System.Drawing.Size(145, 39);
            this.btnInbox.TabIndex = 38;
            this.btnInbox.Text = "Inbox";
            this.btnInbox.TextColor = System.Drawing.Color.White;
            this.btnInbox.UseVisualStyleBackColor = false;
            this.btnInbox.Click += new System.EventHandler(this.btnInbox_Click);
            // 
            // sender
            // 
            this.sender.DataPropertyName = "sender";
            this.sender.HeaderText = "From:";
            this.sender.MinimumWidth = 6;
            this.sender.Name = "sender";
            this.sender.ReadOnly = true;
            // 
            // reveiver
            // 
            this.reveiver.DataPropertyName = "receiver";
            this.reveiver.HeaderText = "To:";
            this.reveiver.MinimumWidth = 6;
            this.reveiver.Name = "reveiver";
            this.reveiver.ReadOnly = true;
            // 
            // Subject
            // 
            this.Subject.DataPropertyName = "Subject";
            this.Subject.HeaderText = "Subject:";
            this.Subject.MinimumWidth = 6;
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            // 
            // message
            // 
            this.message.DataPropertyName = "message";
            this.message.HeaderText = "Message Preview: ";
            this.message.MinimumWidth = 6;
            this.message.Name = "message";
            this.message.ReadOnly = true;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Date Received: ";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1048, 575);
            this.Controls.Add(this.btnInbox);
            this.Controls.Add(this.btnSent);
            this.Controls.Add(this.txtRefresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNewMessage);
            this.Name = "MessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inbox";
            this.Load += new System.EventHandler(this.MessageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tEAM_A_Claims_Dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAMAClaimsDatasetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAM_ADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAMADataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TEAM_A_Claims_Dataset tEAM_A_Claims_Dataset;
        private System.Windows.Forms.BindingSource tEAMAClaimsDatasetBindingSource;
        private System.Windows.Forms.BindingSource tEAMADataSetBindingSource;
      //  private TEAM_ADataSet tEAM_ADataSet;
        private CustomControls.RJControls.rndButton btnNewMessage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnlogout;
        private CustomControls.RJControls.rndButton btnBack;
        //private TEAM_ADataSet1 tEAM_ADataSet1;
        private System.Windows.Forms.BindingSource messageBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TEAM_ADataSet tEAM_ADataSet;
        private System.Windows.Forms.BindingSource messageBindingSource1;
        private TEAM_ADataSetTableAdapters.messageTableAdapter messageTableAdapter;
        private CustomControls.RJControls.rndButton txtRefresh;
        private CustomControls.RJControls.rndButton btnSent;
        private CustomControls.RJControls.rndButton btnInbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn sender;
        private System.Windows.Forms.DataGridViewTextBoxColumn reveiver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn message;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
    }
}