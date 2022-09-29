namespace InventoryManagementSystem
{
    internal class Kelvin : Temperature
    {
        internal Kelvin(int minTemperature, int maxTemperature)
        {
            this.unit = "K";
            this.min = minTemperature;
            this.max = maxTemperature;
        }
    }
}
