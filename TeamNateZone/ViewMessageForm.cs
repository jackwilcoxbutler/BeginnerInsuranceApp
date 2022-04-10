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
    public partial class ViewMessageForm : Form
    {
        User user;
        MessageForm message;
        public ViewMessageForm(User user, string subject, string message, string from)
        {
            InitializeComponent();
            this.user = user;
            txtFrom.Text = from;
            txtMessage.Text = message;
            txtSubject.Text = subject;
            string blank = "  ";

            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            cn.ConnectionString =
                     @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
            cmd.Connection = cn;
            cmd.CommandText = "UPDATE message SET readorunread = @blank WHERE subject = @sub AND message = @mess AND receiver = @reciever AND sender = @sender";

            cmd.Parameters.AddWithValue("@sub", subject);
            cmd.Parameters.AddWithValue("@mess", message);
            cmd.Parameters.AddWithValue("@Sender", from);
            cmd.Parameters.AddWithValue("@reciever", user.getUsername());
            cmd.Parameters.AddWithValue("@blank", blank);

            cn.Open();
            dr = cmd.ExecuteReader();
            dr.Read();

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            message = new MessageForm(user);
            message.Owner = this;
            message.Show();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            NewMessage Newmess;
            string Subreply = "RE: " + txtSubject.Text;
            Newmess = new NewMessage(user, txtFrom.Text, Subreply, null);
            Newmess.Owner = this;
            Newmess.Show();
            this.Hide();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            NewMessage Newmess;
            string Subreply = "Fw: " + txtSubject.Text;
            string Sentmessage = "From: " + txtFrom.Text +" To: " + user.getUsername() + System.Environment.NewLine + txtMessage.Text;
            Newmess = new NewMessage(user, null, Subreply, Sentmessage);
            Newmess.Owner = this;
            Newmess.Show();
            this.Hide();
        }
    }
}
