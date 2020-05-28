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
    }
}