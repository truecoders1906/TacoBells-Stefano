using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
            // TODO: Complete Something, if anything
        }

        [Theory]
        [InlineData("Example")]
        [InlineData(33.524131, -86.724876, Taco Bell Birmingham / ... (Free trial * Add to Cart for a full POI info))]
        [InlineData(30.445296, -87.240548, Taco Bell Pensacola / ... (Free trial * Add to Cart for a full POI info))]
        [InlineData(33.889469, -84.057706, Taco Bell Lawrenceville / ... (Free trial * Add to Cart for a full POI info))]
        [InlineData(32.364153, -86.269979, Taco Bell Montgomery / ... (Free trial * Add to Cart for a full POI info))]

        public void ShouldParse(string str)
        {
            // TODO: Complete Should Parse
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]

        public void ShouldFailParse(string str)
        {
            // Arrange
            ITrackable Parse = new ITrackable Parse();

            // Act
            string actual = Parse.ITrackable ParseGet(str);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}

// Arrange
Calculator Calc = new Calculator();

// Act
int actual = Calc.GetFactorial(number);

// Assert
Assert.Equal(expected, actual);
