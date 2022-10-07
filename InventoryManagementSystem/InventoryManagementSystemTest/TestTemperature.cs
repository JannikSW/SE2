using InventoryManagementSystem.Layer_3;
using System.Numerics;
using Xunit.Sdk;

namespace InventoryManagementSystemTest
{
    public class TestTemperature
    {
        [Fact]
        public void Temperature_IsCorrect()
        {
            // Given
            string temperatureString = "-5 - 20 °C";

            // When
            Temperature temperature = new Temperature(temperatureString);
            string result = temperature.infoString();

            // Then
            Assert.Equal(temperatureString, result);
        }

        [Fact]
        public void Temperature_IsCorrectWithDifferenUnit()
        {
            // Given
            string temperatureString = "40 - 63 °F";

            // When
            Temperature temperature = new Temperature(temperatureString);
            string result = temperature.infoString();

            // Then
            Assert.Equal(temperatureString, result);
        }

        [Fact]
        public void Temperature_IsFalseFormatted()
        {
            // Given
            string temperatureString = "-5 °C - 20 °C";

            // Then
            Assert.Throws<TemperatureException>(() => new Temperature(temperatureString));
        }

        [Fact]
        public void Temperature_HasFalseAttributeFormat()
        {
            // Given
            string temperatureString = "-5c - 20c °C";

            // Then
            Assert.Throws<TemperatureException>(() => new Temperature(temperatureString));
        }
    }
}