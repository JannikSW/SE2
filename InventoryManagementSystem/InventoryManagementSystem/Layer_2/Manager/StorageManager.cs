using InventoryManagementSystem.Layer_3;

namespace InventoryManagementSystem.Layer_2
{
    class StorageManager : IManager
    {
        List<IInventoryElement> storageList;

        internal StorageManager(List<IInventoryElement> storageList)
        {
            this.storageList = storageList;
        }

        void IManager.addElement(string[] storageElement)
        {
            IInventoryElement storage;
            Temperature storageTemperature;

            storageTemperature = new Temperature(storageElement[1]);

            storage = new Storage(storageElement[0], storageTemperature);
            
            this.storageList.Add(storage);
        }

        void IManager.deleteElement(string storageName)
        {
            foreach (IInventoryElement storage in this.storageList)
            {
                if (storage.getElementShortInfo() == storageName)
                {
                    this.storageList.Remove(storage);
                    break;
                }
            }
        }

        string[] IManager.infoElement()
        {
            string[] result = new string[storageList.Count];
            int i = 0;

            foreach (IInventoryElement storage in storageList)
            {
                result[i] = storage.getElementInfo();
                i++;
            }
            return result;
        }

        string[] IManager.infoShortElement()
        {
            string[] result = new string[storageList.Count];
            int i = 0;

            foreach (IInventoryElement storage in storageList)
            {
                result[i] = storage.getElementShortInfo();
                i++;
            }
            return result;
        }
    }
}
