
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
            this.claimsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tEAM_A_Claims_Dataset = new TeamNateZone.TEAM_A_Claims_Dataset();
            this.claimsTableAdapter = new TeamNateZone.TEAM_A_Claims_DatasetTableAdapters.ClaimsTableAdapter();
            this.btnReturnToWelcome = new CustomControls.RJControls.rndButton();
            this.btnExit = new CustomControls.RJControls.rndButton();
            this.tEAM_ADataSet_Claims2 = new TeamNateZone.TEAM_ADataSet_Claims2();
            this.claimsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.claimsTableAdapter1 = new TeamNateZone.TEAM_ADataSet_Claims2TableAdapters.ClaimsTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.claimsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAM_A_Claims_Dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAM_ADataSet_Claims2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.claimsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
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
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(800, 448);
            this.dataGridView1.TabIndex = 3;
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
            // btnReturnToWelcome
            // 
            this.btnReturnToWelcome.BackColor = System.Drawing.Color.Red;
            this.btnReturnToWelcome.BackgroundColor = System.Drawing.Color.Red;
            this.btnReturnToWelcome.BorderColor = System.Drawing.Color.White;
            this.btnReturnToWelcome.BorderRadius = 15;
            this.btnReturnToWelcome.BorderSize = 0;
            this.btnReturnToWelcome.FlatAppearance.BorderSize = 0;
            this.btnReturnToWelcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnToWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnToWelcome.ForeColor = System.Drawing.Color.White;
            this.btnReturnToWelcome.Location = new System.Drawing.Point(627, 394);
            this.btnReturnToWelcome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReturnToWelcome.Name = "btnReturnToWelcome";
            this.btnReturnToWelcome.Size = new System.Drawing.Size(82, 31);
            this.btnReturnToWelcome.TabIndex = 4;
            this.btnReturnToWelcome.Text = "Return";
            this.btnReturnToWelcome.TextColor = System.Drawing.Color.White;
            this.btnReturnToWelcome.UseVisualStyleBackColor = false;
            this.btnReturnToWelcome.Click += new System.EventHandler(this.btnReturnToWelcome_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.BackgroundColor = System.Drawing.Color.Red;
            this.btnExit.BorderColor = System.Drawing.Color.White;
            this.btnExit.BorderRadius = 15;
            this.btnExit.BorderSize = 0;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(712, 394);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 31);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.TextColor = System.Drawing.Color.White;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tEAM_ADataSet_Claims2
            // 
            this.tEAM_ADataSet_Claims2.DataSetName = "TEAM_ADataSet_Claims2";
            this.tEAM_ADataSet_Claims2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // claimsBindingSource1
            // 
            this.claimsBindingSource1.DataMember = "Claims";
            this.claimsBindingSource1.DataSource = this.tEAM_ADataSet_Claims2;
            // 
            // claimsTableAdapter1
            // 
            this.claimsTableAdapter1.ClearBeforeFill = true;
            // 
            // claimIdDataGridViewTextBoxColumn
            // 
            this.claimIdDataGridViewTextBoxColumn.DataPropertyName = "ClaimId";
            this.claimIdDataGridViewTextBoxColumn.HeaderText = "ClaimId";
            this.claimIdDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.claimIdDataGridViewTextBoxColumn.Name = "claimIdDataGridViewTextBoxColumn";
            this.claimIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.claimIdDataGridViewTextBoxColumn.Width = 200;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 200;
            // 
            // userEmailDataGridViewTextBoxColumn
            // 
            this.userEmailDataGridViewTextBoxColumn.DataPropertyName = "UserEmail";
            this.userEmailDataGridViewTextBoxColumn.HeaderText = "UserEmail";
            this.userEmailDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.userEmailDataGridViewTextBoxColumn.Name = "userEmailDataGridViewTextBoxColumn";
            this.userEmailDataGridViewTextBoxColumn.Width = 200;
            // 
            // claimTypeDataGridViewTextBoxColumn
            // 
            this.claimTypeDataGridViewTextBoxColumn.DataPropertyName = "Claim_Type";
            this.claimTypeDataGridViewTextBoxColumn.HeaderText = "Claim_Type";
            this.claimTypeDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.claimTypeDataGridViewTextBoxColumn.Name = "claimTypeDataGridViewTextBoxColumn";
            this.claimTypeDataGridViewTextBoxColumn.Width = 200;
            // 
            // claimDescriptionDataGridViewTextBoxColumn
            // 
            this.claimDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Claim_Description";
            this.claimDescriptionDataGridViewTextBoxColumn.HeaderText = "Claim_Description";
            this.claimDescriptionDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.claimDescriptionDataGridViewTextBoxColumn.Name = "claimDescriptionDataGridViewTextBoxColumn";
            this.claimDescriptionDataGridViewTextBoxColumn.Width = 200;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.Width = 200;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.Width = 200;
            // 
            // EstimatedEndDate
            // 
            this.EstimatedEndDate.DataPropertyName = "EstimatedEndDate";
            this.EstimatedEndDate.HeaderText = "EstimatedEndDate";
            this.EstimatedEndDate.Name = "EstimatedEndDate";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // LastUpdate
            // 
            this.LastUpdate.DataPropertyName = "LastUpdate";
            this.LastUpdate.HeaderText = "LastUpdate";
            this.LastUpdate.Name = "LastUpdate";
            // 
            // claimList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReturnToWelcome);
            this.Controls.Add(this.dataGridView1);
            this.Name = "claimList";
            this.Text = "List of Claims";
            this.Load += new System.EventHandler(this.claimList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.claimsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAM_A_Claims_Dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAM_ADataSet_Claims2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.claimsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private TEAM_A_Claims_Dataset tEAM_A_Claims_Dataset;
        private TEAM_A_Claims_DatasetTableAdapters.ClaimsTableAdapter claimsTableAdapter;
        public System.Windows.Forms.BindingSource claimsBindingSource;
        private CustomControls.RJControls.rndButton btnReturnToWelcome;
        private CustomControls.RJControls.rndButton btnExit;
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
    }
}