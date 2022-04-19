
namespace TeamNateZone
{
    partial class folderPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(folderPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new CustomControls.RJControls.rndButton();
            this.dataGridView_Folders = new System.Windows.Forms.DataGridView();
            this.folderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foldersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tEAM_ADataSet_Folders = new TeamNateZone.TEAM_ADataSet_Folders();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExpand = new CustomControls.RJControls.rndButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.folderIdLbl = new System.Windows.Forms.Label();
            this.folderIdTxt = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.foldersTableAdapter = new TeamNateZone.TEAM_ADataSet_FoldersTableAdapters.FoldersTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Folders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foldersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAM_ADataSet_Folders)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.dataGridView_Folders);
            this.panel1.Location = new System.Drawing.Point(4, 94);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1312, 773);
            this.panel1.TabIndex = 0;
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
            this.btnBack.Location = new System.Drawing.Point(1086, 688);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(188, 62);
            this.btnBack.TabIndex = 35;
            this.btnBack.Text = "Back";
            this.btnBack.TextColor = System.Drawing.Color.White;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataGridView_Folders
            // 
            this.dataGridView_Folders.AutoGenerateColumns = false;
            this.dataGridView_Folders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Folders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.folderIDDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn});
            this.dataGridView_Folders.DataSource = this.foldersBindingSource;
            this.dataGridView_Folders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Folders.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Folders.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView_Folders.Name = "dataGridView_Folders";
            this.dataGridView_Folders.RowHeadersWidth = 82;
            this.dataGridView_Folders.Size = new System.Drawing.Size(1312, 773);
            this.dataGridView_Folders.TabIndex = 0;
            // 
            // folderIDDataGridViewTextBoxColumn
            // 
            this.folderIDDataGridViewTextBoxColumn.DataPropertyName = "FolderID";
            this.folderIDDataGridViewTextBoxColumn.HeaderText = "FolderID";
            this.folderIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.folderIDDataGridViewTextBoxColumn.Name = "folderIDDataGridViewTextBoxColumn";
            this.folderIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.folderIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // foldersBindingSource
            // 
            this.foldersBindingSource.DataMember = "Folders";
            this.foldersBindingSource.DataSource = this.tEAM_ADataSet_Folders;
            // 
            // tEAM_ADataSet_Folders
            // 
            this.tEAM_ADataSet_Folders.DataSetName = "TEAM_ADataSet_Folders";
            this.tEAM_ADataSet_Folders.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.YellowGreen;
            this.panel2.Controls.Add(this.btnExpand);
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.folderIdLbl);
            this.panel2.Controls.Add(this.folderIdTxt);
            this.panel2.Location = new System.Drawing.Point(1314, -4);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 871);
            this.panel2.TabIndex = 1;
            // 
            // btnExpand
            // 
            this.btnExpand.BackColor = System.Drawing.Color.White;
            this.btnExpand.BackgroundColor = System.Drawing.Color.White;
            this.btnExpand.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnExpand.BorderRadius = 15;
            this.btnExpand.BorderSize = 0;
            this.btnExpand.FlatAppearance.BorderSize = 0;
            this.btnExpand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpand.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpand.ForeColor = System.Drawing.Color.YellowGreen;
            this.btnExpand.Location = new System.Drawing.Point(38, 642);
            this.btnExpand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(224, 87);
            this.btnExpand.TabIndex = 35;
            this.btnExpand.Text = "Expand";
            this.btnExpand.TextColor = System.Drawing.Color.YellowGreen;
            this.btnExpand.UseVisualStyleBackColor = false;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.YellowGreen;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(36, 98);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(224, 185);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "Please type in the FolderID of the Client Folder you wish to look into in the tex" +
    "tbox below.";
            // 
            // folderIdLbl
            // 
            this.folderIdLbl.AutoSize = true;
            this.folderIdLbl.Location = new System.Drawing.Point(32, 350);
            this.folderIdLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.folderIdLbl.Name = "folderIdLbl";
            this.folderIdLbl.Size = new System.Drawing.Size(105, 25);
            this.folderIdLbl.TabIndex = 1;
            this.folderIdLbl.Text = "Folder ID:";
            // 
            // folderIdTxt
            // 
            this.folderIdTxt.Location = new System.Drawing.Point(38, 381);
            this.folderIdTxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.folderIdTxt.Name = "folderIdTxt";
            this.folderIdTxt.Size = new System.Drawing.Size(196, 31);
            this.folderIdTxt.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.YellowGreen;
            this.panel3.Location = new System.Drawing.Point(4, -4);
            this.panel3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1312, 106);
            this.panel3.TabIndex = 2;
            // 
            // foldersTableAdapter
            // 
            this.foldersTableAdapter.ClearBeforeFill = true;
            // 
            // folderPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "folderPage";
            this.Text = "folderPage";
            this.Load += new System.EventHandler(this.folderPage_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Folders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foldersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAM_ADataSet_Folders)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_Folders;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox folderIdTxt;
        private System.Windows.Forms.Panel panel3;
        private TEAM_ADataSet_Folders tEAM_ADataSet_Folders;
        private System.Windows.Forms.BindingSource foldersBindingSource;
        private TEAM_ADataSet_FoldersTableAdapters.FoldersTableAdapter foldersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn folderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label folderIdLbl;
        private CustomControls.RJControls.rndButton btnExpand;
        private CustomControls.RJControls.rndButton btnBack;
    }
}