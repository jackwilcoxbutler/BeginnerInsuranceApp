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

        public FMManageFinance()
        {
            InitializeComponent();
        }

        private void LoadTable()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString =
                @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
            cn.Open();

            //  SqlDataAdapter da = new SqlDataAdapter("SELECT ClaimID, Username, Status,StartDate, LastUpdate, EstimatedAmount, PaymentStatus, Claim_Type, Claim_Description FROM Claims", cn);
            SqlDataAdapter da = new SqlDataAdapter("SELECT ClaimID, Username, Status,StartDate, LastUpdate, EstimatedAmount, PaymentStatus, Claim_Type, Claim_Description FROM Claims", cn);

            DataTable dtbl = new DataTable();
            da.Fill(dtbl);
            FmView.DataSource = dtbl;
            cn.Close();
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

                    if (temp.estimateAmt(amt, temp.claimID))
                    {
                        MessageBox.Show("Amount added sucessfully");
                        LoadTable();
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
            LoadTable();
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
    }
}
