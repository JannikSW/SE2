namespace InventoryManagementSystem.Layer_3
{
    internal class Storageplace
    {
        protected string name = "";
        protected int capacity = 0;
        protected Temperature temperature;

        internal Storageplace(string nameStorage, int capacityStorage, Temperature temperatureStorage)
        {
            name = nameStorage;
            capacity = capacityStorage;
            temperature = temperatureStorage;
        }

        internal string infoSmallString()
        {
            return name;
        }

        internal string infoString()
        {
            return string.Format("{0} {1} {2}", name, capacity.ToString(), temperature.infoString());
        }
    }
}
