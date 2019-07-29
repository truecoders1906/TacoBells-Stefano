using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Theory]
        [InlineData("34.039588, -84.283254, Taco Bell Alpharetta / ... (Free trial * Add to Cart for a full POI info)")]
        [InlineData("34.018008,-86.079099,Taco Bell Attall... (Free trial * Add to Cart for a full POI info)")]
        [InlineData("30.906033, -87.79328, Taco Bell Bay Minett... (Free trial * Add to Cart for a full POI info)")]
        [InlineData("33.470013,-86.816966,Taco Bell Birmingham/... (Free trial * Add to Cart for a full POI info)")]

        public void ShouldParse(string str)
        {
            // Arrange
            TacoParser location = new TacoParser();

            // Act
            ITrackable actual = location.Parse(str);

            // Assert
            Assert.NotNull(actual);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]

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
