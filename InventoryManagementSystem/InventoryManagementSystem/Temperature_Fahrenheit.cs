namespace InventoryManagementSystem
{
    internal class Fahrenheit : Temperature
    {
        internal Fahrenheit(int minTemperature, int maxTemperature)
        {
            this.unit = "°F";
            this.min = minTemperature;
            this.max = maxTemperature;
        }
    }
}
