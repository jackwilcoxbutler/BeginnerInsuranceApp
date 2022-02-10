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
    public partial class ManageAccount : Form
    {
        User user;
        WelcomeForm welcomeForm;
        public ManageAccount()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            welcomeForm = new WelcomeForm(user);
            welcomeForm.Owner = this;
            welcomeForm.Show();
        }
    }
}
