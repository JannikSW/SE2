using InventoryManagementSystem.Layer_3;

namespace InventoryManagementSystem.Layer_2
{
    internal class OwnerManager : IManager
    {
        List<Owner> ownerList;

        internal OwnerManager()
        {
            this.ownerList = new List<Owner>();
        }

        void IManager.executeOrder(string order, string[] element)
        {
            throw new NotImplementedException();
        }

        void IManager.addElement(string[] ownerElement)
        {
            Owner owner = new Owner(ownerElement[2]);
            ownerList.Add(owner);
        }

        void IManager.deleteElement(string[] ownerElement)
        {
            throw new NotImplementedException();
        }

        string IManager.infoElement(string[] ownerElement)
        {
            throw new NotImplementedException();
        }

        string IManager.infoShortElement(string[] ownerElement)
        {
            throw new NotImplementedException();
        }
    }
}
