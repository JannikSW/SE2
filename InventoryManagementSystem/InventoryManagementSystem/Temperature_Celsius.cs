namespace InventoryManagementSystem
{
    internal class Celsius : Temperature
    {
        internal Celsius(int minTemperature, int maxTemperature)
        {
            this.unit = "°C";
            this.min = minTemperature;
            this.max = maxTemperature;
        }
    }
}
