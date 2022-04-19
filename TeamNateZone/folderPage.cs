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
    public partial class folderPage : Form
    {
        User user;
        ClientWelcomeForm welcomeForm;
        CMWelcomeForm cmwelcomeForm;
        FMWelcomeForm fmwelcomeForm;
        AdminWelcomeForm AdminwelcomeForm;
        dbHandler db;
        public folderPage(User user)
        {
            InitializeComponent();
            this.user = user;
            this.db = new dbHandler(@"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True");
        }

        private void folderPage_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True");
            SqlDataAdapter da;
            cn.Open();
            if (user.getClearance() == 0)
            {
                da = new SqlDataAdapter("SELECT * FROM Folders WHERE UserID = @userid", cn);
                da.SelectCommand.Parameters.AddWithValue("userid", user.getUserID());
            }
            else
            {
                da = new SqlDataAdapter("SELECT * FROM Folders", cn);

            }
            
            DataTable dtbl = new DataTable();


            da.Fill(dtbl);

            dataGridView_Folders.DataSource = dtbl;


            cn.Close();

        }

        private void btnExpand_Click(object sender, EventArgs e)
        {

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
    }
}
