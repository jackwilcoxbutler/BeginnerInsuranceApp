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
    public partial class CreateClaim : Form
    {
        WelcomeForm welcomeForm;
        public CreateClaim()
        {
            InitializeComponent();
        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {
            DateTime thisDay = DateTime.Today;
            txtDate.ReadOnly = true;
            txtDate.Text = thisDay.ToShortDateString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            welcomeForm = new WelcomeForm();
            welcomeForm.Owner = this;
            welcomeForm.Show();
        }
    }
}
