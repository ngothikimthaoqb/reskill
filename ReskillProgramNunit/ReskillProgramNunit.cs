using ReskillProgram;
using ReskillProgram.Lesson1;
using System.Net.WebSockets;

namespace ReskillProgramNunit
{
    public class ReskillProgramNunit
    {

        [Test]
        public void MaxUnequalConsecutiveCharacters()
        {
            // Arrange 
            var maxRepeating = new MaxUnrepeating();

            // Action
            string input = "characterrepeat";
            int maxExpected = 4;
            int maxActual =  maxRepeating.MaxUnequalConsecutiveCharacters(input);

            // Assert
            Assert.AreEqual(maxExpected, maxActual);
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
            Assert.AreEqual(maxExpected, maxActual);
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
            Assert.AreEqual(maxExpected, maxActual);
        }
    }
}