using InventoryManagementSystem.Layer_3;

namespace InventoryManagementSystem.Layer_2
{
    internal class ProductManager : IManager
    {
        internal List<IInventoryElement> productInventory;

        internal ProductManager()
        {
            this.productInventory = new List<IInventoryElement>();
        }

        void IManager.addElement(IInventoryElement productElement)
        {
            this.productInventory.Add(productElement);
        }

        void IManager.deleteElement(IInventoryElement productElement)
        {
            this.productInventory.Remove(productElement);
        }

        string IManager.infoElement(IInventoryElement productElement)
        {
            return string.Format("{0}", productElement.getElementInfo());
        }

        string IManager.infoShortElement(IInventoryElement productElement)
        {
            return string.Format("{0}", productElement.getElementShortInfo());
        }
    }
}
