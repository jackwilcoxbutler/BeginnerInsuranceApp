
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tEAM_A_Claims_Dataset = new TeamNateZone.TEAM_A_Claims_Dataset();
            this.tEAMAClaimsDatasetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.messageBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tEAM_ADataSet = new TeamNateZone.TEAM_ADataSet();
            this.messageTableAdapter = new TeamNateZone.TEAM_ADataSetTableAdapters.messageTableAdapter();
            this.btnlogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tEAMADataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.messageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tEAM_ADataSet1 = new TeamNateZone.TEAM_ADataSet1();
            this.messageBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.messageTableAdapter1 = new TeamNateZone.TEAM_ADataSet1TableAdapters.messageTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.readorunread = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tEAM_ADataSet2 = new TeamNateZone.TEAM_ADataSet2();
            this.messageTableAdapter2 = new TeamNateZone.TEAM_ADataSet2TableAdapters.messageTableAdapter();
            this.btnInbox = new CustomControls.RJControls.rndButton();
            this.btnSent = new CustomControls.RJControls.rndButton();
            this.btnRefresh = new CustomControls.RJControls.rndButton();
            this.btnBack = new CustomControls.RJControls.rndButton();
            this.btnNewMessage = new CustomControls.RJControls.rndButton();
            ((System.ComponentModel.ISupportInitialize)(this.tEAM_A_Claims_Dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAMAClaimsDatasetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAM_ADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAMADataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAM_ADataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAM_ADataSet2)).BeginInit();
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
            this.label5.Location = new System.Drawing.Point(254, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(511, 70);
            this.label5.TabIndex = 32;
            this.label5.Text = "Messaging Center";
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
            this.btnlogout.Location = new System.Drawing.Point(1425, 19);
            this.btnlogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(129, 134);
            this.btnlogout.TabIndex = 33;
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TeamNateZone.Properties.Resources.updatedPandaIcon;
            this.pictureBox1.Location = new System.Drawing.Point(18, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // messageBindingSource
            // 
            this.messageBindingSource.DataMember = "message";
            // 
            // tEAM_ADataSet1
            // 
            this.tEAM_ADataSet1.DataSetName = "TEAM_ADataSet1";
            this.tEAM_ADataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // messageBindingSource2
            // 
            this.messageBindingSource2.DataMember = "message";
            this.messageBindingSource2.DataSource = this.tEAM_ADataSet1;
            // 
            // messageTableAdapter1
            // 
            this.messageTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.readorunread,
            this.senderDataGridViewTextBoxColumn,
            this.receiverDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn,
            this.messageDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.messageBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(13, 231);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1536, 565);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // readorunread
            // 
            this.readorunread.DataPropertyName = "readorunread";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readorunread.DefaultCellStyle = dataGridViewCellStyle2;
            this.readorunread.FillWeight = 30F;
            this.readorunread.HeaderText = "";
            this.readorunread.MinimumWidth = 6;
            this.readorunread.Name = "readorunread";
            this.readorunread.ReadOnly = true;
            this.readorunread.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // senderDataGridViewTextBoxColumn
            // 
            this.senderDataGridViewTextBoxColumn.DataPropertyName = "sender";
            this.senderDataGridViewTextBoxColumn.HeaderText = "From: ";
            this.senderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.senderDataGridViewTextBoxColumn.Name = "senderDataGridViewTextBoxColumn";
            this.senderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // receiverDataGridViewTextBoxColumn
            // 
            this.receiverDataGridViewTextBoxColumn.DataPropertyName = "receiver";
            this.receiverDataGridViewTextBoxColumn.HeaderText = "To:";
            this.receiverDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.receiverDataGridViewTextBoxColumn.Name = "receiverDataGridViewTextBoxColumn";
            this.receiverDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "Subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "Subject:";
            this.subjectDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            this.subjectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // messageDataGridViewTextBoxColumn
            // 
            this.messageDataGridViewTextBoxColumn.DataPropertyName = "message";
            this.messageDataGridViewTextBoxColumn.HeaderText = "Message Preview: ";
            this.messageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.messageDataGridViewTextBoxColumn.Name = "messageDataGridViewTextBoxColumn";
            this.messageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date Recieved:";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // messageBindingSource3
            // 
            this.messageBindingSource3.DataMember = "message";
            this.messageBindingSource3.DataSource = this.tEAM_ADataSet2;
            // 
            // tEAM_ADataSet2
            // 
            this.tEAM_ADataSet2.DataSetName = "TEAM_ADataSet2";
            this.tEAM_ADataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // messageTableAdapter2
            // 
            this.messageTableAdapter2.ClearBeforeFill = true;
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
            this.btnInbox.Location = new System.Drawing.Point(613, 121);
            this.btnInbox.Name = "btnInbox";
            this.btnInbox.Size = new System.Drawing.Size(229, 70);
            this.btnInbox.TabIndex = 38;
            this.btnInbox.Text = "Inbox";
            this.btnInbox.TextColor = System.Drawing.Color.White;
            this.btnInbox.UseVisualStyleBackColor = false;
            this.btnInbox.Click += new System.EventHandler(this.btnInbox_Click);
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
            this.btnSent.Location = new System.Drawing.Point(872, 121);
            this.btnSent.Name = "btnSent";
            this.btnSent.Size = new System.Drawing.Size(221, 70);
            this.btnSent.TabIndex = 37;
            this.btnSent.Text = "Sent";
            this.btnSent.TextColor = System.Drawing.Color.White;
            this.btnSent.UseVisualStyleBackColor = false;
            this.btnSent.Click += new System.EventHandler(this.btnSent_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.YellowGreen;
            this.btnRefresh.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.btnRefresh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRefresh.BorderRadius = 15;
            this.btnRefresh.BorderSize = 0;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(1125, 121);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(224, 70);
            this.btnRefresh.TabIndex = 36;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextColor = System.Drawing.Color.White;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.txtRefresh_Click);
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
            this.btnBack.Location = new System.Drawing.Point(1361, 813);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(188, 61);
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
            this.btnNewMessage.Location = new System.Drawing.Point(266, 121);
            this.btnNewMessage.Name = "btnNewMessage";
            this.btnNewMessage.Size = new System.Drawing.Size(318, 70);
            this.btnNewMessage.TabIndex = 29;
            this.btnNewMessage.Text = "New Message";
            this.btnNewMessage.TextColor = System.Drawing.Color.White;
            this.btnNewMessage.UseVisualStyleBackColor = false;
            this.btnNewMessage.Click += new System.EventHandler(this.btnNewMessage_Click);
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1572, 916);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnInbox);
            this.Controls.Add(this.btnSent);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNewMessage);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inbox";
            this.Load += new System.EventHandler(this.MessageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tEAM_A_Claims_Dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAMAClaimsDatasetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAM_ADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAMADataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAM_ADataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAM_ADataSet2)).EndInit();
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
        private TEAM_ADataSet tEAM_ADataSet;
        private System.Windows.Forms.BindingSource messageBindingSource1;
        private TEAM_ADataSetTableAdapters.messageTableAdapter messageTableAdapter;
        private CustomControls.RJControls.rndButton btnRefresh;
        private CustomControls.RJControls.rndButton btnSent;
        private CustomControls.RJControls.rndButton btnInbox;
        private TEAM_ADataSet1 tEAM_ADataSet1;
        private System.Windows.Forms.BindingSource messageBindingSource2;
        private TEAM_ADataSet1TableAdapters.messageTableAdapter messageTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TEAM_ADataSet2 tEAM_ADataSet2;
        private System.Windows.Forms.BindingSource messageBindingSource3;
        private TEAM_ADataSet2TableAdapters.messageTableAdapter messageTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn readorunread;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiverDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}