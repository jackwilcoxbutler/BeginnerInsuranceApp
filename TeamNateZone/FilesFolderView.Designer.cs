
namespace TeamNateZone
{
    partial class FilesFolderView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.filesPanel = new System.Windows.Forms.Panel();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.helloLbl = new System.Windows.Forms.Label();
            this.userLbl = new System.Windows.Forms.Label();
            this.viewLbl = new System.Windows.Forms.Label();
            this.otherUserLbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDownload = new CustomControls.RJControls.rndButton();
            this.rndValidateBtn = new CustomControls.RJControls.rndButton();
            this.rndTransferBtn = new CustomControls.RJControls.rndButton();
            this.transferComboBox = new System.Windows.Forms.ComboBox();
            this.fileIDTxt = new System.Windows.Forms.TextBox();
            this.fileIDLbl = new System.Windows.Forms.Label();
            this.tEAM_ADataSet3_Files = new TeamNateZone.TEAM_ADataSet3_Files();
            this.filesInFoldersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filesInFoldersTableAdapter = new TeamNateZone.TEAM_ADataSet3_FilesTableAdapters.FilesInFoldersTableAdapter();
            this.filesIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textPanel.SuspendLayout();
            this.filesPanel.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAM_ADataSet3_Files)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesInFoldersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 377);
            this.panel1.TabIndex = 0;
            // 
            // textPanel
            // 
            this.textPanel.BackColor = System.Drawing.Color.YellowGreen;
            this.textPanel.Controls.Add(this.otherUserLbl);
            this.textPanel.Controls.Add(this.viewLbl);
            this.textPanel.Controls.Add(this.userLbl);
            this.textPanel.Controls.Add(this.helloLbl);
            this.textPanel.Controls.Add(this.dataPanel);
            this.textPanel.Controls.Add(this.panel3);
            this.textPanel.Controls.Add(this.panel1);
            this.textPanel.Location = new System.Drawing.Point(0, 1);
            this.textPanel.Name = "textPanel";
            this.textPanel.Size = new System.Drawing.Size(799, 58);
            this.textPanel.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(599, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 383);
            this.panel3.TabIndex = 2;
            // 
            // dataPanel
            // 
            this.dataPanel.Location = new System.Drawing.Point(3, 60);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(663, 383);
            this.dataPanel.TabIndex = 2;
            // 
            // filesPanel
            // 
            this.filesPanel.Controls.Add(this.dataGridView1);
            this.filesPanel.Location = new System.Drawing.Point(2, 60);
            this.filesPanel.Name = "filesPanel";
            this.filesPanel.Size = new System.Drawing.Size(597, 388);
            this.filesPanel.TabIndex = 2;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonsPanel.Controls.Add(this.fileIDLbl);
            this.buttonsPanel.Controls.Add(this.fileIDTxt);
            this.buttonsPanel.Controls.Add(this.transferComboBox);
            this.buttonsPanel.Controls.Add(this.rndTransferBtn);
            this.buttonsPanel.Controls.Add(this.rndValidateBtn);
            this.buttonsPanel.Controls.Add(this.btnDownload);
            this.buttonsPanel.Location = new System.Drawing.Point(596, 59);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(203, 392);
            this.buttonsPanel.TabIndex = 3;
            // 
            // helloLbl
            // 
            this.helloLbl.AutoSize = true;
            this.helloLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloLbl.Location = new System.Drawing.Point(94, 16);
            this.helloLbl.Name = "helloLbl";
            this.helloLbl.Size = new System.Drawing.Size(64, 24);
            this.helloLbl.TabIndex = 3;
            this.helloLbl.Text = "Hello, ";
            // 
            // userLbl
            // 
            this.userLbl.AutoSize = true;
            this.userLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLbl.Location = new System.Drawing.Point(164, 16);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(60, 24);
            this.userLbl.TabIndex = 4;
            this.userLbl.Text = "label2";
            // 
            // viewLbl
            // 
            this.viewLbl.AutoSize = true;
            this.viewLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewLbl.Location = new System.Drawing.Point(341, 16);
            this.viewLbl.Name = "viewLbl";
            this.viewLbl.Size = new System.Drawing.Size(150, 24);
            this.viewLbl.TabIndex = 5;
            this.viewLbl.Text = "You are viewing:";
            // 
            // otherUserLbl
            // 
            this.otherUserLbl.AutoSize = true;
            this.otherUserLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherUserLbl.Location = new System.Drawing.Point(497, 16);
            this.otherUserLbl.Name = "otherUserLbl";
            this.otherUserLbl.Size = new System.Drawing.Size(60, 24);
            this.otherUserLbl.TabIndex = 6;
            this.otherUserLbl.Text = "label4";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filesIDDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.fileNameDataGridViewTextBoxColumn,
            this.fileDescriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.filesInFoldersBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(597, 388);
            this.dataGridView1.TabIndex = 0;
//            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.White;
            this.btnDownload.BackgroundColor = System.Drawing.Color.White;
            this.btnDownload.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDownload.BorderRadius = 15;
            this.btnDownload.BorderSize = 0;
            this.btnDownload.FlatAppearance.BorderSize = 0;
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.ForeColor = System.Drawing.Color.YellowGreen;
            this.btnDownload.Location = new System.Drawing.Point(48, 135);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(2);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(109, 32);
            this.btnDownload.TabIndex = 36;
            this.btnDownload.Text = "Download";
            this.btnDownload.TextColor = System.Drawing.Color.YellowGreen;
            this.btnDownload.UseVisualStyleBackColor = false;
            // 
            // rndValidateBtn
            // 
            this.rndValidateBtn.BackColor = System.Drawing.Color.White;
            this.rndValidateBtn.BackgroundColor = System.Drawing.Color.White;
            this.rndValidateBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rndValidateBtn.BorderRadius = 15;
            this.rndValidateBtn.BorderSize = 0;
            this.rndValidateBtn.FlatAppearance.BorderSize = 0;
            this.rndValidateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rndValidateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rndValidateBtn.ForeColor = System.Drawing.Color.YellowGreen;
            this.rndValidateBtn.Location = new System.Drawing.Point(49, 203);
            this.rndValidateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.rndValidateBtn.Name = "rndValidateBtn";
            this.rndValidateBtn.Size = new System.Drawing.Size(109, 32);
            this.rndValidateBtn.TabIndex = 37;
            this.rndValidateBtn.Text = "Validate";
            this.rndValidateBtn.TextColor = System.Drawing.Color.YellowGreen;
            this.rndValidateBtn.UseVisualStyleBackColor = false;
            // 
            // rndTransferBtn
            // 
            this.rndTransferBtn.BackColor = System.Drawing.Color.White;
            this.rndTransferBtn.BackgroundColor = System.Drawing.Color.White;
            this.rndTransferBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rndTransferBtn.BorderRadius = 15;
            this.rndTransferBtn.BorderSize = 0;
            this.rndTransferBtn.FlatAppearance.BorderSize = 0;
            this.rndTransferBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rndTransferBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rndTransferBtn.ForeColor = System.Drawing.Color.YellowGreen;
            this.rndTransferBtn.Location = new System.Drawing.Point(48, 291);
            this.rndTransferBtn.Margin = new System.Windows.Forms.Padding(2);
            this.rndTransferBtn.Name = "rndTransferBtn";
            this.rndTransferBtn.Size = new System.Drawing.Size(109, 32);
            this.rndTransferBtn.TabIndex = 38;
            this.rndTransferBtn.Text = "Transfer";
            this.rndTransferBtn.TextColor = System.Drawing.Color.YellowGreen;
            this.rndTransferBtn.UseVisualStyleBackColor = false;
            // 
            // transferComboBox
            // 
            this.transferComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.transferComboBox.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferComboBox.FormattingEnabled = true;
            this.transferComboBox.Items.AddRange(new object[] {
            "CM",
            "FM",
            "CLIENT"});
            this.transferComboBox.Location = new System.Drawing.Point(37, 256);
            this.transferComboBox.Name = "transferComboBox";
            this.transferComboBox.Size = new System.Drawing.Size(130, 23);
            this.transferComboBox.TabIndex = 39;
            // 
            // fileIDTxt
            // 
            this.fileIDTxt.BackColor = System.Drawing.SystemColors.MenuBar;
            this.fileIDTxt.Location = new System.Drawing.Point(39, 95);
            this.fileIDTxt.Name = "fileIDTxt";
            this.fileIDTxt.Size = new System.Drawing.Size(130, 20);
            this.fileIDTxt.TabIndex = 40;
            // 
            // fileIDLbl
            // 
            this.fileIDLbl.AutoSize = true;
            this.fileIDLbl.Location = new System.Drawing.Point(40, 74);
            this.fileIDLbl.Name = "fileIDLbl";
            this.fileIDLbl.Size = new System.Drawing.Size(37, 13);
            this.fileIDLbl.TabIndex = 41;
            this.fileIDLbl.Text = "FileID:";
            // 
            // tEAM_ADataSet3_Files
            // 
            this.tEAM_ADataSet3_Files.DataSetName = "TEAM_ADataSet3_Files";
            this.tEAM_ADataSet3_Files.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filesInFoldersBindingSource
            // 
            this.filesInFoldersBindingSource.DataMember = "FilesInFolders";
            this.filesInFoldersBindingSource.DataSource = this.tEAM_ADataSet3_Files;
            // 
            // filesInFoldersTableAdapter
            // 
            this.filesInFoldersTableAdapter.ClearBeforeFill = true;
            // 
            // filesIDDataGridViewTextBoxColumn
            // 
            this.filesIDDataGridViewTextBoxColumn.DataPropertyName = "filesID";
            this.filesIDDataGridViewTextBoxColumn.HeaderText = "filesID";
            this.filesIDDataGridViewTextBoxColumn.Name = "filesIDDataGridViewTextBoxColumn";
            this.filesIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            // 
            // fileNameDataGridViewTextBoxColumn
            // 
            this.fileNameDataGridViewTextBoxColumn.DataPropertyName = "FileName";
            this.fileNameDataGridViewTextBoxColumn.HeaderText = "FileName";
            this.fileNameDataGridViewTextBoxColumn.Name = "fileNameDataGridViewTextBoxColumn";
            // 
            // fileDescriptionDataGridViewTextBoxColumn
            // 
            this.fileDescriptionDataGridViewTextBoxColumn.DataPropertyName = "FileDescription";
            this.fileDescriptionDataGridViewTextBoxColumn.HeaderText = "FileDescription";
            this.fileDescriptionDataGridViewTextBoxColumn.Name = "fileDescriptionDataGridViewTextBoxColumn";
            // 
            // FilesFolderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonsPanel);
            this.Controls.Add(this.filesPanel);
            this.Controls.Add(this.textPanel);
            this.Name = "FilesFolderView";
            this.Text = "FilesFolderView";
            this.Load += new System.EventHandler(this.FilesFolderView_Load);
            this.textPanel.ResumeLayout(false);
            this.textPanel.PerformLayout();
            this.filesPanel.ResumeLayout(false);
            this.buttonsPanel.ResumeLayout(false);
            this.buttonsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEAM_ADataSet3_Files)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesInFoldersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel textPanel;
        private System.Windows.Forms.Label otherUserLbl;
        private System.Windows.Forms.Label viewLbl;
        private System.Windows.Forms.Label userLbl;
        private System.Windows.Forms.Label helloLbl;
        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel filesPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel buttonsPanel;
        private CustomControls.RJControls.rndButton rndTransferBtn;
        private CustomControls.RJControls.rndButton rndValidateBtn;
        private CustomControls.RJControls.rndButton btnDownload;
        private System.Windows.Forms.Label fileIDLbl;
        private System.Windows.Forms.TextBox fileIDTxt;
        private System.Windows.Forms.ComboBox transferComboBox;
        private TEAM_ADataSet3_Files tEAM_ADataSet3_Files;
        private System.Windows.Forms.BindingSource filesInFoldersBindingSource;
        private TEAM_ADataSet3_FilesTableAdapters.FilesInFoldersTableAdapter filesInFoldersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn filesIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileDescriptionDataGridViewTextBoxColumn;
    }
}