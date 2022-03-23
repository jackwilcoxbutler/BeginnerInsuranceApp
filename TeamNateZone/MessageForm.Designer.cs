
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
            this.tEAM_A_Claims_Dataset = new TeamNateZone.TEAM_A_Claims_Dataset();
            this.tEAMAClaimsDatasetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tEAMADataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tEAM_ADataSet = new TeamNateZone.TEAM_ADataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnBack = new CustomControls.RJControls.rndButton();
            this.btnNewMessage = new CustomControls.RJControls.rndButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tEAM_ADataSet1 = new TeamNateZone.TEAM_ADataSet1();
            this.messageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.messageTableAdapter = new TeamNateZone.TEAM_ADataSet1TableAdapters.messageTableAdapter();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tEAM_A_Claims_Dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAMAClaimsDatasetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAMADataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAM_ADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAM_ADataSet1)).BeginInit();
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
            // tEAMADataSetBindingSource
            // 
            this.tEAMADataSetBindingSource.DataSource = this.tEAM_ADataSet;
            this.tEAMADataSetBindingSource.Position = 0;
            // 
            // tEAM_ADataSet
            // 
            this.tEAM_ADataSet.DataSetName = "TEAM_ADataSet";
            this.tEAM_ADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // btnlogout
            // 
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Image = global::TeamNateZone.Properties.Resources.logoutIcon;
            this.btnlogout.Location = new System.Drawing.Point(702, 12);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(86, 86);
            this.btnlogout.TabIndex = 33;
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
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
            this.btnBack.Location = new System.Drawing.Point(663, 102);
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.subjectDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.messageBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.Location = new System.Drawing.Point(1, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(797, 291);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tEAM_ADataSet1
            // 
            this.tEAM_ADataSet1.DataSetName = "TEAM_ADataSet1";
            this.tEAM_ADataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // messageBindingSource
            // 
            this.messageBindingSource.DataMember = "message";
            this.messageBindingSource.DataSource = this.tEAM_ADataSet1;
            // 
            // messageTableAdapter
            // 
            this.messageTableAdapter.ClearBeforeFill = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "sender";
            this.Column1.HeaderText = "From:";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "Subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "Subject:";
            this.subjectDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            this.subjectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date Received";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            ((System.ComponentModel.ISupportInitialize)(this.tEAMADataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAM_ADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAM_ADataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TEAM_A_Claims_Dataset tEAM_A_Claims_Dataset;
        private System.Windows.Forms.BindingSource tEAMAClaimsDatasetBindingSource;
        private System.Windows.Forms.BindingSource tEAMADataSetBindingSource;
        private TEAM_ADataSet tEAM_ADataSet;
        private CustomControls.RJControls.rndButton btnNewMessage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnlogout;
        private CustomControls.RJControls.rndButton btnBack;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TEAM_ADataSet1 tEAM_ADataSet1;
        private System.Windows.Forms.BindingSource messageBindingSource;
        private TEAM_ADataSet1TableAdapters.messageTableAdapter messageTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}