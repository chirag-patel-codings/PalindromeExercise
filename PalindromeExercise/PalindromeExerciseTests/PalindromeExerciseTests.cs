using System;
using Xunit;

namespace PalindromeExercise
{
    public class PalindromeExerciseTests
    {
        [Theory]
        [InlineData("Noon", true)]
        [InlineData("noon", true)]
        [InlineData("kayak", true)]
        [InlineData("Level", true)]
        [InlineData("Malayalam", true)]
        [InlineData("Eye", true)]
        [InlineData("123456654321", true)]
        [InlineData("78987", true)]
        [InlineData("  ", true)]
        [InlineData("Radar ", false)]
        [InlineData("OtherValue", false)]
        [InlineData("", false)]
        [InlineData(null, false)]
        public void IsAPalindromeTest(string palindromeValue, bool expected)
        {
            // Arrange
            WordSmith wordsmith = new WordSmith();

            // Act
            var actual = wordsmith.IsAPalindrome(palindromeValue);

            // Assert
            Assert.Equal(expected, actual);

        }
    }
}
