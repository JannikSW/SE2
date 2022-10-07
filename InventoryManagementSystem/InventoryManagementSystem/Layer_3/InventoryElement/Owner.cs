namespace InventoryManagementSystem.Layer_3
{
    public class Owner : IInventoryElement
    {
        protected string name;

        public Owner(string name)
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
