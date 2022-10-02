using InventoryManagementSystem.Layer_3;

namespace InventoryManagementSystem.Layer_2
{
    internal class OwnerManager : IManager
    {
        void IManager.addElement(IInventoryElement ownerElement)
        {
            throw new NotImplementedException();
        }

        void IManager.deleteElement(IInventoryElement ownerElement)
        {
        }

        string IManager.informationElement(IInventoryElement ownerElement)
        {
            throw new NotImplementedException();
        }
    }
}
