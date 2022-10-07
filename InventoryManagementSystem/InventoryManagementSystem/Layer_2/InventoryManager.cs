using InventoryManagementSystem.Layer_3;
using System.Linq.Expressions;
using static InventoryManagementSystem.Layer_2.IFormatter;

namespace InventoryManagementSystem.Layer_2
{
    internal class InventoryManager
    {
        IManager productManager;
        IManager kategoryManager;
        IManager storageManager;
        IManager ownerManager;

        List<IInventoryElement> productList;
        List<IInventoryElement> kategoryList;
        List<IInventoryElement> storageList;
        List<IInventoryElement> ownerList;

        internal InventoryManager()
        {
            this.productList  = new List<IInventoryElement>();
            this.kategoryList = new List<IInventoryElement>();
            this.storageList  = new List<IInventoryElement>();
            this.ownerList    = new List<IInventoryElement>();

            this.productManager  = new ProductManager(this.productList, this.kategoryList, this.storageList, this.ownerList);
            this.kategoryManager = new KategoryManager(this.kategoryList);
            this.storageManager  = new StorageManager(this.storageList);
            this.ownerManager    = new OwnerManager(this.ownerList);

        }

        internal void execute(string elementName, string elementOrder, string[] elementInfo)
        {
            this.executeOrder(elementName, elementOrder, elementInfo);
        }

        internal string[] request(IFormatter.elementInfo requestInfo)
        {                
            if (requestInfo.name == "Product")
            {
                if (requestInfo.length)
                {
                    return this.productManager.infoElement();
                }
                else
                {
                    return this.productManager.infoShortElement();
                }
            }

            if (requestInfo.name == "Kategory")
            {
                if (requestInfo.length)
                {
                    return this.kategoryManager.infoElement();
                }
                else
                {
                    return this.kategoryManager.infoShortElement();
                }
            }

            if (requestInfo.name == "Storage")
            {
                if (requestInfo.length)
                {
                    return this.storageManager.infoElement();
                }
                else
                {
                    return this.storageManager.infoShortElement();
                }
            }

            if (requestInfo.name == "Owner")
            {
                if (requestInfo.length)
                {
                    return this.ownerManager.infoElement();
                }
                else
                {
                    return this.ownerManager.infoShortElement();
                }
            }

            string[] emptyResult = new string[0];
            return emptyResult;
        }

        private void executeOrder(string elementName, string elementOrder, string[] elementInfo)
        {
            if (elementName == "Product")
            {
                this.executeOrderProduct(elementOrder, elementInfo);
            }
            if (elementName == "Kategory")
            {
                this.executeOrderKategory(elementOrder, elementInfo);
            }
            if (elementName == "Storage")
            {
                this.executeOrderStorage(elementOrder, elementInfo);
            }
            if (elementName == "Owner")
            {
                this.executeOrderOwner(elementOrder, elementInfo);
            }
        }

        private void executeOrderProduct(string elementOrder, string[] elementInfo)
        {
            if (elementOrder == "Add")
            {
                this.productManager.addElement(elementInfo);
            }
            if (elementOrder == "Del")
            {
                this.productManager.deleteElement(elementInfo[0]);
            }
        }

        private void executeOrderKategory(string elementOrder, string[] elementInfo)
        {
            if (elementOrder == "Add")
            {
                this.kategoryManager.addElement(elementInfo);
            }
            if (elementOrder == "Del")
            {
                this.kategoryManager.deleteElement(elementInfo[0]);
            }
        }

        private void executeOrderStorage(string elementOrder, string[] elementInfo)
        {
            if (elementOrder == "Add")
            {
                this.storageManager.addElement(elementInfo);
            }
            if (elementOrder == "Del")
            {
                this.storageManager.deleteElement(elementInfo[0]);
            }
        }

        private void executeOrderOwner(string elementOrder, string[] elementInfo)
        {
            if (elementOrder == "Add")
            {
                this.ownerManager.addElement(elementInfo);
            }
            if (elementOrder == "Del")
            {
                this.ownerManager.deleteElement(elementInfo[0]);
            }
        }
    }
}
