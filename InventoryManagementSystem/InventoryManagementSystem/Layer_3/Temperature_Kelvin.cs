namespace InventoryManagementSystem.Layer_3
{
    internal class Kelvin : Temperature
    {
        internal Kelvin(int minTemperature, int maxTemperature)
        {
            unit = "K";
            min = minTemperature;
            max = maxTemperature;
        }
    }
}
