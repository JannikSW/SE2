using InventoryManagementSystem.Layer_3;

namespace InventoryManagementSystem.Layer_2
{
    internal class StorageManager : IManager
    {
        List<Storage> storageList;

        internal StorageManager()
        {
            this.storageList = new List<Storage>();
        }

        void IManager.addElement(string[] storageElement)
        {
            throw new NotImplementedException();
        }

        void IManager.deleteElement(string storageName)
        {
            throw new NotImplementedException();
        }

        string[] IManager.infoElement()
        {
            throw new NotImplementedException();
        }

        string[] IManager.infoShortElement()
        {
            throw new NotImplementedException();
        }
    }
}
