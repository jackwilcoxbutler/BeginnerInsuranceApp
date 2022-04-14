using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace TeamNateZone
{
    public class dbHandler
    {
        public SqlConnection connection;
        public SqlDataReader dr;
// <constructor>
        public dbHandler(string cnString)
        {
            //error handling
            try
            {

                connection = new SqlConnection(); //create an instance of a new SqlConnection

                connection.ConnectionString = cnString; //set the connection string for the SqlConnection

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Something went wrong with the DB connection");
            }
        }
// </constructor>

// <private methods>
        private bool updateClaim(int amt,int claimID)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            try
            {
                cmd.Connection = connection;

                cmd.CommandText = "UPDATE Claims" +
                                   " SET EstimatedAmount = @amt, Status = 'Estimated',PaymentStatus = 'Pending', LastUpdate = @lastUpdate where ClaimID = @claimID";
                cmd.Parameters.AddWithValue("@claimId", claimID);
                cmd.Parameters.AddWithValue("@amt", amt);
                cmd.Parameters.AddWithValue("@lastUpdate", DateTime.Now.ToString("M/d/yyyy"));



                connection.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Occurred");

                return false;
            }
            finally
            {
                connection.Close();
            }
            return true;
        }
    
        private String getAuthorizedPassword(string userName)
        {
            if(getUsername(userName) == "")
            {
                return null;
            }
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {
                cmd.Connection = connection;

                cmd.CommandText = "SELECT Password FROM SignInInfo WHERE Username = @username OR Email = @username";

                cmd.Parameters.AddWithValue("@username", userName);

                connection.Open();

                dr = cmd.ExecuteReader();

                if (dr == null)
                {
                    return null;
                }

                dr.Read();

                return dr.GetString(0);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Occurred");
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        private string getEmail(string email)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {
                cmd.Connection = connection;

                cmd.CommandText = "SELECT Email FROM SignInInfo WHERE Email = @email";

                cmd.Parameters.AddWithValue("@email", email);

                connection.Open();

                dr = cmd.ExecuteReader();

                dr.Read();

                try
                {
                    return dr.GetString(0);
                }
                catch (Exception err)
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
                connection.Close();
            }
        }
        private string getUsername(string userName)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {
                cmd.Connection = connection;

                cmd.CommandText = "SELECT Username FROM SignInInfo WHERE Username = @username";

                cmd.Parameters.AddWithValue("@username", userName);

                connection.Open();

                dr = cmd.ExecuteReader();

                dr.Read();

                try
                {
                    return dr.GetString(0);
                }
                catch (Exception err)
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
                connection.Close();
            }
        }
        private void store_in_database(string first, string last, string address, string city, string state, string zip, string userName, string passWord, string eMail)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            DateTime today = DateTime.Today;
            try
            {
                cmd.Connection = connection;

                cmd.CommandText = "INSERT INTO SignInInfo (Email, Password, fName, lName, Street, City, State, Zip, clearance, Username, DateRegistered) VALUES (@email, @password, @f, @l, @str, @city, @st, @zip5, @clear, @username, @today);";

                cmd.Parameters.AddWithValue("@f", first);
                cmd.Parameters.AddWithValue("@l", last);
                cmd.Parameters.AddWithValue("@str", address);
                cmd.Parameters.AddWithValue("@city", city);
                cmd.Parameters.AddWithValue("@st", state);
                cmd.Parameters.AddWithValue("@zip5", zip);
                cmd.Parameters.AddWithValue("@username", userName);
                cmd.Parameters.AddWithValue("@password", passWord);
                cmd.Parameters.AddWithValue("@email", eMail);
                cmd.Parameters.AddWithValue("@clear", 0);
                cmd.Parameters.AddWithValue("@today", today);

                connection.Open();

                dr = cmd.ExecuteReader();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Occurred");
            }
            finally
            {
                connection.Close();
            }
        }
        private void store_in_database(string first, string last, string address, string city, string state, string zip, string userName, string passWord, string eMail, int clearance)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {
                cmd.Connection = connection;

                cmd.CommandText = "INSERT INTO SignInInfo (Email, Password, fName, lName, Street, City, State, Zip, clearance, Username) VALUES (@email, @password, @f, @l, @str, @city, @st, @zip5, @clear, @username);";

                cmd.Parameters.AddWithValue("@f", first);
                cmd.Parameters.AddWithValue("@l", last);
                cmd.Parameters.AddWithValue("@str", address);
                cmd.Parameters.AddWithValue("@city", city);
                cmd.Parameters.AddWithValue("@st", state);
                cmd.Parameters.AddWithValue("@zip5", zip);
                cmd.Parameters.AddWithValue("@username", userName);
                cmd.Parameters.AddWithValue("@password", passWord);
                cmd.Parameters.AddWithValue("@email", eMail);
                cmd.Parameters.AddWithValue("@clear", clearance);

                connection.Open();

                dr = cmd.ExecuteReader();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Occurred");
            }
            finally
            {
                connection.Close();
            }
        }
        private /*async*/ User getUserAcct(string userName)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {
                cmd.Connection = connection;

                cmd.CommandText = "SELECT * FROM SignInInfo WHERE Username = @username";

                cmd.Parameters.AddWithValue("@username", userName);

                connection.Open();

                dr = cmd.ExecuteReader();

                dr.Read();

                User user = new User(
                    dr.GetInt32(10), // user ID
                    dr.GetString(0), // email
                    dr.GetString(1), // password
                    dr.GetString(2), // First Name
                    dr.GetString(3), // Last Name
                    dr.GetString(4), // Street
                    dr.GetString(5), // City
                    dr.GetString(6), // State
                    dr.GetString(7), // Zip
                    dr.GetInt32(8),  // Clearance
                    dr.GetString(9)); // UserName

                return user;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Occurred");
                return null;
            }
            finally
            {
                connection.Close();
            }
        }
        private void updateUserProfile(int userID, string email, string password, string street, string city, string state, string zip)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {
                cmd.Connection = connection;

                cmd.CommandText = "UPDATE SignInInfo SET Email = @email, Password = @password, street = @street, city = @city, state = @state, zip = @zip WHERE UserID = @uid";

                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@street", street);
                cmd.Parameters.AddWithValue("@city", city);
                cmd.Parameters.AddWithValue("@state", state);
                cmd.Parameters.AddWithValue("@zip", zip);
                cmd.Parameters.AddWithValue("@uid", userID);

                connection.Open();

                dr = cmd.ExecuteReader();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Occurred");
            }
            finally
            {
                connection.Close();
            }
        }
        private void fileClaim(int userID, string username, string email, string type, string description, string startdate, string lastupdate)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {
                cmd.Connection = connection;

                cmd.CommandText = "INSERT INTO Claims (UserID, Username, UserEmail, Claim_Type, Claim_Description, StartDate, LastUpdate, Status) VALUES (@userID, @username, @email, @type, @description, @startdate, @lastupdate, @status);";

                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@startdate", startdate);
                cmd.Parameters.AddWithValue("@lastupdate", lastupdate);
                cmd.Parameters.AddWithValue("@status", "Submitted");

                connection.Open();

                dr = cmd.ExecuteReader();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Occurred");
            }
            finally
            {
                connection.Close();
            }
        }
        private DataTable access_inbox(User user)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM message WHERE receiver = @receiver ORDER BY date DESC;", connection);
            da.SelectCommand.Parameters.AddWithValue("@receiver", user.getUsername());
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);
            return dtbl;
        }
        private DataTable access_outbox(User user)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;

            SqlDataAdapter da = new SqlDataAdapter("SELECT sender, receiver, message, date, subject FROM message WHERE sender = @sender ORDER BY date DESC", connection);
            da.SelectCommand.Parameters.AddWithValue("sender", user.getUsername());
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);
            return dtbl;
        }
        private void sendmessage(string sender, string reveiver, string message, DateTime date, string subject, byte[] fileStream)
        {

            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            Console.WriteLine(fileStream);
            try
            {
                cmd.Connection = connection;
                if (fileStream != null)
                {
                    cmd.CommandText = "INSERT INTO message VALUES (@s, @r, @mess, @date, @sub, @re, @file)";
                    cmd.Parameters.AddWithValue("@s", sender);
                    cmd.Parameters.AddWithValue("@r", reveiver);
                    cmd.Parameters.AddWithValue("@mess", message);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@sub", subject);
                    cmd.Parameters.AddWithValue("@re", " • ");
                    cmd.Parameters.AddWithValue("@file", fileStream);

                    connection.Open();

                    dr = cmd.ExecuteReader();
                }
                else
                {
                    cmd.CommandText = "INSERT INTO message(sender, receiver, message, date, subject, readorunread ) VALUES (@s, @r, @mess, @date, @sub, @re);";
                    cmd.Parameters.AddWithValue("@s", sender);
                    cmd.Parameters.AddWithValue("@r", reveiver);
                    cmd.Parameters.AddWithValue("@mess", message);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@sub", subject);
                    cmd.Parameters.AddWithValue("@re", " • ");
                    
                    connection.Open();

                    dr = cmd.ExecuteReader();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Occurred");
            }
            finally
            {
                connection.Close();
            }
        }
        private string accessExistingReceiver(string receiver)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            try
            {
                cmd.Connection = connection;

                cmd.CommandText = "SELECT Username FROM SignInInfo WHERE Username = @receiver";

                cmd.Parameters.AddWithValue("@receiver", receiver);

                connection.Open();
                dr = cmd.ExecuteReader();
                dr.Read();

                try
                {
                    return dr.GetString(0);
                }
                catch (Exception err)
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
                connection.Close();
            }
        }

        // </private methods>
        // <public methods>
        public String check_password(string username)
        {
            return getAuthorizedPassword(username);
        }
        public string get_email(string email)
        {
            return getEmail(email);
        }
        public string get_username(string username)
        {
            return getUsername(username);
        }
        public void store_user_information(string first, string last, string address, string city, string state, string zip, string userName, string passWord, string eMail)
        {
            store_in_database(first, last, address, city, state, zip, userName, passWord, eMail);
        }
        public void store_privileged_user_information(string first, string last, string address, string city, string state, string zip, string userName, string passWord, string eMail, int clearance)
        {
            store_in_database(first, last, address, city, state, zip, userName, passWord, eMail, clearance);
        }
        public User get_user_information(string username)
        {
            return getUserAcct(username);
        }
        public void update_user_profile(int userID, string email, string password, string street, string city, string state, string zip)
        {
            updateUserProfile(userID, email, password, street, city, state, zip);
        }
        public void file_claim(int userID, string username, string email, string type, string description, string startdate, string lastupdate)
        {
            fileClaim(userID, username, email, type, description, startdate, lastupdate);
        }
        public bool update_Claim(int amt, int claimID)
        {
            if (updateClaim(amt, claimID))
            {
                return true;
            }
            return false;
        }
        public DataTable get_inbox(User user)
        {
            return access_inbox(user);
        }
        public DataTable get_outBox(User user)
        {
            return access_outbox(user);
        }
        public string getExistingReceiver(string Revciever)
        {
            return accessExistingReceiver(Revciever);
        }
        public void send_message(string sender, string reveiver, string message, DateTime date, string subject, byte[] fileStream)
        {
            sendmessage(sender, reveiver, message, date, subject, fileStream);
        }
        // </public methods>
    }
}
