using NUnit.Framework;

namespace GovernmentSchemeBasedOnAge.UnitTest
{
    public class GovernmentSchemeBasedOnAgeTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("a", false)]
        [TestCase("!", false)]
        [TestCase("-10", false)]
        [TestCase("17", false)]
        [TestCase("18", true)]
        [TestCase("40", true)]
        [TestCase("41", false)]
        [TestCase("54", false)]
        [TestCase("55", true)]
        [TestCase("70", true)]
        [TestCase("71", false)]
        public void IsEligible(string age, bool expectedEligibility)
        {
            //Arrange
            EligibilityBasedOnAge eligibilityBasedOnAge = new EligibilityBasedOnAge();
            //Act
            bool isEligible = eligibilityBasedOnAge.IsEligible(age);
            //Assert
            Assert.That(isEligible == expectedEligibility);
        }
    }
}