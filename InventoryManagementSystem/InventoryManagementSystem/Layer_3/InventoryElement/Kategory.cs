namespace InventoryManagementSystem.Layer_3
{
    abstract public class Kategory : IInventoryElement
    {
        protected string name;
        protected Temperature storageTemperature;

        string IInventoryElement.getElementInfo()
        {
            return this.getKategoryInfo();
        }

        string IInventoryElement.getElementShortInfo()
        {
            return string.Format("{0}", this.name);

        }
        protected virtual string getKategoryInfo()
        {
            return string.Format("{0} {1}", this.name, this.storageTemperature.infoString());
        }
    }
}
