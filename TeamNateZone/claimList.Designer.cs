
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Claim 1");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Claim 2");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Claim 3");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Claim 4");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Claim 5");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Claim 6");
            this.lstClaimList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lstClaimList
            // 
            this.lstClaimList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstClaimList.HideSelection = false;
            this.lstClaimList.HoverSelection = true;
            listViewItem1.ToolTipText = "ID: 1 Date: 1/2/2022";
            listViewItem2.ToolTipText = "ID: 2 Date: 2/2/2022";
            listViewItem3.ToolTipText = "ID: 3 Date: 2/3/2022";
            listViewItem4.ToolTipText = "ID: 4 Date: 2/4/2022";
            listViewItem5.ToolTipText = "ID: 5 Date: 2/5/2022";
            listViewItem6.ToolTipText = "ID: 6 Date: 2/6/2022";
            this.lstClaimList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.lstClaimList.Location = new System.Drawing.Point(12, 12);
            this.lstClaimList.Name = "lstClaimList";
            this.lstClaimList.ShowItemToolTips = true;
            this.lstClaimList.Size = new System.Drawing.Size(743, 426);
            this.lstClaimList.TabIndex = 0;
            this.lstClaimList.TileSize = new System.Drawing.Size(100, 100);
            this.lstClaimList.UseCompatibleStateImageBehavior = false;
            this.lstClaimList.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // claimList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstClaimList);
            this.Name = "claimList";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstClaimList;
    }
}