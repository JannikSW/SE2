using InventoryManagementSystem.Layer_3;

namespace InventoryManagementSystem.Layer_2
{
    internal class OwnerManager : IManager
    {
        internal List<IInventoryElement> ownerInventory;

        internal OwnerManager()
        {
            this.ownerInventory = new List<IInventoryElement>();
        }

        void IManager.addElement(IInventoryElement ownerElement)
        {
            this.ownerInventory.Add(ownerElement);
        }

        void IManager.deleteElement(IInventoryElement ownerElement)
        {
            this.ownerInventory.Remove(ownerElement);
        }

        string IManager.infoElement(IInventoryElement ownerElement)
        {
            return string.Format("{0}", ownerElement.getElementInfo());
        }

        string IManager.infoShortElement(IInventoryElement ownerElement)
        {
            return string.Format("{0}", ownerElement.getElementShortInfo());
        }
    }
}
