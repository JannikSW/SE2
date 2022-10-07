namespace InventoryManagementSystem.Layer_3
{
    public class Temperature
    {
        protected string unit;
        protected int min;
        protected int max;

        public Temperature(string temperatureString)
        {
            try
            {
                int indexOfMinus = temperatureString.IndexOf(" - ");
                int indexOfLastSpace = temperatureString.IndexOf(' ', indexOfMinus + 3);
                int minTemperature = int.Parse(temperatureString.Substring(0, indexOfMinus));
                int maxTemperature = int.Parse(temperatureString.Substring(indexOfMinus + 3, indexOfLastSpace - indexOfMinus - 3));
                string unitTemperature = temperatureString.Substring(indexOfLastSpace + 1, temperatureString.Length - 1 - indexOfLastSpace);

                this.unit = unitTemperature;
                this.min = minTemperature;
                this.max = maxTemperature;
            }  
            catch (ArgumentOutOfRangeException e)
            {
                throw new TemperatureException(
                    "temperatureString is out of range", e);
            }
            catch (FormatException e)
            {
                throw new TemperatureException(
                    "temperatureString is not the correct format", e);
            }
        }

        public string infoString()
        {
            return string.Format("{0} - {1} {2}", min.ToString(), max.ToString(), unit);
        }
    }
}
