using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamNateZone
{
    public partial class FMManageFinance : Form
    {
        public FMManageFinance()
        {
            InitializeComponent();
        }

        private void btnMakeEstimate_Click(object sender, EventArgs e)
        {
            if (FmView.SelectedRows.Count == 1)
            {
                Claim temp = new Claim((int)FmView.SelectedRows[0].Cells[0].Value);
                int amt = int.Parse(txtAmt.Text);
                if (temp.estimateAmt(amt))
                {
                    MessageBox.Show("Amount added sucessfully");
                }
            }

        }
        private void FMManageFinance_Load(object sender, EventArgs e)
        {
            //Connection String needs to be fixed
            this.claimsTableAdapter.Fill(this.fMFinanceManageDataSet.Claims);

        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {

            this.Owner.Show();
            Close();
        }
    }
}
