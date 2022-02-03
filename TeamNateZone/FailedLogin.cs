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
    public partial class FailedLogin : Form
    {
        LoginForm login;
        public FailedLogin()
        {
            InitializeComponent();
        }

        private void btnRetry_Click(object sender, EventArgs e)
        {
            login = new LoginForm();
            this.Hide();
            login.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
