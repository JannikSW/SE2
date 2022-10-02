using InventoryManagementSystem.Layer_3;

namespace InventoryManagementSystem.Layer_2
{
    internal class InventoryManager
    {
        ProductManager  productManager;
        KategoryManager kategoryManager;
        StorageManager  storageManager;
        OwnerManager    ownerManager;

        internal InventoryManager()
        {
            this.productManager  = new ProductManager();
            this.kategoryManager = new KategoryManager();
            this.storageManager  = new StorageManager();
            this.ownerManager    = new OwnerManager();
        }        
    }
}
