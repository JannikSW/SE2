namespace InventoryManagementSystem.Layer_3
{
    internal class Owner : IInventoryElement
    {
        protected string name;

        internal Owner(string name)
        {
            this.name = name;
        }

        string IInventoryElement.getElementInfo()
        {
            return string.Format("{0}", this.name);
        }

        string IInventoryElement.getElementShortInfo()
        {
            return string.Format("{0}", this.name);
        }
    }
}
