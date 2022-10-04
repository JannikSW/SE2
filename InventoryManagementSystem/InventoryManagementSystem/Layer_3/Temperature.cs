namespace InventoryManagementSystem.Layer_3
{
    internal class Temperature
    {
        protected string unit;
        protected int min;
        protected int max;

        internal Temperature(string unitTemperature, int minTemperature, int maxTemperature)
        {
            this.unit = unitTemperature;
            this.min = minTemperature;
            this.max = maxTemperature;
        }

        internal string infoString()
        {
            return string.Format("{0} - {1} {2}", min.ToString(), max.ToString(), unit);
        }
    }
}
