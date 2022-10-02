using InventoryManagementSystem.Layer_3;

namespace InventoryManagementSystem.Layer_2
{
    internal class OwnerManager : IManager
    {
        internal List<Owner> ownerInventory;

        internal OwnerManager()
        {
            this.ownerInventory = new List<Owner>();
        }

        void IManager.addElement(string ownerElement)
        {
            this.ownerInventory.Add((Owner)ownerElement);
        }

        void IManager.deleteElement(IInventoryElement ownerElement)
        {
            this.ownerInventory.Remove((Owner)ownerElement);
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
