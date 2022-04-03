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
        String username, password, email, fname, lname, street, city, state, zip;
        int id, clearance;
        // constructor
        public User(int id, string email, string password, string fname, string lname, string street, string city, string state, string zip, int clearance, string username) //created by login/reg form
        {
            this.fname = fname;
            this.lname = lname;
            this.username = username;
            this.password = password;
            this.email = email;
            this.clearance = clearance;
            this.id = id;
            this.street = street;
            this.city = city;
            this.state = state;
            this.zip = zip;
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
            street = "";
            city = "";
            state = "";
            zip = "";
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
       
        public string getStreet()
        {
            return street; 
        }
        public string getCity()
        {
            return city;
        }
        public string getState()
        {
            return state;
        }
        public string getZip()
        {
            return zip;
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
        public void setClearance(int value)
        {
            clearance = value;
        }
        public void setStreet(string value)
        {
            street = value;
        }
        public void setCity(string value)
        {
            city = value;
        }
        public void setState(string value)
        {
            state = value;
        }
        public void setZip(string value)
        {
            zip = value;
        }
    }
}
