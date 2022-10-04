namespace InventoryManagementSystem.Layer_3
{
    internal class Storage : IInventoryElement
    {
        protected string name;
        protected Temperature temperature;

        internal Storage(string nameStorage, Temperature temperatureStorage)
        {
            this.name        = nameStorage;
            this.temperature = temperatureStorage;
        }

        string IInventoryElement.getElementInfo()
        {
            return string.Format("{0} {1}", this.name, this.temperature.infoString());
        }

        string IInventoryElement.getElementShortInfo()
        {
            return string.Format("{0}", this.name);
        }
    }
}
