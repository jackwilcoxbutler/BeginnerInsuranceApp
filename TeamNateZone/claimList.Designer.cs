﻿
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(claimList));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.claimIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claimTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claimDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstimatedEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastUpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claimsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tEAM_ADataSet_Claims2 = new TeamNateZone.TEAM_ADataSet_Claims2();
            this.claimsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tEAM_A_Claims_Dataset = new TeamNateZone.TEAM_A_Claims_Dataset();
            this.claimsTableAdapter = new TeamNateZone.TEAM_A_Claims_DatasetTableAdapters.ClaimsTableAdapter();
            this.claimsTableAdapter1 = new TeamNateZone.TEAM_ADataSet_Claims2TableAdapters.ClaimsTableAdapter();
            this.lblStatus = new System.Windows.Forms.Label();
            this.viewClaimGroupBox = new System.Windows.Forms.GroupBox();
            this.maximize_rndButton1 = new CustomControls.RJControls.rndButton();
            this.viewClaimImageInstructions = new System.Windows.Forms.RichTextBox();
            this.enterClaimIDTxt = new System.Windows.Forms.TextBox();
            this.claimIdLable = new System.Windows.Forms.Label();
            this.testPictureBox = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.rndImageDownload = new CustomControls.RJControls.rndButton();
            this.btnView = new CustomControls.RJControls.rndButton();
            this.btnReturnToWelcome = new CustomControls.RJControls.rndButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.claimsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAM_ADataSet_Claims2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.claimsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAM_A_Claims_Dataset)).BeginInit();
            this.viewClaimGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.claimIdDataGridViewTextBoxColumn,
            this.claimTypeDataGridViewTextBoxColumn,
            this.claimDescriptionDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.EstimatedEndDate,
            this.Status,
            this.LastUpdate});
            this.dataGridView1.DataSource = this.claimsBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1594, 861);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // claimIdDataGridViewTextBoxColumn
            // 
            this.claimIdDataGridViewTextBoxColumn.DataPropertyName = "ClaimId";
            this.claimIdDataGridViewTextBoxColumn.HeaderText = "ClaimId";
            this.claimIdDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.claimIdDataGridViewTextBoxColumn.Name = "claimIdDataGridViewTextBoxColumn";
            this.claimIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // claimTypeDataGridViewTextBoxColumn
            // 
            this.claimTypeDataGridViewTextBoxColumn.DataPropertyName = "Claim_Type";
            this.claimTypeDataGridViewTextBoxColumn.HeaderText = "Claim Type";
            this.claimTypeDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.claimTypeDataGridViewTextBoxColumn.Name = "claimTypeDataGridViewTextBoxColumn";
            this.claimTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // claimDescriptionDataGridViewTextBoxColumn
            // 
            this.claimDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Claim_Description";
            this.claimDescriptionDataGridViewTextBoxColumn.HeaderText = "Claim Description";
            this.claimDescriptionDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.claimDescriptionDataGridViewTextBoxColumn.Name = "claimDescriptionDataGridViewTextBoxColumn";
            this.claimDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "Start Date";
            this.startDateDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // EstimatedEndDate
            // 
            this.EstimatedEndDate.DataPropertyName = "EstimatedEndDate";
            this.EstimatedEndDate.HeaderText = "Est End Date";
            this.EstimatedEndDate.MinimumWidth = 8;
            this.EstimatedEndDate.Name = "EstimatedEndDate";
            this.EstimatedEndDate.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // LastUpdate
            // 
            this.LastUpdate.DataPropertyName = "LastUpdate";
            this.LastUpdate.HeaderText = "LastUpdate";
            this.LastUpdate.MinimumWidth = 8;
            this.LastUpdate.Name = "LastUpdate";
            this.LastUpdate.ReadOnly = true;
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
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.White;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(40, 756);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 51);
            this.lblStatus.TabIndex = 9;
            // 
            // viewClaimGroupBox
            // 
            this.viewClaimGroupBox.BackColor = System.Drawing.Color.YellowGreen;
            this.viewClaimGroupBox.Controls.Add(this.maximize_rndButton1);
            this.viewClaimGroupBox.Controls.Add(this.viewClaimImageInstructions);
            this.viewClaimGroupBox.Controls.Add(this.enterClaimIDTxt);
            this.viewClaimGroupBox.Controls.Add(this.claimIdLable);
            this.viewClaimGroupBox.Controls.Add(this.testPictureBox);
            this.viewClaimGroupBox.Location = new System.Drawing.Point(1594, 0);
            this.viewClaimGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.viewClaimGroupBox.Name = "viewClaimGroupBox";
            this.viewClaimGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.viewClaimGroupBox.Size = new System.Drawing.Size(386, 861);
            this.viewClaimGroupBox.TabIndex = 10;
            this.viewClaimGroupBox.TabStop = false;
            this.viewClaimGroupBox.Text = "View Claim Images";
            // 
            // maximize_rndButton1
            // 
            this.maximize_rndButton1.BackColor = System.Drawing.Color.White;
            this.maximize_rndButton1.BackgroundColor = System.Drawing.Color.White;
            this.maximize_rndButton1.BorderColor = System.Drawing.Color.White;
            this.maximize_rndButton1.BorderRadius = 15;
            this.maximize_rndButton1.BorderSize = 0;
            this.maximize_rndButton1.FlatAppearance.BorderSize = 0;
            this.maximize_rndButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximize_rndButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximize_rndButton1.ForeColor = System.Drawing.Color.YellowGreen;
            this.maximize_rndButton1.Location = new System.Drawing.Point(39, 752);
            this.maximize_rndButton1.Name = "maximize_rndButton1";
            this.maximize_rndButton1.Size = new System.Drawing.Size(321, 62);
            this.maximize_rndButton1.TabIndex = 11;
            this.maximize_rndButton1.Text = "View Full Claim Info";
            this.maximize_rndButton1.TextColor = System.Drawing.Color.YellowGreen;
            this.maximize_rndButton1.UseVisualStyleBackColor = false;
            this.maximize_rndButton1.Click += new System.EventHandler(this.rndButton1_Click);
            // 
            // viewClaimImageInstructions
            // 
            this.viewClaimImageInstructions.BackColor = System.Drawing.Color.YellowGreen;
            this.viewClaimImageInstructions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.viewClaimImageInstructions.Location = new System.Drawing.Point(32, 75);
            this.viewClaimImageInstructions.Margin = new System.Windows.Forms.Padding(6);
            this.viewClaimImageInstructions.Name = "viewClaimImageInstructions";
            this.viewClaimImageInstructions.ReadOnly = true;
            this.viewClaimImageInstructions.Size = new System.Drawing.Size(328, 127);
            this.viewClaimImageInstructions.TabIndex = 2;
            this.viewClaimImageInstructions.Text = "In the text box below, please type the Claim ID number of the claim you wish to v" +
    "iew your submitted images.";
            // 
            // enterClaimIDTxt
            // 
            this.enterClaimIDTxt.Location = new System.Drawing.Point(96, 328);
            this.enterClaimIDTxt.Margin = new System.Windows.Forms.Padding(6);
            this.enterClaimIDTxt.Name = "enterClaimIDTxt";
            this.enterClaimIDTxt.Size = new System.Drawing.Size(196, 31);
            this.enterClaimIDTxt.TabIndex = 1;
            // 
            // claimIdLable
            // 
            this.claimIdLable.AutoSize = true;
            this.claimIdLable.Location = new System.Drawing.Point(100, 289);
            this.claimIdLable.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.claimIdLable.Name = "claimIdLable";
            this.claimIdLable.Size = new System.Drawing.Size(149, 25);
            this.claimIdLable.TabIndex = 0;
            this.claimIdLable.Text = "Enter ClaimID:";
            // 
            // testPictureBox
            // 
            this.testPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.testPictureBox.Location = new System.Drawing.Point(39, 412);
            this.testPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.testPictureBox.Name = "testPictureBox";
            this.testPictureBox.Size = new System.Drawing.Size(321, 262);
            this.testPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.testPictureBox.TabIndex = 7;
            this.testPictureBox.TabStop = false;
            this.testPictureBox.Visible = false;
            this.testPictureBox.WaitOnLoad = true;
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
            this.rndImageDownload.Location = new System.Drawing.Point(838, 758);
            this.rndImageDownload.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rndImageDownload.Name = "rndImageDownload";
            this.rndImageDownload.Size = new System.Drawing.Size(210, 59);
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
            this.btnView.Location = new System.Drawing.Point(1112, 756);
            this.btnView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(210, 59);
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
            this.btnReturnToWelcome.Location = new System.Drawing.Point(1394, 753);
            this.btnReturnToWelcome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReturnToWelcome.Name = "btnReturnToWelcome";
            this.btnReturnToWelcome.Size = new System.Drawing.Size(164, 61);
            this.btnReturnToWelcome.TabIndex = 4;
            this.btnReturnToWelcome.Text = "Back";
            this.btnReturnToWelcome.TextColor = System.Drawing.Color.White;
            this.btnReturnToWelcome.UseVisualStyleBackColor = false;
            this.btnReturnToWelcome.Click += new System.EventHandler(this.btnReturnToWelcome_Click);
            // 
            // claimList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1924, 861);
            this.Controls.Add(this.viewClaimGroupBox);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.rndImageDownload);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnReturnToWelcome);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "claimList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List of Claims";
            this.Load += new System.EventHandler(this.claimList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.claimsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAM_ADataSet_Claims2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.claimsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAM_A_Claims_Dataset)).EndInit();
            this.viewClaimGroupBox.ResumeLayout(false);
            this.viewClaimGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testPictureBox)).EndInit();
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
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private CustomControls.RJControls.rndButton maximize_rndButton1;
    }
}