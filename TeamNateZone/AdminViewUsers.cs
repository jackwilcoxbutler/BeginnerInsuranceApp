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
    public partial class AdminViewUsers : Form
    {
        /*struct clearanceLevel{
            public int CM = 1;
            public int FM = 2;
            public int AD = 3;
        }*/
        public AdminViewUsers()
        {
            InitializeComponent();
        }


        private void ViewUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tEAM_A_UserInfo.SignInInfo' table. You can move, or remove it, as needed.
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString =
                @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
            cn.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM SignInInfo where clearance = 0 or clearance = 1 or clearance = 2 order by DateRegistered desc", cn);
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            cn.Close();
            BindingSource bs = new BindingSource(dtbl, dtbl.TableName);
            bindingNavigator1.BindingSource = bs;

            dataGridView1.Columns["Email"].ReadOnly = true;
            dataGridView1.Columns["Password"].ReadOnly = true;
            dataGridView1.Columns["fName"].ReadOnly = true;
            dataGridView1.Columns["lName"].ReadOnly = true;
            dataGridView1.Columns["street"].ReadOnly = true;
            dataGridView1.Columns["city"].ReadOnly = true;
            dataGridView1.Columns["state"].ReadOnly = true;
            dataGridView1.Columns["zip"].ReadOnly = true;
            dataGridView1.Columns["Username"].ReadOnly = true;

            //This is part of a futur implementatio of payment info
            dataGridView1.Columns["CVV"].ReadOnly = false;
            dataGridView1.Columns["CCExpiration"].ReadOnly = false;

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            RegistrationForm rf = new RegistrationForm(1);//clearanceLevel.CM removed for Demo
            rf.Show();
            this.Close();
        }

        private void btnAddFM_Click(object sender, EventArgs e)
        {
            RegistrationForm rf = new RegistrationForm(2);//clearanceLevel.FM removed for Demo
            rf.Show();
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ViewUsers_Load(sender,e);
            /*
            SqlConnection db = new SqlConnection(@"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True");
            db.Open();
            SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM SignInInfo", db);
            DataTable dtbl = new DataTable();
            data.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            db.Close();
            BindingSource bs = new BindingSource(dtbl, dtbl.TableName);
            bindingNavigator1.BindingSource = bs;
            */
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
                catch(Exception err) // should try to query for last name if first name query returned nothing, thus throwing an InvalidAttemptToReadWhenNoDataIsPresent error
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
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells[10].Value;
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cn.ConnectionString =
                    @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
            cmd.Connection = cn;

            cmd.CommandText = "UPDATE SignInInfo SET clearance=@value WHERE UserID = @uid";
            cmd.Parameters.AddWithValue("@value", (int)dataGridView1.CurrentCell.Value);
            cmd.Parameters.AddWithValue("@uid", id);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show($"You changed {id}'s clearance level to {(int)dataGridView1.CurrentCell.Value}");
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
