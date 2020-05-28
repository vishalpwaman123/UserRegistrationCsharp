using NUnit.Framework;

namespace NUnitTestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void givenFirstName_whenFirstLetterCapital_shouldReturnTrue()
        {
            UserRegistrationAnalysis useranalysis = new UserRegistrationAnalysis();
            Assert.AreEqual(true, useranalysis.firstName_CapitalFirstLatter_Analysis("Vishal"));
        }

        [Test]
        public void givenFirstName_whenFirstLetterCapital_shouldReturnFalse()
        {
            UserRegistrationAnalysis useranalysis = new UserRegistrationAnalysis();
            Assert.AreEqual(false, useranalysis.firstName_CapitalFirstLatter_Analysis("rahul"));
        }

        [Test]
        public void givenLastName_whenFirstLetterCapital_shouldReturnTrue()
        {
            UserRegistrationAnalysis useranalysis = new UserRegistrationAnalysis();
            Assert.AreEqual(true, useranalysis.LastName_CapitalFirstLatter_Analysis("Waman"));
        }

        [Test]
        public void givenLastName_whenFirstLetterNotCapital_shouldReturnFalse()
        {
            UserRegistrationAnalysis useranalysis = new UserRegistrationAnalysis();
            Assert.AreEqual(false, useranalysis.LastName_CapitalFirstLatter_Analysis("wamankar"));
        }

        [Test]
        public void givenLastName_whenLetterMoreThree_shouldReturnTrue()
        {
            UserRegistrationAnalysis useranalysis = new UserRegistrationAnalysis();
            Assert.AreEqual(true, useranalysis.LastName_CapitalFirstLatter_Analysis("Wamankar"));
        }

        [Test]
        public void givenFirstName_whenLetterMoreThree_shouldReturnTrue()
        {
            UserRegistrationAnalysis useranalysis = new UserRegistrationAnalysis();
            Assert.AreEqual(true, useranalysis.firstName_CapitalFirstLatter_Analysis("Rahul"));
        }

        [Test]
        public void givenEmailId_whenHaveMandetoryField_shouldReturnTrue()
        {
            UserRegistrationAnalysis useranalysis = new UserRegistrationAnalysis();
            Assert.AreEqual(true, useranalysis.EmailId_Analysis("abc.xyz@bl.co.in"));
        }

        [Test]
        public void givenEmailId_whenNotHaveMandetoryField_shouldReturnFalse()
        {
            UserRegistrationAnalysis useranalysis = new UserRegistrationAnalysis();
            Assert.AreEqual(false, useranalysis.EmailId_Analysis("a.xyz@bl.co.in"));
        }

        [Test]
        public void givenMobileNumber_whenHaveMandetoryField_shouldReturnTrue()
        {
            UserRegistrationAnalysis useranalysis = new UserRegistrationAnalysis();
            Assert.AreEqual(true, useranalysis.mobileNumber_Analysis("91 7758039722"));
        }

        [Test]
        public void givenMobileNumber_whenNotHaveMandetoryField_shouldReturnFalse()
        {
            UserRegistrationAnalysis useranalysis = new UserRegistrationAnalysis();
            Assert.AreEqual(false, useranalysis.mobileNumber_Analysis("91 77503972"));
        }

        [Test]
        public void givenPassword_whenHaveMandetoryField_shouldReturnFalse()
        {
            UserRegistrationAnalysis useranalysis = new UserRegistrationAnalysis();
            Assert.AreEqual(false, useranalysis.password_Analysis("VishalWamankar"));
        }

        [Test]
        public void givenPassword_whenNotHaveMandetoryField_shouldReturnFalse()
        {
            UserRegistrationAnalysis useranalysis = new UserRegistrationAnalysis();
            Assert.AreEqual(false, useranalysis.password_Analysis("rahul"));
        }


        [Test]
        public void givenPassword_whenHaveAtLeastOneUpperCase_shouldReturnTrue()
        {
            UserRegistrationAnalysis useranalysis = new UserRegistrationAnalysis();
            Assert.AreEqual(true, useranalysis.passwordHaveAtLeastOneUC_Analysis("Vishalwaman"));
        }

        [Test]
        public void givenPassword_whenNotHaveAtLeastOneUpperCase_shouldReturnFalse()
        {
            UserRegistrationAnalysis useranalysis = new UserRegistrationAnalysis();
            Assert.AreEqual(false, useranalysis.passwordHaveAtLeastOneUC_Analysis("vishalwaman"));
        }

        [Test]
        public void givenPassword_whenHaveAtLeastOneNumber_shouldReturnTrue()
        {
            UserRegistrationAnalysis useranalysis = new UserRegistrationAnalysis();
            Assert.AreEqual(true, useranalysis.passwordHaveAtLeastOneNumber_Analysis("Vishal123"));
        }

        [Test]
        public void givenPassword_whenNotHaveAtLeastOneNumber_shouldReturnFalse()
        {
            UserRegistrationAnalysis useranalysis = new UserRegistrationAnalysis();
            Assert.AreEqual(false, useranalysis.passwordHaveAtLeastOneNumber_Analysis("Vishalwamaka"));
        }

        [Test]
        public void givenPassword_whenHaveAtLeastOneSpecial_shouldReturnTrue()
        {
            UserRegistrationAnalysis useranalysis = new UserRegistrationAnalysis();
            Assert.AreEqual(true, useranalysis.passwordHaveAtLeastOneSpecial_Analysis("rahul@987"));
        }

        [Test]
        public void givenPassword_whenNotHaveAtLeastOneSpecial_shouldReturnFalse()
        {
            UserRegistrationAnalysis useranalysis = new UserRegistrationAnalysis();
            Assert.AreEqual(false, useranalysis.passwordHaveAtLeastOneSpecial_Analysis("rahul987"));
        }

        [Test]
        public void givenEmail_whenHaveAll_shouldReturnTrue()
        {
            UserRegistrationAnalysis useranalysis = new UserRegistrationAnalysis();
            Assert.AreEqual(true, useranalysis.EmailA_Analysis("vishalpwaman1997@gmail.com"));
        }

    }
}