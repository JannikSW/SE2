using InventoryManagementSystem.Layer_3;

namespace InventoryManagementSystem.Layer_2
{
    internal class KategoryManager : IManager
    {
        internal List<Kategory> kategoryInventory;

        internal KategoryManager()
        {
            this.kategoryInventory = new List<Kategory>();
        }

        void IManager.addElement(IInventoryElement kategoryElement)
        {
           // Kategory kategory = new Kategory(kategoryElement);
           // this.kategoryInventory.Add(kategory);
        }

        void IManager.deleteElement(IInventoryElement kategoryElement)
        {
           // this.kategoryInventory.Remove(kategoryElement);
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
