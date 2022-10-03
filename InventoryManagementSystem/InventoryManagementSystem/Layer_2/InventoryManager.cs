using InventoryManagementSystem.Layer_3;
using System.Linq.Expressions;

namespace InventoryManagementSystem.Layer_2
{
    internal class InventoryManager
    {
        IManager productManager;
        IManager kategoryManager;
        IManager storageManager;
        IManager ownerManager;

        internal InventoryManager()
        {
            this.productManager  = new ProductManager();
            this.kategoryManager = new KategoryManager();
            this.storageManager  = new StorageManager();
            this.ownerManager    = new OwnerManager();
        }

        internal void execute(string elementName, string elementOrder, string[] elementInfo)
        {
            this.selectManager(elementName, elementOrder, elementInfo);
        }


        private void selectManager(string elementName, string elementOrder, string[] elementInfo)
        {
            if (elementName == "Product")
            {
                this.productManager.executeOrder(elementOrder, elementInfo);
            }
            if (elementName == "Kategory")
            {
                this.kategoryManager.executeOrder(elementOrder, elementInfo);
            }
            if (elementName == "Storage")
            {
                this.storageManager.executeOrder(elementOrder, elementInfo);
            }
            else
            {
                this.ownerManager.executeOrder(elementOrder, elementInfo);
            }
        }
    }
}
