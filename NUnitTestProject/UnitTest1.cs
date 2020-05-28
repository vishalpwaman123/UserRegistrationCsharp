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
        public void givenLastName_whenFirstLetterCapital_shouldReturnFalse()
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
        public void givenLastName_whenLetterMoreThree_shouldReturnFalse()
        {
            UserRegistrationAnalysis useranalysis = new UserRegistrationAnalysis();
            Assert.AreEqual(true, useranalysis.LastName_CapitalFirstLatter_Analysis("Wamankar"));
        }

        [Test]
        public void givenFirstName_whenLetterMoreThree_shouldReturnFalse()
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

    }
}