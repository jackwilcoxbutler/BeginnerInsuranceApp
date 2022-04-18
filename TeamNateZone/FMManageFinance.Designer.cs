
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMManageFinance));
            this.FmView = new System.Windows.Forms.DataGridView();
            this.txtAmt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.claimsTableAdapter = new TeamNateZone.FMFinanceManageDataSetTableAdapters.ClaimsTableAdapter();
            this.fMFinanceManageDataSet = new TeamNateZone.FMFinanceManageDataSet();
            this.claimsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRefreshTable = new CustomControls.RJControls.rndButton();
            this.btnGoBack = new CustomControls.RJControls.rndButton();
            this.btnMakeEstimate = new CustomControls.RJControls.rndButton();
            ((System.ComponentModel.ISupportInitialize)(this.FmView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fMFinanceManageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.claimsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // FmView
            // 
            this.FmView.AllowUserToAddRows = false;
            this.FmView.AllowUserToDeleteRows = false;
            this.FmView.AllowUserToOrderColumns = true;
            this.FmView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.FmView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.FmView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FmView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FmView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.FmView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FmView.Location = new System.Drawing.Point(-3, 12);
            this.FmView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FmView.Name = "FmView";
            this.FmView.ReadOnly = true;
            this.FmView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.FmView.RowTemplate.Height = 33;
            this.FmView.Size = new System.Drawing.Size(1675, 554);
            this.FmView.TabIndex = 0;
            this.FmView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.FmView_ColumnHeaderMouseClick);
            this.FmView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.FmView_RowHeaderMouseClick);
            // 
            // txtAmt
            // 
            this.txtAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmt.Location = new System.Drawing.Point(223, 651);
            this.txtAmt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAmt.Name = "txtAmt";
            this.txtAmt.Size = new System.Drawing.Size(671, 49);
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
            // claimsTableAdapter
            // 
            this.claimsTableAdapter.ClearBeforeFill = true;
            // 
            // fMFinanceManageDataSet
            // 
            this.fMFinanceManageDataSet.DataSetName = "FMFinanceManageDataSet";
            this.fMFinanceManageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // claimsBindingSource
            // 
            this.claimsBindingSource.DataMember = "Claims";
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
            this.btnRefreshTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btnGoBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btnMakeEstimate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMakeEstimate.Name = "btnMakeEstimate";
            this.btnMakeEstimate.Size = new System.Drawing.Size(212, 72);
            this.btnMakeEstimate.TabIndex = 1;
            this.btnMakeEstimate.Text = "Make Estimate";
            this.btnMakeEstimate.TextColor = System.Drawing.Color.White;
            this.btnMakeEstimate.UseVisualStyleBackColor = false;
            this.btnMakeEstimate.Click += new System.EventHandler(this.btnMakeEstimate_Click);
            // 
            // FMManageFinance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1692, 768);
            this.Controls.Add(this.btnRefreshTable);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAmt);
            this.Controls.Add(this.btnMakeEstimate);
            this.Controls.Add(this.FmView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FMManageFinance";
            this.Text = "FMManageFinance";
            this.Load += new System.EventHandler(this.FMManageFinance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FmView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fMFinanceManageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.claimsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView FmView;
        private FMFinanceManageDataSetTableAdapters.ClaimsTableAdapter claimsTableAdapter;
        private CustomControls.RJControls.rndButton btnMakeEstimate;
        private System.Windows.Forms.TextBox txtAmt;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.rndButton btnGoBack;
        private CustomControls.RJControls.rndButton btnRefreshTable;
        private FMFinanceManageDataSet fMFinanceManageDataSet;
        private System.Windows.Forms.BindingSource claimsBindingSource;
    }
}