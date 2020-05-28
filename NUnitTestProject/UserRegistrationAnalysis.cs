using System;
using System.Text.RegularExpressions;

namespace NUnitTestProject
{
    public class UserRegistrationAnalysis
    {
        public bool firstName_CapitalFirstLatter_Analysis(string Name)
        {
            int NameLength = Name.Length;
            if (NameLength == 0 || NameLength <= 3)
            {
                return false;
            }

            if (Regex.IsMatch(Name, "^[A-Z]{1}[a-z]{2,}$"))
            {
                return true;
            }
            return false;
        }

        public bool LastName_CapitalFirstLatter_Analysis(string Name)
        {
            int NameLength = Name.Length;
            if (NameLength == 0 || NameLength <= 3)
            {
                return false;
            }

            if (Regex.IsMatch(Name, "^[A-Z]{1}[a-z]{2,}$"))
            {
                return true;
            }
            return false;
        }

        public bool EmailId_Analysis(string Name)
        {
            int NameLength = Name.Length;
            if (NameLength == 0 || NameLength <= 3)
            {
                return false;
            }

            if (Regex.IsMatch(Name, "^abc[.]+[a-zA-Z0-9.-_]{3,}@bl[.]+co[.]+[a-z]+$"))
            {
                return true;
            }
            return false;
        }

        public bool mobileNumber_Analysis(string Name)
        {
            int NameLength = Name.Length;
            if (NameLength == 0 || NameLength <= 3)
            {
                return false;
            }

            if (Regex.IsMatch(Name, "^[0-9]{2,3}[ ]+[0-9]{10}$"))
            {
                return true;
            }
            return false;
        }

    }
}