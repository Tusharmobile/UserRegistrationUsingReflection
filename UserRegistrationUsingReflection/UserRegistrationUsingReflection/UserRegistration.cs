﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationexRefAnn
{
    public class UserRegister
    {
        public static string firstNamePattern = "^[A-Z]{1}[a-z]{2}";
        public static string lastNamePattern = "^[A-Z]{1}[a-z]{2}";
        public static string mobilePattern = "^([9][1])[ ]*[6-9]{1}[0-9]{9}$";
        //Method to Validate First Name
        public static string ValidateFirstName(string name)
        {
            if (Regex.IsMatch(name, firstNamePattern))
                return "true";
            else
                return "false";
        }
        //Method to Validate Last Name
        public static string ValidateLastName(string name)
        {
            if (Regex.IsMatch(name, lastNamePattern))
                return "true";
            else
                return "false";
        }
        //Method to Validate Mobile Nuber
        public static string ValidateMobileNumber(string number)
        {
            if (Regex.IsMatch(number, mobilePattern))
                return "true";
            else
                return "false";
        }
    }
}