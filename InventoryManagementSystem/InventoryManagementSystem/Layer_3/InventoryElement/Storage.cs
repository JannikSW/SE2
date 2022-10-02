namespace InventoryManagementSystem.Layer_3
{
    internal class Storage : IInventoryElement
    {
        protected string name;
        protected int capacity;
        protected Temperature temperature;

        protected Product[] products;

        internal Storage(string nameStorage, int capacityStorage, Temperature temperatureStorage)
        {
            this.name        = nameStorage;
            this.capacity    = capacityStorage;
            this.temperature = temperatureStorage;

            this.products    = new Product[capacityStorage];
        }

        string IInventoryElement.getElementInfo()
        {
            return string.Format("{0} {1} {2}", this.name, this.capacity.ToString(), this.temperature.infoString());
        }

        string IInventoryElement.getElementShortInfo()
        {
            return string.Format("{0}", this.name);
        }
    }
}
