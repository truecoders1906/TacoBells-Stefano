using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Theory]
        [InlineData("34.039588, -84.283254, Taco Bell Alpharetta / ... (Free trial * Add to Cart for a full POI info)")]
        [InlineData("34.018008,-86.079099,Taco Bell Attall... (Free trial * Add to Cart for a full POI info)")]
        [InlineData("90 , 180, Taco Bell")]
        [InlineData("-90, -180, Taco Bell ")]
        [InlineData("0, 0, Taco bell")]
        public void ShouldParse(string str)
        {
            // Arrange
            TacoParser location = new TacoParser();

            // Act
            ITrackable actual = location.Parse(str);

            // Assert
            Assert.NotNull(actual);
            Assert.NotNull(actual.Name);
            Assert.NotNull(actual.Location);

        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("90, 90")]
        [InlineData("90, TacoBell")]
        [InlineData("TacoBell")]
        public void ShouldFailParse(string str)
        {
            // Arrange
            TacoParser Location = new TacoParser();

            // Act
            ITrackable actual = Location.Parse(str);

            // Assert
            Assert.Null(actual);
        }
    }
}
