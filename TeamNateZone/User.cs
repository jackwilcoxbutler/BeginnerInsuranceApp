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
        String username, password, email, userType;
        int id;

        // constructor
        public User(int id, String username, string password, string email, string userType) //created by login/reg form
        {
            this.username = username;
            this.password = password;
            this.email = email;
            this.userType = userType;
            this.id = id;
        }
        // default constructor (makes empty object)
        public User()
        {
            id = 0;
            username = "";
            password = "";
            email = "";
            userType = "";
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
            return userType;
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
        public void setPassword(string value)
        {
            password = value;
        }
        public void setEmail(string value)
        {
            email = value;
        }
        public void setUserType(string value)
        {
            userType = value;
        }
    }
}
