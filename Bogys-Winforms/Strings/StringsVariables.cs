﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Bogys_Winforms.Strings
{
    class StringsVariables : StringVideoHeaders
    {
        public string ID = "ID";
        public string ClientType = "CLIENT";
        public string AdminType = "ADMIN";
        public string invalidUser = "Invalid username or password.";
        public string fillReqFields = "Please fill in all required fields.";
        public string successTitle = "Success";
        public string registerSuccess = "Registration successful!";
        public string errorRegister = "Error saving user: ";
        public string databaseTitleError = "Database Error";
        public string usernameExist = "Username already exists. Please choose a different username.";
        public string confirmPass = "Passwords do not match. Please re-enter.";
        public string AddBtnMsg = "Are you sure you want to Add this Video? Add";
        public string AddBtnMsgTitle = "Confirm Add";
        public string errSavingUser = "Error saving user: ";
        public string editMsg = "Are you sure you want to edit this?";
        public string editMsgTitle = "Confirm Edit";
        public string customerSelect = "Please select a customer to edit.";
        public string validationTitle = "Validation Error";
        public string validatePhoneMsg = "Phone number must be exactly 11 digits and contain only numbers.";
        public string validateBday = "Birthdate cannot be in the future.";
        public string validateVidTitle = "Video title already exists.";
        public string validateRentTitle = "You have already rented this Video.";
        public string validateInCount = "Video in cannot be empty.";
        public string validateInCountData = "Stock must be a whole number.";
        public string validateEditDelete = "Please select a Video to edit or delete.";
        public string confirmDelete = "Are you sure you want to delete this Video?";
        public string validateDelete = "Cannot delete a video that is currently rented.";
        public string confirmDeleteTitle = "Confirm Delete";
        public string inputValidator = " cannot be empty.";
        public string rentMsg = "Are you sure you want to Rent this Video?";
        public string rentNoSelect = "Please select a video to rent.";
        public string returnNoSelect = "Please select a video to return.";
        public string rentMsgTitle = "Confirm Rent";
        public string all = "ALL";
        public string vcd = "VCD";
        public string dvd = "DVD";
        public string active = "ACTIVE";
        public string overdue = "OVERDUE";
        public string refreshtab = "RefreshControl";
        public string updateFeesMsg = "Error updating overdue fees and status: ";
        public string validateReturn = "Are you sure you want to return this movie? with overdue fee of ";
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
        //Para sa rent table
        public string VideoID = "VideoID";
        public string UserID = "UserID";
        public string CustomerName = "CustomerName";
        public string OverdueFee = "OverdueFee";
        public string RentDate = "RentDate";
        public string ReturnDate = "ReturnDate";
        public string Status = "Status";
        //Title sa video sa gridview
        public string _VideoTitle = "Title";
        public string _VideoCategory = "Category";
        public string _VideoInCount = "In";
        public string _VideoOutCount = "Out";
        public string _VideoAdded = "Video Added";
        public string _VideoPrice = "Price";
        public string _RentDays = "Rent Days";
        //Title para sa rent table
        public string _VideoID = "Video ID";
        public string _UserID = "Customer ID";
        public string _CustomerName = "Customer Name";
        public string _OverdueFee = "Due Charge";
        public string _RentDate = "Date Rented";
        public string _ReturnDate = "Return Date";
        public string _Status = "Status";
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
