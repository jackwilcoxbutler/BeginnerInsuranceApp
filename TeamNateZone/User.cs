using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TeamNateZone
{
    public class User
    {
        //Data
        String username, password, email, fname, lname;
        int id, clearance;

        // constructor
        public User(int id, string fname, string lname, string username, string password, string email, int clearance) //created by login/reg form
        {
            this.fname = fname;
            this.lname = lname;
            this.username = username;
            this.password = password;
            this.email = email;
            this.clearance = clearance;
            this.id = id;
        }
        // default constructor (makes empty object)
        public User()
        {
            id = 0;
            fname = "";
            lname = "";
            username = "";
            password = "";
            email = "";
            clearance = 0;
        }
        //constructor with two parameters
        public User(string userN, string pWord)
        {
            username = userN;
            password = pWord;
            clearance = getUserPermisions(username);
            fname = getFname(username);
            lname = getLname(username);
            id = getUserID(username);
            email = getUserEmail(username);
        }

        //get methods
        public int getUserID()
        {
            return id;
        }
        public string getUsername()
        {
            return username;
        }
        public string getFname()
        {
            return fname;
        }
        public string getLname()
        {
            return lname;
        }
        public string getPassword()
        {
            return password;
        }
        public string getEmail()
        {
            return email;
        }
        public string getRole()
        {
            switch (clearance)
            {
                case 0:
                    {
                        return "Client";
                    }
                case 1:
                    {
                        return "Claims Manager";
                    }
                case 2:
                    {
                        return "Finance Manager";
                    }
                case 3:
                    {
                        return "Admin";
                    }
                default:
                    { 
                        return ""; 
                    }
            }
        }
        public int getClearance()
        {
            return clearance;
        }

        /// set methods
        /// added simple set method to automatically set all the info to an
        /// user directly from the table
        public void setUserAcct(string userN, string pWord)
        {
            username = userN;
            password = pWord;
            clearance = getUserPermisions(username);
            fname = getFname(username);
            lname = getLname(username);
            id = getUserID(username);
            email = getUserEmail(username);
        }
        public void setUserID(int value)
        {
            id = value;
        }
        public void setUsername(string value)
        {
            username = value;
        }
        public void setFname(string value)
        {
            fname = value;
        }
        public void setLname(string value)
        {
            lname = value;
        }
        public void setPassword(string value)
        {
            password = value;
        }
        public void setEmail(string value)
        {
            email = value;
        }
        public void setUserType(int value)
        {
            clearance = value;
        }

        //sql linking stuff-- clean up to get rid of random errors appearing at log in screen
        //pulls info directly from db to return the valid info 
        private int getUserPermisions(string userN)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            try
            {
                cn.ConnectionString =
                    @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
                cmd.Connection = cn;
                cmd.CommandText = "SELECT clearance FROM SignInInfo WHERE Username = @username";
                cmd.Parameters.AddWithValue("@username", userN);
                cn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                return dr.GetInt32(0);
            }
            catch (Exception err)
            {
                return 0;
            }
            finally
            {
                cn.Close();
            }
        }

        private int getUserID(string userN)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {
                cn.ConnectionString =
                    @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
                cmd.Connection = cn;
                cmd.CommandText = "SELECT UserID FROM SignInInfo WHERE Username = @username";
                cmd.Parameters.AddWithValue("@username", userN);
                cn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                return dr.GetInt32(0);
            }
            catch (Exception err)
            {
                return 0;
            }
            finally
            {
                cn.Close();
            }
        }

        private string getUserEmail(string userN)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {
                cn.ConnectionString =
                    @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Email FROM SignInInfo WHERE Username = @username";
                cmd.Parameters.AddWithValue("@username", userN);
                cn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                return dr.GetString(0);
            }
            catch (Exception err)
            {
                return null;
            }
            finally
            {
                cn.Close();
            }
        }
        private string getFname(string userN)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {
                cn.ConnectionString =
                    @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
                cmd.Connection = cn;
                cmd.CommandText = "SELECT fName FROM SignInInfo WHERE Username = @username";
                cmd.Parameters.AddWithValue("@username", userN);
                cn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                return dr.GetString(0);
            }
            catch (Exception err)
            {
                return null;
            }
            finally
            {
                cn.Close();
            }
        }

        private string getLname(string userN)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;

            try
            {
                cn.ConnectionString =
                    @"Data Source=se361.cysfo7qeek6c.us-east-1.rds.amazonaws.com;Initial Catalog=TEAM_A;Persist Security Info=True;User ID=TEAM_A;Password=j2uBr3v4F4y7kgAZF3CZmmMP;Encrypt=True;TrustServerCertificate=True";
                cmd.Connection = cn;
                cmd.CommandText = "SELECT lName FROM SignInInfo WHERE Username = @username";
                cmd.Parameters.AddWithValue("@username", userN);
                cn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                return dr.GetString(0);
            }
            catch (Exception err)
            {
                return null;
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
