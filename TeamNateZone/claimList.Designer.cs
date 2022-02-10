
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
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("Claim 1");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("Claim 2");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("Claim 3");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("Claim 4");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("Claim 5");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("Claim 6");
            this.lstClaimList = new System.Windows.Forms.ListView();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReturnToWelcome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstClaimList
            // 
            this.lstClaimList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstClaimList.HideSelection = false;
            this.lstClaimList.HoverSelection = true;
            listViewItem7.ToolTipText = "1/2/2022";
            listViewItem8.ToolTipText = "2/2/2022";
            listViewItem9.ToolTipText = "2/3/2022";
            listViewItem10.ToolTipText = "2/4/2022";
            listViewItem11.ToolTipText = "2/5/2022";
            listViewItem12.ToolTipText = "2/6/2022";
            this.lstClaimList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12});
            this.lstClaimList.Location = new System.Drawing.Point(24, 23);
            this.lstClaimList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lstClaimList.Name = "lstClaimList";
            this.lstClaimList.ShowItemToolTips = true;
            this.lstClaimList.Size = new System.Drawing.Size(1482, 816);
            this.lstClaimList.TabIndex = 0;
            this.lstClaimList.TileSize = new System.Drawing.Size(100, 100);
            this.lstClaimList.UseCompatibleStateImageBehavior = false;
            this.lstClaimList.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1231, 738);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(231, 65);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReturnToWelcome
            // 
            this.btnReturnToWelcome.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnToWelcome.Location = new System.Drawing.Point(965, 738);
            this.btnReturnToWelcome.Name = "btnReturnToWelcome";
            this.btnReturnToWelcome.Size = new System.Drawing.Size(231, 65);
            this.btnReturnToWelcome.TabIndex = 2;
            this.btnReturnToWelcome.Text = "Return";
            this.btnReturnToWelcome.UseVisualStyleBackColor = true;
            this.btnReturnToWelcome.Click += new System.EventHandler(this.btnReturnToWelcome_Click);
            // 
            // claimList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.btnReturnToWelcome);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lstClaimList);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "claimList";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstClaimList;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReturnToWelcome;
    }
}