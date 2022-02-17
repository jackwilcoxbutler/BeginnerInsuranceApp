using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
