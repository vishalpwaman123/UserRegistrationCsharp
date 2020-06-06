using System;
using System.Text.RegularExpressions;

namespace NUnitTestProject
{
    public class UserRegistrationAnalysis
    {
        public bool firstName_CapitalFirstLatter_Analysis(string Name)
        {
            if (Validate(Name))
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
            }
            return false;
        }

        public bool LastName_CapitalFirstLatter_Analysis(string Name)
        {
            if (Validate(Name))
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
            }
            return false;
        }

        public bool EmailId_Analysis(string Name)
        {
            if (Validate(Name))
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
            }
            return false;
        }

        public bool mobileNumber_Analysis(string Name)
        {
            if (Validate(Name))
            {
                int NameLength = Name.Length;
                if (NameLength == 0 || NameLength <= 9)
                {
                    return false;
                }

                if (Regex.IsMatch(Name, "^[0-9]{2,3}[ ]+[0-9]{10}$"))
                {
                    return true;
                }
            }
            return false;
        }

        public bool password_Analysis(string Name)
        {
            if (Validate(Name))
            {
                int NameLength = Name.Length;
                if (NameLength == 0 || NameLength <= 7)
                {
                    return false;
                }

                if (Regex.IsMatch(Name, "((?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.[@#$%!]).{8,})"))
                {
                    return true;
                }
            }
            return false;
        }

        public bool passwordHaveAtLeastOneUC_Analysis(string Name)
        {
            if (Validate(Name))
            {
                int NameLength = Name.Length;
                if (NameLength == 0 || NameLength <= 7)
                {
                    return false;
                }

                if (Regex.IsMatch(Name, "^(?=.*[A-Z])[A-Za-z0-9]{8,}$"))
                {
                    return true;
                }
            }
            return false;
        }

        public bool passwordHaveAtLeastOneNumber_Analysis(string Name)
        {
            if (Validate(Name))
            {
                int NameLength = Name.Length;
                if (NameLength == 0 || NameLength <= 7)
                {
                    return false;
                }

                if (Regex.IsMatch(Name, "^(?=.*[0-9])[A-Za-z0-9]{8,}$"))
                {
                    return true;
                }
            }
            return false;
        }

        public bool passwordHaveAtLeastOneSpecial_Analysis(string Name)
        {
            if (Validate(Name))
            {
                int NameLength = Name.Length;
                if (NameLength == 0 || NameLength <= 7)
                {
                    return false;
                }

                if (Regex.IsMatch(Name, "^(?=.*[@$!%*#?&])[@$!%*#?&A-Za-z0-9]{8,}$"))
                {
                    return true;
                }
            }
            return false;
        }

        public bool EmailA_Analysis(string Name)
        {
            if (Validate(Name))
            {
                int NameLength = Name.Length;
                if (NameLength == 0 || NameLength <= 5)
                {
                    return false;
                }

                if (Regex.IsMatch(Name, "^[0-9a-zA-Z]+([._+-][0-9a-zA-Z]+)*@[0-9a-zA-Z]+.[a-zA-Z]{2,4}([.][a-zA-Z]{2,3})?$"))
                {
                    return true;
                }
            }
            return false;
        }

        private bool Validate(string Name)
        {
            try
            {
                if (Name == null)
                    throw new NullReferenceException("Field Should Not Be Null");
                else
                    return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Field Should Not Be Empty", e.Message);
            }
            return false;
        }

    }
}