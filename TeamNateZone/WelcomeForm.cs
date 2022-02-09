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
    public partial class WelcomeForm : Form
    {
        claimList listClaims;
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void welcomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnListClaims_Click(object sender, EventArgs e)
        {
            this.Hide();
            listClaims = new claimList();
            listClaims.Owner = this;
            listClaims.Show();
        }
    }
}
