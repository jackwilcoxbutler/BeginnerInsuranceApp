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
    public partial class MessageForm : Form
    {
        User user;
        ClientWelcomeForm welcomeForm;
        CMWelcomeForm cmwelcomeForm;
        FMWelcomeForm fmwelcomeForm;
        NewMessage Newmess;
        ViewMessageForm View;
        AdminWelcomeForm AdminwelcomeForm;
        dbHandler db;

        public MessageForm(User user)
        {
            InitializeComponent();
            this.user = user;
            this.db = new dbHandler(@"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True");
            dataGridView1.Columns[5].DefaultCellStyle.Format = "M/d/yyyy h:mm:ss tt";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (user.getRole() == "Client")
            {
                welcomeForm = new ClientWelcomeForm(user);
                welcomeForm.Owner = this;
                welcomeForm.Show();
            }
            else if (user.getRole() == "Claims Manager")
            {
                cmwelcomeForm = new CMWelcomeForm(user);
                cmwelcomeForm.Owner = this;
                cmwelcomeForm.Show();
            }
            else if (user.getRole() == "Finance Manager")
            {
                fmwelcomeForm = new FMWelcomeForm(user);
                fmwelcomeForm.Owner = this;
                fmwelcomeForm.Show();
            }
            else if (user.getRole() == "Admin")
            {
                AdminwelcomeForm = new AdminWelcomeForm(user);
                AdminwelcomeForm.Owner = this;
                AdminwelcomeForm.Show();
            }
            else
            {
                MessageBox.Show("Error Occurred");
            }
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }

        private void MessageForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.get_inbox(user);
        }

        private void btnNewMessage_Click(object sender, EventArgs e)
        {
            Newmess = new NewMessage(user, null, null, null) ;
            Newmess.Owner = this;
            Newmess.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //this will open another form with the full message display
            string subject = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].FormattedValue.ToString();
            string message = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].FormattedValue.ToString();
            string from = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].FormattedValue.ToString();
           
            View = new ViewMessageForm(user, subject, message, from);
            View.Owner = this;
            View.Show();
            this.Hide();
        }

        private void txtRefresh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.get_inbox(user);
        }

        private void btnSent_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.get_outBox(user);
            btnRefresh.Visible = false;
        }

        private void btnInbox_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.get_inbox(user);
             btnRefresh.Visible = true;
        }
    }
}