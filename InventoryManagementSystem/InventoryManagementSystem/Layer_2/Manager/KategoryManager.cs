using InventoryManagementSystem.Layer_3;

namespace InventoryManagementSystem.Layer_2
{
    internal class KategoryManager : IManager
    {
        internal List<IInventoryElement> kategoryInventory;

        internal KategoryManager()
        {
            this.kategoryInventory = new List<IInventoryElement>();
        }

        void IManager.addElement(IInventoryElement kategoryElement)
        {
            this.kategoryInventory.Add(kategoryElement);
        }

        void IManager.deleteElement(IInventoryElement kategoryElement)
        {
            this.kategoryInventory.Remove(kategoryElement);
        }

        string IManager.infoElement(IInventoryElement kategoryElement)
        {
            return string.Format("{0}", kategoryElement.getElementInfo());
        }

        string IManager.infoShortElement(IInventoryElement kategoryElement)
        {
            return string.Format("{0}", kategoryElement.getElementShortInfo());
        }
    }
}
