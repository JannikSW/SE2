using InventoryManagementSystem.Layer_3;

namespace InventoryManagementSystem.Layer_2
{
    internal class StorageManager : IManager
    {
        internal List<IInventoryElement> storageInventory;

        internal StorageManager()
        {
            this.storageInventory = new List<IInventoryElement>();
        }

        void IManager.addElement(IInventoryElement storageElement)
        {
            this.storageInventory.Add(storageElement);
        }

        void IManager.deleteElement(IInventoryElement storageElement)
        {
            this.storageInventory.Remove(storageElement);
        }

        string IManager.infoElement(IInventoryElement storageElement)
        {
            return string.Format("{0}", storageElement.getElementInfo());
        }

        string IManager.infoShortElement(IInventoryElement storageElement)
        {
            return string.Format("{0}", storageElement.getElementShortInfo());
        }
    }
}
