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
    public partial class claimList : Form
    {
        User user;
        WelcomeForm welcomeForm;
        public claimList()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReturnToWelcome_Click(object sender, EventArgs e)
        {
            this.Hide();
            welcomeForm = new WelcomeForm(user);
            welcomeForm.Owner = this;
            welcomeForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
