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
public partial class AdminConsole : Form
    {
        AdminWelcomeForm form;
        public AdminConsole()
        {
            InitializeComponent();
        }

        private void AdminConsole_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tEAM_A_UserInfo.SignInInfo' table. You can move, or remove it, as needed.
            /* Commented out for demo purposes
             * this.signInInfoTableAdapter.Fill(this.tEAM_A_UserInfo.SignInInfo);
            */
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btnRegisterCM_Click(object sender, EventArgs e)
        {
            RegistrationForm rf = new RegistrationForm(1);
            rf.Owner = this;
            rf.Show();
        }

        private void btnRegisterFM_Click(object sender, EventArgs e)
        {
            RegistrationForm rf = new RegistrationForm(2);
            rf.Owner = this;
            rf.Show();
        }
    }
}
