using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bogys_Winforms.Strings
{
    class StringsVariables : StringVideoHeaders
    {
        public string ID = "ID";
        public string ClientType = "CLIENT";
        public string AddBtnMsg = "Are you sure you want to Add this Video? Add";
        public string AddBtnMsgTitle = "Confirm Add";
        public string errSavingUser = "Error saving user: ";
    }
    class StringVideoHeaders : StringCustomerAttribute
    {
        public string VideoTitle = "VideoTitle";
        public string VideoCategory = "VideoCategory";
        public string VideoInCount = "VideoInCount";
        public string VideoOutCount = "VideoOutCount";
        public string VideoAdded = "VideoAdded";
        public string VideoPrice = "VideoPrice";
        public string RentDays = "RentDays";
    }
    class StringCustomerAttribute
    {
        public string UserName = "UserName";
        public string UserPassword = "UserPassword";
        public string UserType = "UserType";
        public string UserAddress = "UserAddress";
        public string BirthDate = "BirthDate";
        public string Email = "Email";
        public string Phonenumber = "Phonenumber";
        public string FirstName = "FirstName";
        public string LastName = "LastName";
        public string CreatedAt = "CreatedAt";
        //Title sa customer sa gridview
        public string _UserName = "Username";
        public string _UserAddress = "Address";
        public string _BirthDate = "Birth Date";
        public string _Email = "Email";
        public string _Phonenumber = "Phone Number";
        public string _FirstName = "First Name";
        public string _LastName = "Last Name";
        public string _CreatedAt = "Registered During";
    }
}
