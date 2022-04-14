using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Security;

namespace TeamNateZone
{
    public partial class NewMessage : Form
    {
        User user;
        MessageForm message;
        dbHandler db;
        Stream fileStream;
        byte[] Databytes;
        string extention;
        string FileName;
        string path;

        public NewMessage(User user, string to, string subreply, string Sentmessage)
        {
            InitializeComponent();
            this.user = user;
            txtReciever.Text = to;
            txtSubject.Text = subreply;
            txtMessage.Text = Sentmessage;
            this.db = new dbHandler(@"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True");
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

            int i = 0;
            string recievever = txtReciever.Text;
            string[] subs = recievever.Split(' ', '\t');
            if (fileStream != null)
            {
                using (BinaryReader br = new BinaryReader(fileStream))
                {
                    Databytes = br.ReadBytes((Int32)fileStream.Length);
                }
            }

            try
            {
                if (txtReciever.Text == "" || txtSubject.Text == "" || txtMessage.Text == "")
                {
                    string message = "ERROR : Required Field is blank";
                    string title = "Message send Failed";
                    DialogResult result = MessageBox.Show(message, title);
                }

                int numsubs = 0; //loop help
                int numCorrectUN = 0; //loop help
                foreach (var sub in subs)
                {
                    string recieverStore = sub;
                    string recieverHelp = db.getExistingReceiver(sub);
                    bool resultbool = recieverStore.Equals(recieverHelp.Trim()); //We need to trim the string
                    numsubs++;
                    if (resultbool == true)
                    {
                        numCorrectUN++;
                    }
                }

                if (numCorrectUN == numsubs)
                {
                    foreach (var sub in subs)
                    {
                        string recieverStore = sub;
                        string recieverHelp = db.getExistingReceiver(sub);
                        bool resultbool = recieverStore.Equals(recieverHelp.Trim()); //We need to trim the string

                        if (resultbool == true)
                        {
                            DateTime date;
                            date = DateTime.Now;
                            db.send_message(user.getUsername(), sub, txtMessage.Text, date, txtSubject.Text, Databytes, extention);
                        }
                    }
                    string Message = "Message Sent Succsefully!";
                    string Title = "Message Sent";
                    DialogResult Result = MessageBox.Show(Message, Title);
                    txtReciever.Clear();
                    txtMessage.Clear();
                    txtSubject.Clear();
                }
                else
                {
                    string message = "ERROR : System one or more Users Does Not Exist!. Click retry to reenter User's Name.";
                    string title = "Selected User Failed";
                    MessageBoxButtons buttons = MessageBoxButtons.RetryCancel;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Cancel)
                    {
                        Application.Exit();
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Occurred");
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fileStream = openFileDialog1.OpenFile();
                    path = openFileDialog1.FileName;
                    txtUpload.Text = path;
                    extention = path.Substring(path.LastIndexOf('.'));
                    FileName = path.Substring(0, path.IndexOf('.'));
                    extention = path.Substring(path.LastIndexOf('.'));
                    MessageBox.Show("Uploaded File!", "Success");
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }
    }
}