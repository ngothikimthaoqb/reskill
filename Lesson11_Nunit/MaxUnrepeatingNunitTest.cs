using ReskillProgram.Lesson1;

namespace Lesson11_Nunit
{
    public class MaxUnrepeatingNunitTest
    {

        [Test]
        public void MaxUnequalConsecutiveCharacters()
        {
            // Arrange 
            var maxRepeating = new MaxUnrepeating();

            // Action
            string input = "characterrepeat";
            int maxExpected = 4;
            int maxActual = maxRepeating.MaxUnequalConsecutiveCharacters(input);

            // Assert
            Assert.AreEqual(maxExpected, maxActual, "The maximum number of unequal consecutive characters is" + maxActual + "not equal to" + maxExpected);
        }

        [Test]
        public void MaximumConsecutiveDigits()
        {
            // Arrange 
            var maxRepeating = new MaxUnrepeating();

            // Action
            string input = "characterrepeat12345143678";
            int maxExpected = 8;
            int maxActual = maxRepeating.MaximumNumberConsecutiveIdenticalDigits(input);

            // Assert
            Assert.AreEqual(maxExpected, maxActual, "The maximum number of consecutive identical letters of the Latin alphabet is" + maxActual + "not equal to" + maxExpected);
        }

        [Test]
        public void MaximumConsecutiveLeters()
        {
            // Arrange 
            var maxRepeating = new MaxUnrepeating();

            // Action
            string input = "characterrepeat12";
            int maxExpected = 4;
            int maxActual = maxRepeating.MaximumNumberConsecutiveIdenticalLeters(input);

            // Assert
            Assert.AreEqual(maxExpected, maxActual, "The maximum number of consecutive identical digit is" + maxActual + "not equal to" + maxExpected);
        }
    }
}