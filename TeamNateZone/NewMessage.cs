﻿using System;
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
        
        public NewMessage(User user, string to, string subreply, string Sentmessage)
        {
            InitializeComponent();
            this.user = user;
            txtReciever.Text = to;
            txtSubject.Text = subreply;
            txtMessage.Text = Sentmessage;
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

        private void storeMessage(string sender, string reveiver, string message, DateTime date, string subject)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            
            try
            {
                cn.ConnectionString =
                    @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
                cmd.Connection = cn;

                cmd.CommandText = "INSERT INTO message(sender, receiver, message, date, subject) VALUES (@s, @r, @mess, @date, @sub);";
                cmd.Parameters.AddWithValue("@s", sender);
                cmd.Parameters.AddWithValue("@r", reveiver);
                cmd.Parameters.AddWithValue("@mess", message);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@sub", subject);
                
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
            try
            {
                if (txtReciever.Text == "" || txtSubject.Text == "")
                {
                    string message = "ERROR : Required Field is blank";
                    string title = "Message send Failed";
                    DialogResult result = MessageBox.Show(message, title);
                }
                // Add in a if that makes sure the user you are sending a message is real
                else 
                {
                   string message = "Message Sent Succsefully!";
                   string title = "Message Sent";
                   DialogResult result = MessageBox.Show(message, title);
                   DateTime date;
                   date = DateTime.Now;
                   storeMessage(user.getUsername(), txtReciever.Text, txtMessage.Text, date , txtSubject.Text);

                    txtReciever.Clear();
                    txtMessage.Clear();
                    txtSubject.Clear();
                }
                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Occurred");
            }

        }
    }
}