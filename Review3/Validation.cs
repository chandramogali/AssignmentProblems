using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Review3
{
    public  class Validation
    {
        public static bool IsValidEmail(string email)
        {
            
            string pattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            return Regex.IsMatch(email, pattern);
        }

        public static bool IsNameValid(string name)
        {
           
            //return !string.IsNullOrEmpty(name) && char.IsUpper(name[0]);
            string pattern = @"^[A-Z][a-zA-Z0-9]{3,15}$";
            return Regex.IsMatch(name, pattern);
        }
        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            
            string pattern = @"^\d{10}$"; 
            return Regex.IsMatch(phoneNumber, pattern);
        }
        public static bool IsValidZipCode(string phoneNumber)
        {
           
            string pattern = @"^\d{6}$"; 
            return Regex.IsMatch(phoneNumber, pattern);
        }
    }
}
