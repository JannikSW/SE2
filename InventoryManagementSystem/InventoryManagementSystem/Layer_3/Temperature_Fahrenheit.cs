namespace InventoryManagementSystem.Layer_3
{
    internal class Fahrenheit : Temperature
    {
        internal Fahrenheit(int minTemperature, int maxTemperature)
        {
            unit = "°F";
            min = minTemperature;
            max = maxTemperature;
        }
    }
}
