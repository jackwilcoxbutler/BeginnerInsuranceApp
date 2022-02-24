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
    public partial class ViewUsers : Form
    {
        public ViewUsers()
        {
            InitializeComponent();
        }

        private void ViewUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tEAM_A_UserInfo.SignInInfo' table. You can move, or remove it, as needed.
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cn.ConnectionString =
                @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
            cmd.Connection = cn;
            cn.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM SignInInfo", cn);
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            cn.Close();
            BindingSource bs = new BindingSource(dtbl, dtbl.TableName);
            bindingNavigator1.BindingSource = bs;

        }
    }
}
