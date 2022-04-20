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
        private bool updateClaim(int amt,int claimID, int fmid)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            try
            {
                cmd.Connection = connection;

                cmd.CommandText = "UPDATE Claims" +
                                   " SET EstimatedAmount = @amt, Status = 'Estimated',PaymentStatus = 'Pending', LastUpdate = @lastUpdate, FmID =@fmid where ClaimID = @claimID";
                cmd.Parameters.AddWithValue("@claimId", claimID);
                cmd.Parameters.AddWithValue("@amt", amt);
                cmd.Parameters.AddWithValue("@lastUpdate", DateTime.Now.ToString("M/d/yyyy"));
                cmd.Parameters.AddWithValue("@fmid", fmid);



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
       
        private string getUsername(int userID)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {
                cmd.Connection = connection;

                cmd.CommandText = "SELECT Username FROM SignInInfo WHERE UserID = @userid";

                cmd.Parameters.AddWithValue("@userid", userID);

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

        private void createFolder(int userid)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            try
            {
                cmd.Connection = connection;

                cmd.CommandText = "INSERT INTO Folders (UserID) VALUES (@userid);";
                cmd.Parameters.AddWithValue("@userid", userid);
                connection.Open();
                dr = cmd.ExecuteReader();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "error occurred");
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
        private bool fileClaim(int userID, string username, string email, string type, string description, string startdate, string lastupdate, byte[] Databytes, string extention, string fileName)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            int fmID = getRandomFMID();
            int cmID = getRandomCMID();

            if (fileName != null)
            {
                try
                {
                    cmd.Connection = connection;

                    cmd.CommandText = "INSERT INTO Claims (UserID, Username, UserEmail, Claim_Type, Claim_Description, StartDate, LastUpdate, Status, FileName, FileContentType, FileData,FmID,CmID) VALUES (@userID, @username, @email, @type, @description, @startdate, @lastupdate, @status, @fileName, @fileExtention, @file,@FmID,@CmID)";

                    cmd.Parameters.AddWithValue("@userID", userID);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@type", type);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@startdate", startdate);
                    cmd.Parameters.AddWithValue("@lastupdate", lastupdate);
                    cmd.Parameters.AddWithValue("@status", "Submitted");
                    cmd.Parameters.AddWithValue("@file", Databytes);
                    cmd.Parameters.AddWithValue("@fileName", fileName);
                    cmd.Parameters.AddWithValue("@fileExtention", extention);
                    cmd.Parameters.AddWithValue("@FmID", fmID);
                    cmd.Parameters.AddWithValue("@CmID", cmID);
                    connection.Open();

                    dr = cmd.ExecuteReader();
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
            }
            else
            {
                try
                {
                    cmd.Connection = connection;

                    cmd.CommandText = "INSERT INTO Claims (UserID, Username, UserEmail, Claim_Type, Claim_Description, StartDate, LastUpdate, Status,FmID,CmID) VALUES (@userID, @username, @email, @type, @description, @startdate, @lastupdate, @status,@FmID,@CmID);";

                    cmd.Parameters.AddWithValue("@userID", userID);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@type", type);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@startdate", startdate);
                    cmd.Parameters.AddWithValue("@lastupdate", lastupdate);
                    cmd.Parameters.AddWithValue("@status", "Submitted");

                    cmd.Parameters.AddWithValue("@FmID", fmID);
                    cmd.Parameters.AddWithValue("@CmID", cmID);

                    connection.Open();

                    dr = cmd.ExecuteReader();
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
            }
            return true;
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
        private void sendmessage(string sender, string reveiver, string message, DateTime date, string subject, byte[] fileStream, string extention, string fileName, int Attachment)
        {

            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            try
            {
                cmd.Connection = connection;
                if (fileStream != null)
                {
                    cmd.CommandText = "INSERT INTO message VALUES (@s, @r, @mess, @date, @sub, @re, @file, @fileName, @fileExtention, @Attachment)";
                    cmd.Parameters.AddWithValue("@s", sender);
                    cmd.Parameters.AddWithValue("@r", reveiver);
                    cmd.Parameters.AddWithValue("@mess", message);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@sub", subject);
                    cmd.Parameters.AddWithValue("@re", " • ");
                    cmd.Parameters.AddWithValue("@file", fileStream);
                    cmd.Parameters.AddWithValue("@fileName", fileName);
                    cmd.Parameters.AddWithValue("@fileExtention", extention);
                    cmd.Parameters.AddWithValue("@Attachment", Attachment);

                    connection.Open();

                    dr = cmd.ExecuteReader();
                }
                else
                {
                    cmd.CommandText = "INSERT INTO message(sender, receiver, message, date, subject, readorunread, Attachment) VALUES (@s, @r, @mess, @date, @sub, @re, @Attachment);";
                    cmd.Parameters.AddWithValue("@s", sender);
                    cmd.Parameters.AddWithValue("@r", reveiver);
                    cmd.Parameters.AddWithValue("@mess", message);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@sub", subject);
                    cmd.Parameters.AddWithValue("@re", " • ");
                    cmd.Parameters.AddWithValue("@Attachment", Attachment);

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
        private string accessfilename(string sender, string receiver, string subject, string message)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            try
            {
                cmd.Connection = connection;

                cmd.CommandText = "SELECT FileName FROM message WHERE sender = @sender AND receiver = @receiver AND Subject = @subject AND message = @message";

                cmd.Parameters.AddWithValue("@sender", sender);
                cmd.Parameters.AddWithValue("@receiver", receiver);
                cmd.Parameters.AddWithValue("@subject", subject);
                cmd.Parameters.AddWithValue("@message", message);
                

                connection.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                Console.WriteLine(dr.GetString(0));
                Console.WriteLine("in db handler get file name");
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
                //MessageBox.Show(err.Message, "Error Occurred");
                return null;
            }
            finally
            {
                connection.Close();
            }
        }
        private byte[] accessfile(string sender, string receiver, string subject, string message, string Filename)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            try
            {
                cmd.Connection = connection;

                cmd.CommandText = "SELECT FileData FROM message WHERE sender = @sender AND receiver = @receiver AND Subject = @subject AND message = @message";

                cmd.Parameters.AddWithValue("@sender", sender);
                cmd.Parameters.AddWithValue("@receiver", receiver);
                cmd.Parameters.AddWithValue("@subject", subject);
                cmd.Parameters.AddWithValue("@message", message);
                //cmd.Parameters.AddWithValue("@Name", Filename);


                connection.Open();
                dr = cmd.ExecuteReader();
                dr.Read();

                try
                {
                    byte[] byteArray = (byte[])dr[0];
                    return byteArray;
                }
                catch (Exception err)
                {

                    return null;
                }

            }
            catch (Exception err)
            {
                //MessageBox.Show(err.Message, "Error Occurred");
                return null;
            }
            finally
            {
                connection.Close();
            }
        }
        private string accessfiletype(string sender, string receiver, string subject, string message)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            try
            {
                cmd.Connection = connection;

                cmd.CommandText = "SELECT FileContentType FROM message WHERE sender = @sender AND receiver = @receiver AND Subject = @subject AND message = @message";

                cmd.Parameters.AddWithValue("@sender", sender);
                cmd.Parameters.AddWithValue("@receiver", receiver);
                cmd.Parameters.AddWithValue("@subject", subject);
                cmd.Parameters.AddWithValue("@message", message);


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
                //MessageBox.Show(err.Message, "Error Occurred");
                return null;
            }
            finally
            {
                connection.Close();
            }
        }
        private int attachment(string sender, string receiver, string subject, string message)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            try
            {
                cmd.Connection = connection;

                cmd.CommandText = "SELECT Attachment FROM message WHERE sender = @sender AND receiver = @receiver AND Subject = @subject AND message = @message";

                cmd.Parameters.AddWithValue("@sender", sender);
                cmd.Parameters.AddWithValue("@receiver", receiver);
                cmd.Parameters.AddWithValue("@subject", subject);
                cmd.Parameters.AddWithValue("@message", message);


                connection.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                try
                {

                    return dr.GetInt32(0);

                }
                catch (Exception err)
                {

                    return 0;
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Occurred");
                return 0;
            }
            finally
            {
                connection.Close();
            }
        }
        private string acess_filename_claim(string ID)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            try
            {
                cmd.Connection = connection;

                cmd.CommandText = "SELECT FileName FROM Claims WHERE ClaimId = @ID";

                cmd.Parameters.AddWithValue("@ID", ID);

                connection.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                try
                { 
                    return dr.GetString(0);
                }
                catch (Exception err)
                {
                    //MessageBox.Show(err.Message, "Error Occurred");
                    return "";
                }

            }
            catch (Exception err)
            {
                //MessageBox.Show(err.Message, "Error Occurred");
                return "";
            }
            finally
            {
                connection.Close();
            }
        }
        private string accesss_fileType_Claim (string ID)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            try
            {
                cmd.Connection = connection;
                cmd.CommandText = "SELECT FileContentType FROM Claims WHERE ClaimId = @ID";
                cmd.Parameters.AddWithValue("@ID", ID);
              
                connection.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                try
                {

                    return dr.GetString(0);

                }
                catch (Exception err)
                {
                    //MessageBox.Show(err.Message, "Error Occurred");
                    return "";
                }

            }
            catch (Exception err)
            {
                //MessageBox.Show(err.Message, "Error Occurred");
                return null;
            }
            finally
            {
                connection.Close();
            }
        }
        private byte[] access_file_claims(string ID)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            try
            {
                cmd.Connection = connection;

                cmd.CommandText = "SELECT FileData FROM Claims WHERE ClaimId = @ID";

                cmd.Parameters.AddWithValue("@ID", ID);
    
                connection.Open();
                dr = cmd.ExecuteReader();
                dr.Read();

                try
                {
                    byte[] byteArray = (byte[])dr[0];
                    return byteArray;
                }
                catch (Exception err)
                {

                    return null;
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

        private int fmNumClaims(int fmId)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            try
            {
                cmd.Connection = connection;

                cmd.CommandText = "SELECT count(claimID) FROM Claims WHERE fmID = @ID";

                cmd.Parameters.AddWithValue("@ID", fmId);

                connection.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                try
                {

                    return dr.GetInt32(0);

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error Occurred");
                    return 0;
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Occurred");
                return 0;
            }
            finally
            {
                connection.Close();
            }
        }
        private int access_userFromClaim(string ID)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            try
            {
                cmd.Connection = connection;

                cmd.CommandText = "SELECT UserID FROM Claims WHERE ClaimId = @ID";

                cmd.Parameters.AddWithValue("@ID", ID);

                connection.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                try
                {

                    return dr.GetInt32(0);

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error Occurred");
                    return 0;
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error Occurred");
                return 0;
            }
            finally
            {
                connection.Close();
            }
        }




        // </private methods>
        // <public methods>
        public int getRandomFMID()
        {
            List<int> list = new List<int>();
            var random = new Random();

            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            try
            {
                cmd.Connection = connection;

                cmd.CommandText = "SELECT UserID FROM SignInInfo WHERE clearance = 2";
                connection.Open();
                using (dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        list.Add(dr.GetInt32(0));
                    }
                }
                int index = random.Next(list.Count);

                return list[index];
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return 0;
            }
            finally
            {
                connection.Close();
            }
        }

        public int getRandomCMID()
        {
            List<int> list = new List<int>();
            var random = new Random();

            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            try
            {
                cmd.Connection = connection;

                cmd.CommandText = "SELECT UserID FROM SignInInfo WHERE clearance = 1";
                connection.Open();
                using (dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        list.Add(dr.GetInt32(0));
                    }
                }
                int index = random.Next(list.Count);

                return list[index];
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return 0;
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable LoadTable(int FmID)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString =
                @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = ("SELECT ClaimID, Username, Status,StartDate, LastUpdate, EstimatedAmount, PaymentStatus, Claim_Type, Claim_Description FROM Claims where FmID = @FmID");
            cmd.Parameters.AddWithValue("@FmID", FmID);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
           
            //SqlDataAdapter da = new SqlDataAdapter("SELECT ClaimID, Username, Status,StartDate, LastUpdate, EstimatedAmount, PaymentStatus, Claim_Type, Claim_Description FROM Claims WHERE FmID = @fmid OR FmID IS NULL", cn);
            //da.SelectCommand.Parameters.Add("@fmid", userFM.getUserID());

            DataTable dtbl = new DataTable();
            da.Fill(dtbl);
            cn.Close();
            return dtbl;
        }
        
        //something is going wrong here with the file data type conversion
        private void filefile(int userid, string fname, string desc, string exten, byte[] datab, int fmPerm, int cmPerm,int clientPerm,int folderid)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            try
            {
                cmd.Connection = connection;

                cmd.CommandText = "INSERT INTO FilesInFolders (UserID, FileName, FolderID, FileContentType, FileData, FmPermission, CmPermission, ClientPermission, FileDescription) " +
                                                      "VALUES (@userID,  @fileName, @folderid,@fileExtension, @file, @Fmp, @CmP, @CP, @description);";

                cmd.Parameters.AddWithValue("@userID", userid);
                cmd.Parameters.AddWithValue("@description", desc);
                cmd.Parameters.AddWithValue("@file", datab);
                cmd.Parameters.AddWithValue("@fileName", fname);
                cmd.Parameters.AddWithValue("@fileExtension", exten);
                cmd.Parameters.AddWithValue("@FmP", fmPerm);
                cmd.Parameters.AddWithValue("@CmP", cmPerm);
                cmd.Parameters.AddWithValue("@CP", clientPerm);
                cmd.Parameters.AddWithValue("@folderid", folderid);

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
        private int getFolderID(int userid)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            try
            {
                cmd.Connection = connection;
                cmd.CommandText = "SELECT UserID FROM Folders WHERE UserID = @id";
                cmd.Parameters.AddWithValue("@id", userid);

                connection.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                return dr.GetInt32(0);
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, "Folder Does not Exist");
                return 0;
            }
            finally
            {
                connection.Close();
            }
        }

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

        public void create_folder(int user)
        {
            createFolder(user);
        }
        public void file_file(int userid, string fname, string desc, string exten, byte[] datab, int fmPerm, int cmPerm, int clientPerm, int folderid)
        {
            filefile(userid, fname, desc, exten, datab, fmPerm, cmPerm, clientPerm, folderid);
        }
        public int get_folder_id(int userid)
        {
            return getFolderID(userid);
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
        public bool file_claim(int userID, string username, string email, string type, string description, string startdate, string lastupdate, byte[] Databytes, string extention, string fileName)
        {
            return fileClaim(userID, username, email, type, description, startdate, lastupdate, Databytes, extention, fileName);
        }
        public bool update_Claim(int amt, int claimID, int fmid)
        {
            if (updateClaim(amt, claimID,fmid))
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
        public void send_message(string sender, string reveiver, string message, DateTime date, string subject, byte[] fileStream, string extention, string fileName, int Attachment)
        {
            sendmessage(sender, reveiver, message, date, subject, fileStream, extention, fileName, Attachment);
        }
        public string get_filename(string sender, string receiver, string subject, string message)
        {
            return accessfilename(sender, receiver, subject, message);
        }
        public byte[] get_file(string sender, string receiver, string subject, string message, string fileName)
        {
            return accessfile(sender, receiver, subject, message, fileName);
        }
        public string get_fileType(string sender, string receiver, string subject, string message)
        {
            return accessfiletype(sender, receiver, subject, message);
        }
        public int get_attachment(string sender, string receiver, string subject, string message)
        {
            return attachment(sender, receiver, subject, message);
        }
        public string get_filename_claim(string ID)
        {
            return acess_filename_claim(ID);
        }
        public string get_fileType_Claim(string ID)
        {
            return accesss_fileType_Claim(ID);
        }
        public byte[] get_file_claims(string ID)
        {
            return access_file_claims(ID);
        }
        public int get_userFromClaim(string ID)
        {
            return access_userFromClaim(ID);
        }

        public string get_username(int id)
        {
            return getUsername(id);
        }
        // </public methods>
    }
}
