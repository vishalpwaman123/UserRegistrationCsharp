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
    }
}