
namespace TeamNateZone
{
    partial class FMManageFinance
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
            this.FmView = new System.Windows.Forms.DataGridView();
            this.tEAM_A_Claims_Dataset = new TeamNateZone.TEAM_A_Claims_Dataset();
            this.tEAMAClaimsDatasetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtAmt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefreshTable = new CustomControls.RJControls.rndButton();
            this.btnGoBack = new CustomControls.RJControls.rndButton();
            this.btnMakeEstimate = new CustomControls.RJControls.rndButton();
            this.claimIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claimTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claimDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estimatedAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claimsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fMFinanceManageDataSet = new TeamNateZone.FMFinanceManageDataSet();
            this.claimsTableAdapter = new TeamNateZone.FMFinanceManageDataSetTableAdapters.ClaimsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.FmView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAM_A_Claims_Dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAMAClaimsDatasetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.claimsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fMFinanceManageDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // FmView
            // 
            this.FmView.AutoGenerateColumns = false;
            this.FmView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FmView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.claimIdDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.claimTypeDataGridViewTextBoxColumn,
            this.claimDescriptionDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.paymentStatusDataGridViewTextBoxColumn,
            this.estimatedAmountDataGridViewTextBoxColumn});
            this.FmView.DataSource = this.claimsBindingSource;
            this.FmView.Location = new System.Drawing.Point(-3, 12);
            this.FmView.Name = "FmView";
            this.FmView.RowHeadersWidth = 82;
            this.FmView.RowTemplate.Height = 33;
            this.FmView.Size = new System.Drawing.Size(1675, 554);
            this.FmView.TabIndex = 0;
            this.FmView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.FmView_ColumnHeaderMouseClick);
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
            // txtAmt
            // 
            this.txtAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmt.Location = new System.Drawing.Point(223, 651);
            this.txtAmt.Name = "txtAmt";
            this.txtAmt.Size = new System.Drawing.Size(670, 49);
            this.txtAmt.TabIndex = 2;
            this.txtAmt.Text = "Please select a Claim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 654);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Amount :";
            // 
            // btnRefreshTable
            // 
            this.btnRefreshTable.BackColor = System.Drawing.Color.YellowGreen;
            this.btnRefreshTable.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.btnRefreshTable.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRefreshTable.BorderRadius = 10;
            this.btnRefreshTable.BorderSize = 0;
            this.btnRefreshTable.FlatAppearance.BorderSize = 0;
            this.btnRefreshTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshTable.ForeColor = System.Drawing.Color.White;
            this.btnRefreshTable.Location = new System.Drawing.Point(1200, 630);
            this.btnRefreshTable.Name = "btnRefreshTable";
            this.btnRefreshTable.Size = new System.Drawing.Size(212, 72);
            this.btnRefreshTable.TabIndex = 5;
            this.btnRefreshTable.Text = "Refresh Table";
            this.btnRefreshTable.TextColor = System.Drawing.Color.White;
            this.btnRefreshTable.UseVisualStyleBackColor = false;
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.YellowGreen;
            this.btnGoBack.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.btnGoBack.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGoBack.BorderRadius = 10;
            this.btnGoBack.BorderSize = 0;
            this.btnGoBack.FlatAppearance.BorderSize = 0;
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.ForeColor = System.Drawing.Color.White;
            this.btnGoBack.Location = new System.Drawing.Point(1444, 630);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(212, 72);
            this.btnGoBack.TabIndex = 4;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.TextColor = System.Drawing.Color.White;
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // btnMakeEstimate
            // 
            this.btnMakeEstimate.BackColor = System.Drawing.Color.YellowGreen;
            this.btnMakeEstimate.BackgroundColor = System.Drawing.Color.YellowGreen;
            this.btnMakeEstimate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMakeEstimate.BorderRadius = 10;
            this.btnMakeEstimate.BorderSize = 0;
            this.btnMakeEstimate.FlatAppearance.BorderSize = 0;
            this.btnMakeEstimate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeEstimate.ForeColor = System.Drawing.Color.White;
            this.btnMakeEstimate.Location = new System.Drawing.Point(953, 630);
            this.btnMakeEstimate.Name = "btnMakeEstimate";
            this.btnMakeEstimate.Size = new System.Drawing.Size(212, 72);
            this.btnMakeEstimate.TabIndex = 1;
            this.btnMakeEstimate.Text = "Make Estimate";
            this.btnMakeEstimate.TextColor = System.Drawing.Color.White;
            this.btnMakeEstimate.UseVisualStyleBackColor = false;
            this.btnMakeEstimate.Click += new System.EventHandler(this.btnMakeEstimate_Click);
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
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 200;
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
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 200;
            // 
            // paymentStatusDataGridViewTextBoxColumn
            // 
            this.paymentStatusDataGridViewTextBoxColumn.DataPropertyName = "PaymentStatus";
            this.paymentStatusDataGridViewTextBoxColumn.HeaderText = "PaymentStatus";
            this.paymentStatusDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.paymentStatusDataGridViewTextBoxColumn.Name = "paymentStatusDataGridViewTextBoxColumn";
            this.paymentStatusDataGridViewTextBoxColumn.Width = 200;
            // 
            // estimatedAmountDataGridViewTextBoxColumn
            // 
            this.estimatedAmountDataGridViewTextBoxColumn.DataPropertyName = "EstimatedAmount";
            this.estimatedAmountDataGridViewTextBoxColumn.HeaderText = "EstimatedAmount";
            this.estimatedAmountDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.estimatedAmountDataGridViewTextBoxColumn.Name = "estimatedAmountDataGridViewTextBoxColumn";
            this.estimatedAmountDataGridViewTextBoxColumn.Width = 200;
            // 
            // claimsBindingSource
            // 
            this.claimsBindingSource.DataMember = "Claims";
            this.claimsBindingSource.DataSource = this.fMFinanceManageDataSet;
            // 
            // fMFinanceManageDataSet
            // 
            this.fMFinanceManageDataSet.DataSetName = "FMFinanceManageDataSet";
            this.fMFinanceManageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // claimsTableAdapter
            // 
            this.claimsTableAdapter.ClearBeforeFill = true;
            // 
            // FMManageFinance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1692, 768);
            this.Controls.Add(this.btnRefreshTable);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAmt);
            this.Controls.Add(this.btnMakeEstimate);
            this.Controls.Add(this.FmView);
            this.Name = "FMManageFinance";
            this.Text = "FMManageFinance";
            this.Load += new System.EventHandler(this.FMManageFinance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FmView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAM_A_Claims_Dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAMAClaimsDatasetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.claimsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fMFinanceManageDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView FmView;
        private System.Windows.Forms.BindingSource tEAMAClaimsDatasetBindingSource;
        private TEAM_A_Claims_Dataset tEAM_A_Claims_Dataset;
        private FMFinanceManageDataSet fMFinanceManageDataSet;
        private System.Windows.Forms.BindingSource claimsBindingSource;
        private FMFinanceManageDataSetTableAdapters.ClaimsTableAdapter claimsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn claimIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn claimTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn claimDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estimatedAmountDataGridViewTextBoxColumn;
        private CustomControls.RJControls.rndButton btnMakeEstimate;
        private System.Windows.Forms.TextBox txtAmt;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.rndButton btnGoBack;
        private CustomControls.RJControls.rndButton btnRefreshTable;
    }
}