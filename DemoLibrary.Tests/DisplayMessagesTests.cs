using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

// Arrange, Act, Assert
// expected and actual
namespace DemoLibrary.Tests
{
    public class DisplayMessagesTests
    {
        [Fact]
        public void GreetingShouldReturnGoodMorningMessage()
        {
            // Arrange
            DisplayMessages messages = new DisplayMessages();
            var expected = "Go to bed viktor";

            // Act
            var actual = messages.Greeting("viktor", 2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GreetingShouldReturnGoodAfternoonMessage()
        {
            // Arrange
            DisplayMessages messages = new DisplayMessages();
            var expected = "Good afternoon viktor";

            // Act
            var actual = messages.Greeting("viktor",13);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("viktor", 0, "Go to bed viktor")]
        [InlineData("viktor", 1, "Go to bed viktor")]
        [InlineData("viktor", 2, "Go to bed viktor")]
        [InlineData("viktor", 3, "Go to bed viktor")]
        [InlineData("viktor", 4, "Go to bed viktor")]
        [InlineData("viktor", 5, "Good morning viktor")]
        [InlineData("viktor", 6, "Good morning viktor")]
        [InlineData("viktor", 7, "Good morning viktor")]
        [InlineData("viktor", 8, "Good morning viktor")]
        [InlineData("viktor", 9, "Good morning viktor")]
        [InlineData("viktor", 10, "Good morning viktor")]
        [InlineData("viktor", 11, "Good morning viktor")]
        [InlineData("viktor", 12, "Good afternoon viktor")]
        [InlineData("viktor", 13, "Good afternoon viktor")]
        [InlineData("viktor", 14, "Good afternoon viktor")]
        [InlineData("viktor", 15, "Good afternoon viktor")]
        [InlineData("viktor", 16, "Good afternoon viktor")]
        [InlineData("viktor", 17, "Good afternoon viktor")]
        [InlineData("viktor", 18, "Good evening viktor")]
        [InlineData("viktor", 19, "Good evening viktor")]
        [InlineData("viktor", 20, "Good evening viktor")]
        [InlineData("viktor", 21, "Good evening viktor")]
        [InlineData("viktor", 22, "Good evening viktor")]
        [InlineData("viktor", 23, "Good evening viktor")]
        public void GreetingShouldReturnExpectedValue(
            string firstName,
            int hourOfTheDay,
            string expected)
        {
            // Arrange
            DisplayMessages messages = new DisplayMessages();
            
            // Act
            string actual = messages.Greeting(firstName, hourOfTheDay);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
