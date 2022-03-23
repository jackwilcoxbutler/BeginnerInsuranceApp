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

namespace TeamNateZone
{
    public partial class NewMessage : Form
    {
        User user;
        MessageForm message;
        
        public NewMessage(User user)
        {
            InitializeComponent();
            this.user = user;
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

        private string getAlreadyDeclaredUsername(string userName)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            try
            {
                cn.ConnectionString =
                    @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
                cmd.Connection = cn;

                cmd.CommandText = "SELECT Username FROM SignInInfo WHERE Username = @username";

                cmd.Parameters.AddWithValue("@username", userName);

                cn.Open();

                dr = cmd.ExecuteReader();

                dr.Read();

                try
                {
                    return dr.GetString(0);
                }
                catch (Exception e)
                {

                    return "";
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Occurred");
                return null;
            }
            finally
            {
                cn.Close();
            }
        }

        private void storeMessage(string sender, string reveiver, string message, string date, string subject)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            
            try
            {
                cn.ConnectionString =
                    @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
                cmd.Connection = cn;

                cmd.CommandText = "INSERT INTO message(sender, reveiver, message, date, subject) VALUES (@s, @r, @mess, @date, @sub);";
                cmd.Parameters.AddWithValue("@s", sender);
                cmd.Parameters.AddWithValue("@r", reveiver);
                cmd.Parameters.AddWithValue("@mess", message);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@sUB", subject);
                
                cn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Occurred");
            }
            finally
            {
                cn.Close();
            }
        }


        private void btnSend_Click(object sender, EventArgs e)
        {
            Console.WriteLine(txtReciever.Text);
            Console.WriteLine(getAlreadyDeclaredUsername(txtReciever.Text));
            try
            {
                if (txtReciever.Text == "" || txtSubject.Text == "")
                {
                    string message = "ERROR : Required Field is blank";
                    string title = "Message send Failed";
                    MessageBoxButtons buttons = MessageBoxButtons.RetryCancel;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Cancel)
                    {
                        // change to return to message screen
                        Application.Exit();
                    }
                    else
                    {
                     
                    }
                }
                // the logic is broken here im not sure how to fix it 
                else if(txtReciever.Text != getAlreadyDeclaredUsername(txtReciever.Text))
                {
                   string date;
                   date = DateTime.Now.ToString("M/d/yyyy");
                   storeMessage(user.getUsername(), txtReciever.Text, txtMessage.Text, date , txtMessage.Text);
                }
                else
                {
                    string message = "ERROR : User not Found.";
                    string title = "Message send Failed";
                    MessageBoxButtons buttons = MessageBoxButtons.RetryCancel;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Cancel)
                    {
                        // change to return to message screen
                        Application.Exit();
                    }
                    else
                    {
                        txtReciever.Clear();
                    }
                }
                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Occurred");
            }

        }
    }
}