﻿using InventoryManagementSystem.Layer_3;

namespace InventoryManagementSystem.Layer_2
{
    internal class StorageManager : IManager
    {
        List<Storage> storageList;

        internal StorageManager()
        {
            this.storageList = new List<Storage>();
        }

        void IManager.executeOrder(string order, string[] element)
        {
            throw new NotImplementedException();
        }

        void IManager.addElement(string[] storageElement)
        {
            throw new NotImplementedException();
        }

        void IManager.deleteElement(string[] storageElement)
        {
            throw new NotImplementedException();
        }

        string IManager.infoElement(string[] storageElement)
        {
            throw new NotImplementedException();
        }

        string IManager.infoShortElement(string[] storageElement)
        {
            throw new NotImplementedException();
        }
    }
}