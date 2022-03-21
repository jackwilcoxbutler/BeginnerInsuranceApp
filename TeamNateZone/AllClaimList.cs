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
    public partial class AllClaimList : Form
    {
        User user;
        CMWelcomeForm CMwelcomeForm;
        public AllClaimList(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btnReturnToWelcome_Click(object sender, EventArgs e)
        {
            this.Hide();
            CMwelcomeForm = new CMWelcomeForm(user);
            CMwelcomeForm.Owner = this;
            CMwelcomeForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void claimList_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            int account = user.getUserID();

            cn.ConnectionString =
                @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
            cmd.Connection = cn;
            cn.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Claims", cn);
            da.SelectCommand.Parameters.AddWithValue("userid", account);
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            cn.Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            cn.ConnectionString =
                @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
            cmd.Connection = cn;
            cmd.CommandText = "SELECT content FROM ClaimMedia WHERE UID=@uid";
            cmd.Parameters.AddWithValue("@uid", user.getUserID());
            cn.Open();
            dr = cmd.ExecuteReader();
            dr.Read();
//            dr.Read(); // advance to second image (panda)
            Image img = System.Drawing.Bitmap.FromStream(dr.GetStream(0));
            testPictureBox.Image = img;
            testPictureBox.Visible = true;
        }
    }
}
