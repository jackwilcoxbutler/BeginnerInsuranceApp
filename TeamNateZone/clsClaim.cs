using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamNateZone
{
    class clsClaim
    {
        //Claim ID, user ID, claim Type, claim Description, start Date, end date, status, last update, payment status, 
        //lastUpdate, payment status, CM ID, FM ID, Estimated End Date 

        //Data
        String claimType, claimDesc, claimStatus, paymentStatus;
        int userID, claimID, cmID, fmID;
        DateTime startDate, endDate, estEndDate, lastUpdate;

        //Constructor 
        public claim(int claimID, int userID, int cmID,int fmID, string claimType, string claimDesc, string claimStatus, 
                     string paymentStatus, DateTime startDate, DateTime endDate, DateTime estEndDate, DateTime lastUpdate) //created by claim form
        {
            this.claimID = claimID;
            this.userID = userID;
            this.cmID = cmID;
            this.fmID = fmID;
            this.claimType = claimType;
            this.claimDesc = claimDesc;
            this.claimStatus = claimStatus;
            this.paymentStatus = paymentStatus;
            this.startDate = startDate;
            this.endDate= endDate;
            this.estEndDate= estEndDate;
            this.lastUpdate = lastUpdate;
        }

        //Need a default constructor 

        //Need a constructor that takes in parameters 

    }
}
