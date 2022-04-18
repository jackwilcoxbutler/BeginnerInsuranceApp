using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamNateZone
{
    public partial class FMManageFinance : Form
    {
        int newSortColumn;
        ListSortDirection newColumnDirection = ListSortDirection.Ascending;
        User user;
        private User userFM;
        dbHandler db = new dbHandler(Properties.Settings.Default.TEAM_A_ConnectionString);

        public FMManageFinance(User userFM)
        {
            InitializeComponent();
            this.userFM = userFM;
            FmView.DataSource = db.LoadTable(userFM.getUserID());

        }


        private void btnMakeEstimate_Click(object sender, EventArgs e)
        {
            if (FmView.SelectedRows.Count == 1)
            {
                Claim temp = new Claim((int)FmView.SelectedRows[0].Cells[0].Value);
                int outputvalue = 0;
                bool isNumber = false;
                isNumber = int.TryParse(txtAmt.Text, out outputvalue);
                if (isNumber)
                {
                    int amt = int.Parse(txtAmt.Text);

                    if (temp.estimateAmt(amt, temp.claimID, userFM.getUserID()))
                    {
                        MessageBox.Show("Amount added sucessfully");
                        FmView.DataSource = db.LoadTable(userFM.getUserID());
                        return;
                    }
                    txtAmt.Text = "DB Connection Failed Try Again";
                }
                else
                {
                    MessageBox.Show("Please enter an integer value!"+ System.Environment.NewLine + "No commas or special characters.", "Error");
                }
                
            }
            else
            {
                MessageBox.Show("Please select a claim.", "Error");
            }

        }
        private void FMManageFinance_Load(object sender, EventArgs e)
        {
            FmView.DataSource = db.LoadTable(userFM.getUserID());
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {

            this.Owner.Show();
            Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAmt.Text = "";
        }

        private void FmView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (FmView.Columns[e.ColumnIndex].SortMode != DataGridViewColumnSortMode.NotSortable)
            {
                if (e.ColumnIndex == newSortColumn)
                {
                    if (newColumnDirection == ListSortDirection.Ascending)
                        newColumnDirection = ListSortDirection.Descending;
                    else
                        newColumnDirection = ListSortDirection.Ascending;
                }

                newSortColumn = e.ColumnIndex;

                switch (newColumnDirection)
                {
                    case ListSortDirection.Ascending:
                        FmView.Sort(FmView.Columns[newSortColumn], ListSortDirection.Ascending);
                        break;
                    case ListSortDirection.Descending:
                        FmView.Sort(FmView.Columns[newSortColumn], ListSortDirection.Descending);
                        break;
                }
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.claimsTableAdapter.FillBy(this.fMFinanceManageDataSet.Claims);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FmView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (FmView.SelectedRows.Count == 1)
            {
                txtAmt.Text = "Please make claim estimate";
            }
        }

       
    }
}
