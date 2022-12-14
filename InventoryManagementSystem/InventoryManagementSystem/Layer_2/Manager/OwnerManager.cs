using InventoryManagementSystem.Layer_3;

namespace InventoryManagementSystem.Layer_2
{
    public class OwnerManager : IManager
    {
        List<IInventoryElement> ownerList;

        public OwnerManager(List<IInventoryElement> ownerList)
        {
            this.ownerList = ownerList;
        }

        void IManager.addElement(string[] ownerElement)
        {
            IInventoryElement owner = new Owner(ownerElement[0]);
            this.ownerList.Add(owner);
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
