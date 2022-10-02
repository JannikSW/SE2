namespace InventoryManagementSystem.Layer_3
{
    internal class Celsius : Temperature
    {
        internal Celsius(int minTemperature, int maxTemperature)
        {
            unit = "°C";
            min = minTemperature;
            max = maxTemperature;
        }
    }
}
