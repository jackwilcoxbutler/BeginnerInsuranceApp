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
    public partial class FMCMViewUsers : Form
    {
        User user;
        public FMCMViewUsers(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void CMViewUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tEAM_A_UserInfo.SignInInfo' table. You can move, or remove it, as needed.
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cn.ConnectionString =
                @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
            cmd.Connection = cn;
            cn.Open();

            SqlDataAdapter da;

            if (user.getRole() == "Claims Manager")
            {
                // might wnat to change to only count the ones with a active status
                da = new SqlDataAdapter("SELECT SignInInfo.Email, SignInInfo.Username, SignInInfo.fName FirstName, SignInInfo.lName LastName, SignInInfo.street AS Street, SignInInfo.city AS City, SignInInfo.state AS State, SignInInfo.zip AS ZipCode, Cl.Active_Claims FROM SignInInfo INNER JOIN (SELECT UserID, count(*) as Active_Claims FROM Claims GROUP BY UserID) AS Cl ON SignInInfo.UserID=Cl.UserID WHERE clearance = 0", cn);
                DataTable dtbl = new DataTable();
                da.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
                cn.Close();
                BindingSource bs = new BindingSource(dtbl, dtbl.TableName);
                bindingNavigator1.BindingSource = bs;
            }
            else if (user.getRole() == "Finance Manager")
            {
                // might wnat to change to only count the ones with a active status
                da = new SqlDataAdapter("SELECT SignInInfo.Email, SignInInfo.Username, SignInInfo.fName FirstName, SignInInfo.lName LastName, SignInInfo.street AS Street, SignInInfo.city AS City, SignInInfo.state AS State, SignInInfo.zip AS ZipCode, SignInInfo.CreditNumber AS CardNumber, SignInInfo.CVV, SignInInfo.CCExpiration AS CardExperation, Cl.Active_Claims FROM SignInInfo INNER JOIN (SELECT UserID, count(*) as Active_Claims FROM Claims GROUP BY UserID) AS Cl ON SignInInfo.UserID=Cl.UserID WHERE clearance = 0", cn);
                DataTable dtbl = new DataTable();
                da.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
                cn.Close();
                BindingSource bs = new BindingSource(dtbl, dtbl.TableName);
                bindingNavigator1.BindingSource = bs;
            }
            else
            {
                MessageBox.Show("Error Occurred");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cn.ConnectionString =
                @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
            cmd.Connection = cn;
            cn.Open();

            SqlDataAdapter da;

            if (user.getRole() == "Claims Manager")
            {
                da = new SqlDataAdapter("SELECT Email, Username, fName FirstName, lName LastName, street AS Street, city AS City, state AS State, zip AS ZipCode FROM SignInInfo WHERE clearance = 0", cn);
                DataTable dtbl = new DataTable();
                da.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
                cn.Close();
                BindingSource bs = new BindingSource(dtbl, dtbl.TableName);
                bindingNavigator1.BindingSource = bs;
            }
            else if (user.getRole() == "Finance Manager")
            {
                da = new SqlDataAdapter("SELECT Email, Username, fName FirstName, lName LastName, street AS Street, city AS City, state AS State, zip AS ZipCode, CreditNumber AS CardNumber, CVV, CCExpiration AS CardExperation FROM SignInInfo WHERE clearance = 0", cn);
                DataTable dtbl = new DataTable();
                da.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
                cn.Close();
                BindingSource bs = new BindingSource(dtbl, dtbl.TableName);
                bindingNavigator1.BindingSource = bs;
            }
            else
            {
                MessageBox.Show("Error Occurred");
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                try
                {
                    SqlConnection cn = new SqlConnection();
                    SqlCommand cmd = new SqlCommand();
                    cn.ConnectionString =
                        @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
                    cmd.Connection = cn;
                    cn.Open();

                    SqlDataAdapter da;

                    if (user.getRole() == "Claims Manager")
                    {
                        da = new SqlDataAdapter("SELECT Email, Username, fName FirstName, lName LastName, street AS Street, city AS City, state AS State, zip AS ZipCode FROM SignInInfo WHERE clearance = 0 And fName=@name", cn);
                        da.SelectCommand.Parameters.AddWithValue("@name", txtSearch.Text);
                        DataTable dtbl = new DataTable();
                        da.Fill(dtbl);
                        dataGridView1.DataSource = dtbl;
                        cn.Close();
                        BindingSource bs = new BindingSource(dtbl, dtbl.TableName);
                        bindingNavigator1.BindingSource = bs;
                    }
                    else if (user.getRole() == "Finance Manager")
                    {
                        da = new SqlDataAdapter("SELECT Email, Username, fName FirstName, lName LastName, street AS Street, city AS City, state AS State, zip AS ZipCode, CreditNumber AS CardNumber, CVV, CCExpiration AS CardExperation FROM SignInInfo WHERE clearance = 0  And fName=@name", cn);
                        da.SelectCommand.Parameters.AddWithValue("@name", txtSearch.Text);
                        DataTable dtbl = new DataTable();
                        da.Fill(dtbl);
                        dataGridView1.DataSource = dtbl;
                        cn.Close();
                        BindingSource bs = new BindingSource(dtbl, dtbl.TableName);
                        bindingNavigator1.BindingSource = bs;
                    }
                    else
                    {
                        MessageBox.Show("Error Occurred");
                    }
                }
                catch(Exception err)
                {
                    SqlConnection cn = new SqlConnection();
                    SqlCommand cmd = new SqlCommand();
                    cn.ConnectionString =
                        @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
                    cmd.Connection = cn;
                    cn.Open();

                    SqlDataAdapter da;

                    if (user.getRole() == "Claims Manager")
                    {
                        da = new SqlDataAdapter("SELECT Email, Username, fName FirstName, lName LastName, street AS Street, city AS City, state AS State, zip AS ZipCode FROM SignInInfo WHERE clearance = 0 AND ", cn);
                        DataTable dtbl = new DataTable();
                        da.Fill(dtbl);
                        dataGridView1.DataSource = dtbl;
                        cn.Close();
                        BindingSource bs = new BindingSource(dtbl, dtbl.TableName);
                        bindingNavigator1.BindingSource = bs;
                    }
                    else if (user.getRole() == "Finance Manager")
                    {
                        da = new SqlDataAdapter("SELECT Email, Username, fName FirstName, lName LastName, street AS Street, city AS City, state AS State, zip AS ZipCode, CreditNumber AS CardNumber, CVV, CCExpiration AS CardExperation FROM SignInInfo WHERE clearance = 0", cn);
                        DataTable dtbl = new DataTable();
                        da.Fill(dtbl);
                        dataGridView1.DataSource = dtbl;
                        cn.Close();
                        BindingSource bs = new BindingSource(dtbl, dtbl.TableName);
                        bindingNavigator1.BindingSource = bs;
                    }
                    else
                    {
                        MessageBox.Show("Error Occurred");
                    }
                }
            }
        }

    }
}
