
namespace TeamNateZone
{
    partial class claimList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.claimIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claimTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claimDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstimatedEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastUpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claimsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tEAM_ADataSet_Claims2 = new TeamNateZone.TEAM_ADataSet_Claims2();
            this.claimsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tEAM_A_Claims_Dataset = new TeamNateZone.TEAM_A_Claims_Dataset();
            this.claimsTableAdapter = new TeamNateZone.TEAM_A_Claims_DatasetTableAdapters.ClaimsTableAdapter();
            this.claimsTableAdapter1 = new TeamNateZone.TEAM_ADataSet_Claims2TableAdapters.ClaimsTableAdapter();
            this.testPictureBox = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.viewClaimGroupBox = new System.Windows.Forms.GroupBox();
            this.claimIdLable = new System.Windows.Forms.Label();
            this.enterClaimIDTxt = new System.Windows.Forms.TextBox();
            this.viewClaimImageInstructions = new System.Windows.Forms.RichTextBox();
            this.rndImageDownload = new CustomControls.RJControls.rndButton();
            this.btnView = new CustomControls.RJControls.rndButton();
            this.btnReturnToWelcome = new CustomControls.RJControls.rndButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.claimsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAM_ADataSet_Claims2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.claimsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAM_A_Claims_Dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testPictureBox)).BeginInit();
            this.viewClaimGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.claimIdDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.userEmailDataGridViewTextBoxColumn,
            this.claimTypeDataGridViewTextBoxColumn,
            this.claimDescriptionDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.EstimatedEndDate,
            this.Status,
            this.LastUpdate});
            this.dataGridView1.DataSource = this.claimsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(800, 448);
            this.dataGridView1.TabIndex = 3;
            // 
            // claimIdDataGridViewTextBoxColumn
            // 
            this.claimIdDataGridViewTextBoxColumn.DataPropertyName = "ClaimId";
            this.claimIdDataGridViewTextBoxColumn.HeaderText = "ClaimId";
            this.claimIdDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.claimIdDataGridViewTextBoxColumn.Name = "claimIdDataGridViewTextBoxColumn";
            this.claimIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.claimIdDataGridViewTextBoxColumn.Width = 66;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.Width = 65;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 80;
            // 
            // userEmailDataGridViewTextBoxColumn
            // 
            this.userEmailDataGridViewTextBoxColumn.DataPropertyName = "UserEmail";
            this.userEmailDataGridViewTextBoxColumn.HeaderText = "UserEmail";
            this.userEmailDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.userEmailDataGridViewTextBoxColumn.Name = "userEmailDataGridViewTextBoxColumn";
            this.userEmailDataGridViewTextBoxColumn.Width = 79;
            // 
            // claimTypeDataGridViewTextBoxColumn
            // 
            this.claimTypeDataGridViewTextBoxColumn.DataPropertyName = "Claim_Type";
            this.claimTypeDataGridViewTextBoxColumn.HeaderText = "Claim_Type";
            this.claimTypeDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.claimTypeDataGridViewTextBoxColumn.Name = "claimTypeDataGridViewTextBoxColumn";
            this.claimTypeDataGridViewTextBoxColumn.Width = 87;
            // 
            // claimDescriptionDataGridViewTextBoxColumn
            // 
            this.claimDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Claim_Description";
            this.claimDescriptionDataGridViewTextBoxColumn.HeaderText = "Claim_Description";
            this.claimDescriptionDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.claimDescriptionDataGridViewTextBoxColumn.Name = "claimDescriptionDataGridViewTextBoxColumn";
            this.claimDescriptionDataGridViewTextBoxColumn.Width = 116;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.Width = 77;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.Width = 74;
            // 
            // EstimatedEndDate
            // 
            this.EstimatedEndDate.DataPropertyName = "EstimatedEndDate";
            this.EstimatedEndDate.HeaderText = "EstimatedEndDate";
            this.EstimatedEndDate.MinimumWidth = 8;
            this.EstimatedEndDate.Name = "EstimatedEndDate";
            this.EstimatedEndDate.Width = 120;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            this.Status.Width = 62;
            // 
            // LastUpdate
            // 
            this.LastUpdate.DataPropertyName = "LastUpdate";
            this.LastUpdate.HeaderText = "LastUpdate";
            this.LastUpdate.MinimumWidth = 8;
            this.LastUpdate.Name = "LastUpdate";
            this.LastUpdate.Width = 87;
            // 
            // claimsBindingSource1
            // 
            this.claimsBindingSource1.DataMember = "Claims";
            this.claimsBindingSource1.DataSource = this.tEAM_ADataSet_Claims2;
            // 
            // tEAM_ADataSet_Claims2
            // 
            this.tEAM_ADataSet_Claims2.DataSetName = "TEAM_ADataSet_Claims2";
            this.tEAM_ADataSet_Claims2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // claimsBindingSource
            // 
            this.claimsBindingSource.DataMember = "Claims";
            this.claimsBindingSource.DataSource = this.tEAM_A_Claims_Dataset;
            // 
            // tEAM_A_Claims_Dataset
            // 
            this.tEAM_A_Claims_Dataset.DataSetName = "TEAM_A_Claims_Dataset";
            this.tEAM_A_Claims_Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // claimsTableAdapter
            // 
            this.claimsTableAdapter.ClearBeforeFill = true;
            // 
            // claimsTableAdapter1
            // 
            this.claimsTableAdapter1.ClearBeforeFill = true;
            // 
            // testPictureBox
            // 
            this.testPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.testPictureBox.Location = new System.Drawing.Point(6, 257);
            this.testPictureBox.Name = "testPictureBox";
            this.testPictureBox.Size = new System.Drawing.Size(178, 136);
            this.testPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.testPictureBox.TabIndex = 7;
            this.testPictureBox.TabStop = false;
            this.testPictureBox.Visible = false;
            this.testPictureBox.WaitOnLoad = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.White;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(20, 393);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 26);
            this.lblStatus.TabIndex = 9;
            // 
            // viewClaimGroupBox
            // 
            this.viewClaimGroupBox.BackColor = System.Drawing.Color.YellowGreen;
            this.viewClaimGroupBox.Controls.Add(this.viewClaimImageInstructions);
            this.viewClaimGroupBox.Controls.Add(this.enterClaimIDTxt);
            this.viewClaimGroupBox.Controls.Add(this.claimIdLable);
            this.viewClaimGroupBox.Controls.Add(this.testPictureBox);
            this.viewClaimGroupBox.Location = new System.Drawing.Point(799, 0);
            this.viewClaimGroupBox.Name = "viewClaimGroupBox";
            this.viewClaimGroupBox.Size = new System.Drawing.Size(191, 448);
            this.viewClaimGroupBox.TabIndex = 10;
            this.viewClaimGroupBox.TabStop = false;
            this.viewClaimGroupBox.Text = "View Claim Images";
            // 
            // claimIdLable
            // 
            this.claimIdLable.AutoSize = true;
            this.claimIdLable.Location = new System.Drawing.Point(50, 149);
            this.claimIdLable.Name = "claimIdLable";
            this.claimIdLable.Size = new System.Drawing.Size(74, 13);
            this.claimIdLable.TabIndex = 0;
            this.claimIdLable.Text = "Enter ClaimID:";
            // 
            // enterClaimIDTxt
            // 
            this.enterClaimIDTxt.Location = new System.Drawing.Point(48, 171);
            this.enterClaimIDTxt.Name = "enterClaimIDTxt";
            this.enterClaimIDTxt.Size = new System.Drawing.Size(100, 20);
            this.enterClaimIDTxt.TabIndex = 1;
            // 
            // viewClaimImageInstructions
            // 
            this.viewClaimImageInstructions.BackColor = System.Drawing.Color.YellowGreen;
            this.viewClaimImageInstructions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.viewClaimImageInstructions.Location = new System.Drawing.Point(16, 39);
            this.viewClaimImageInstructions.Name = "viewClaimImageInstructions";
            this.viewClaimImageInstructions.ReadOnly = true;
            this.viewClaimImageInstructions.Size = new System.Drawing.Size(164, 66);
            this.viewClaimImageInstructions.TabIndex = 2;
            this.viewClaimImageInstructions.Text = "In the text box below, please type the Claim ID number of the claim you wish to v" +
    "iew your submitted images.";
            // 
            // rndImageDownload
            // 
            this.rndImageDownload.BackColor = System.Drawing.Color.YellowGreen;
            this.rndImageDownload.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.rndImageDownload.BorderColor = System.Drawing.Color.White;
            this.rndImageDownload.BorderRadius = 15;
            this.rndImageDownload.BorderSize = 0;
            this.rndImageDownload.FlatAppearance.BorderSize = 0;
            this.rndImageDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rndImageDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rndImageDownload.ForeColor = System.Drawing.Color.White;
            this.rndImageDownload.Location = new System.Drawing.Point(419, 394);
            this.rndImageDownload.Margin = new System.Windows.Forms.Padding(2);
            this.rndImageDownload.Name = "rndImageDownload";
            this.rndImageDownload.Size = new System.Drawing.Size(105, 31);
            this.rndImageDownload.TabIndex = 8;
            this.rndImageDownload.Text = "Download";
            this.rndImageDownload.TextColor = System.Drawing.Color.White;
            this.rndImageDownload.UseVisualStyleBackColor = false;
            this.rndImageDownload.Click += new System.EventHandler(this.rndImageDownload_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.YellowGreen;
            this.btnView.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.btnView.BorderColor = System.Drawing.Color.White;
            this.btnView.BorderRadius = 15;
            this.btnView.BorderSize = 0;
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(556, 393);
            this.btnView.Margin = new System.Windows.Forms.Padding(2);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(105, 31);
            this.btnView.TabIndex = 6;
            this.btnView.Text = "View Image";
            this.btnView.TextColor = System.Drawing.Color.White;
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnReturnToWelcome
            // 
            this.btnReturnToWelcome.BackColor = System.Drawing.Color.YellowGreen;
            this.btnReturnToWelcome.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.btnReturnToWelcome.BorderColor = System.Drawing.Color.White;
            this.btnReturnToWelcome.BorderRadius = 15;
            this.btnReturnToWelcome.BorderSize = 0;
            this.btnReturnToWelcome.FlatAppearance.BorderSize = 0;
            this.btnReturnToWelcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnToWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnToWelcome.ForeColor = System.Drawing.Color.White;
            this.btnReturnToWelcome.Location = new System.Drawing.Point(700, 394);
            this.btnReturnToWelcome.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturnToWelcome.Name = "btnReturnToWelcome";
            this.btnReturnToWelcome.Size = new System.Drawing.Size(82, 31);
            this.btnReturnToWelcome.TabIndex = 4;
            this.btnReturnToWelcome.Text = "Return";
            this.btnReturnToWelcome.TextColor = System.Drawing.Color.White;
            this.btnReturnToWelcome.UseVisualStyleBackColor = false;
            this.btnReturnToWelcome.Click += new System.EventHandler(this.btnReturnToWelcome_Click);
            // 
            // claimList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(991, 448);
            this.Controls.Add(this.viewClaimGroupBox);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.rndImageDownload);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnReturnToWelcome);
            this.Controls.Add(this.dataGridView1);
            this.Name = "claimList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List of Claims";
            this.Load += new System.EventHandler(this.claimList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.claimsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAM_ADataSet_Claims2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.claimsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAM_A_Claims_Dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testPictureBox)).EndInit();
            this.viewClaimGroupBox.ResumeLayout(false);
            this.viewClaimGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private TEAM_A_Claims_Dataset tEAM_A_Claims_Dataset;
        private TEAM_A_Claims_DatasetTableAdapters.ClaimsTableAdapter claimsTableAdapter;
        public System.Windows.Forms.BindingSource claimsBindingSource;
        private CustomControls.RJControls.rndButton btnReturnToWelcome;
        private TEAM_ADataSet_Claims2 tEAM_ADataSet_Claims2;
        private System.Windows.Forms.BindingSource claimsBindingSource1;
        private TEAM_ADataSet_Claims2TableAdapters.ClaimsTableAdapter claimsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn claimIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn claimTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn claimDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstimatedEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastUpdate;
        private CustomControls.RJControls.rndButton btnView;
        private System.Windows.Forms.PictureBox testPictureBox;
        private CustomControls.RJControls.rndButton rndImageDownload;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox viewClaimGroupBox;
        private System.Windows.Forms.RichTextBox viewClaimImageInstructions;
        private System.Windows.Forms.TextBox enterClaimIDTxt;
        private System.Windows.Forms.Label claimIdLable;
    }
}