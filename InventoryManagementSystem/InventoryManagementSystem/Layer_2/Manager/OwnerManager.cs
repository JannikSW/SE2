using InventoryManagementSystem.Layer_3;

namespace InventoryManagementSystem.Layer_2
{
    internal class OwnerManager : IManager
    {
        List<IInventoryElement> ownerList;

        internal OwnerManager()
        {
            this.ownerList = new List<IInventoryElement>();
        }

        void IManager.addElement(string[] ownerElement)
        {
            IInventoryElement owner = new Owner(ownerElement[0]);
            ownerList.Add(owner);
        }

        void IManager.deleteElement(string ownerName)
        {
            foreach (IInventoryElement owner in this.ownerList)
            {
                if (owner.getElementShortInfo() == ownerName)
                {
                    this.ownerList.Remove(owner);
                    break;
                }
            }
        }

        string[] IManager.infoElement()
        {
            string[] result = new string[ownerList.Count];
            int i = 0;
            
            foreach (IInventoryElement owner in ownerList)
            {
                result[i] = owner.getElementInfo();
                i++;
            }
            return result;
        }

        string[] IManager.infoShortElement()
        {
            string[] result = new string[ownerList.Count];
            int i = 0;

            foreach (IInventoryElement owner in ownerList)
            {
                result[i] = owner.getElementShortInfo();
                i++;
            }
            return result;
        }
    }
}
