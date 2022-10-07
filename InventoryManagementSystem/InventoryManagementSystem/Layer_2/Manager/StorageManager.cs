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

            storageTemperature = this.stringToTemperature(storageElement[1]);

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

        private Temperature stringToTemperature(string input)
        {
            Temperature result;

            int indexOfMinus = input.IndexOf(" - ");
            int indexOfLastSpace = input.IndexOf(' ', indexOfMinus + 3);
            int minTemperature = int.Parse(input.Substring(0, indexOfMinus));
            int maxTemperature = int.Parse(input.Substring(indexOfMinus + 3, indexOfLastSpace - indexOfMinus - 3));
            string unitTemperature = input.Substring(indexOfLastSpace + 1, input.Length - 1 - indexOfLastSpace);

            result = new Temperature(unitTemperature, minTemperature, maxTemperature);

            return result;
        }
    }
}
