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
            Newmess = new NewMessage(user, txtFrom.Text, Subreply);
            Newmess.Owner = this;
            Newmess.Show();
            this.Hide();
        }
    }
}
