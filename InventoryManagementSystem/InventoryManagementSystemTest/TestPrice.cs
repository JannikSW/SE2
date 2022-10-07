using InventoryManagementSystem.Layer_3;
using System.Numerics;
using Xunit.Sdk;

namespace InventoryManagementSystemTest
{
    public class TestPrice
    {
        [Fact]
        public void Price_IsCorrect()
        {
            // Given
            string priceString = "855.65";

            // When
            Price price = new Price(priceString);
            string result = price.infoString();

            // Then
            Assert.Equal(priceString, result);
        }

        [Fact]
        public void Price_IsCorrectDecimal()
        {
            // Given
            string priceString = "65.99";

            // When
            Price price = new Price(priceString);
            string result = price.infoString();

            // Then
            Assert.Equal(priceString, result);
        }

        [Fact]
        public void Price_IsReadableFalseFormatted()
        {
            // Given
            string priceString = "23.85 Euro";
            string priceExpected = "23.85";

            // When
            Price price = new Price(priceString);
            string result = price.infoString();

            // Then
            Assert.Equal(priceExpected, result);
        }

        [Fact]
        public void Price_IsNonReadableFalseFormatted()
        {
            // Given
            string priceString = "23 Euro 85";

            // Then
            Assert.Throws<PriceException>(() => new Price(priceString));
        }


        [Fact]
        public void Price_HasFalseAttributeFormat()
        {
            // Given
            string priceString = "12.xx";

            // Then
            Assert.Throws<PriceException>(() => new Price(priceString));
        }
    }
}