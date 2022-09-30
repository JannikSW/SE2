namespace InventoryManagementSystem
{
    internal class Storageplace
    {
        protected string name = "";
        protected int capacity = 0;
        protected Temperature temperature;

        internal Storageplace(string nameStorage, int capacityStorage, Temperature temperatureStorage)
        {
            this.name = nameStorage;
            this.capacity = capacityStorage;
            this.temperature = temperatureStorage;
        }

        internal string infoSmallString()
        {
            return this.name;
        }

        internal string infoString()
        {
            return String.Format("{0} {1} {2}", this.name, this.capacity.ToString(), this.temperature.infoString());
        }
    }
}
