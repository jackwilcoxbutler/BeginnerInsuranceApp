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

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            RegistrationForm rf = new RegistrationForm(1);
            rf.Show();
            this.Close();
        }

        private void btnAddFM_Click(object sender, EventArgs e)
        {
            RegistrationForm rf = new RegistrationForm(2);
            rf.Show();
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SqlConnection db = new SqlConnection(@"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True");
            db.Open();
            SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM SignInInfo", db);
            DataTable dtbl = new DataTable();
            data.Fill(dtbl);
            db.Close();
            BindingSource bs = new BindingSource(dtbl, dtbl.TableName);
            bindingNavigator1.BindingSource = bs;
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                try
                {
                    SqlConnection cn = new SqlConnection(@"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True");
                    cn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM SignInInfo WHERE fName=@name", cn);
                    da.SelectCommand.Parameters.AddWithValue("@name", txtSearch.Text);
                    DataTable dtbl = new DataTable();
                    da.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;
                    cn.Close();
                    BindingSource bs = new BindingSource(dtbl, dtbl.TableName);
                    bindingNavigator1.BindingSource = bs;
                }
                catch(Exception err)
                {
                    SqlConnection cn = new SqlConnection(@"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True");
                    cn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM SignInInfo WHERE lName = @name", cn);
                    da.SelectCommand.Parameters.AddWithValue("@name", txtSearch.Text);
                    DataTable dtbl = new DataTable();
                    da.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;
                    cn.Close();
                    BindingSource bs = new BindingSource(dtbl, dtbl.TableName);
                    bindingNavigator1.BindingSource = bs;
                }
            }
        }
    }
}
