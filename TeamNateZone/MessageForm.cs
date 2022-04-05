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
        public MessageForm(User user)
        {
            InitializeComponent();
            this.user = user;
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
            
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            string account = user.getUsername();

            cn.ConnectionString =
                @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
            cmd.Connection = cn;
            cn.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM message WHERE receiver = @receiver ORDER BY date DESC", cn);
            da.SelectCommand.Parameters.AddWithValue("receiver", account);
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            cn.Close();
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
            //string date1 = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[5].FormattedValue.ToString();
            //DateTime date = Convert.ToDateTime(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[5].FormattedValue.ToString());

            //Console.WriteLine(date1);
            //Console.WriteLine(date);
            //date1.Trim();
            //Console.WriteLine(date1);

            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            cn.ConnectionString =
                     @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
            cmd.Connection = cn;
            //cmd.CommandText = "UPDATE message SET readorunread = @re WHERE date = @date AND receiver = @r";
            cmd.CommandText = "UPDATE message SET readorunread = ' ' WHERE subject = @sub AND message = @mess AND receiver = @r";

            cmd.Parameters.AddWithValue("@r", from);
            //cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@re", " ");
            cmd.Parameters.AddWithValue("@sub", subject);
            cmd.Parameters.AddWithValue("@mess", message);

            cn.Open();
            dr = cmd.ExecuteReader();
            dr.Read();

            View = new ViewMessageForm(user, subject, message, from);
            View.Owner = this;
            View.Show();
            this.Hide();
        }

        private void txtRefresh_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            string account = user.getUsername();

            cn.ConnectionString =
                @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
            cmd.Connection = cn;
            cn.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM message WHERE receiver = @receiver ORDER BY date DESC", cn);
            da.SelectCommand.Parameters.AddWithValue("receiver", account);
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            cn.Close();
        }

        private void btnSent_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            string account = user.getUsername();

            cn.ConnectionString =
                @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
            cmd.Connection = cn;
            cn.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT sender, receiver, message, date, subject FROM message WHERE sender = @sender ORDER BY date DESC", cn);
            da.SelectCommand.Parameters.AddWithValue("sender", account);
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            cn.Close();
        }

        private void btnInbox_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            string account = user.getUsername();

            cn.ConnectionString =
                @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
            cmd.Connection = cn;
            cn.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM message WHERE receiver = @receiver ORDER BY date DESC", cn);
            da.SelectCommand.Parameters.AddWithValue("receiver", account);
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            cn.Close();
        }
    }
}
