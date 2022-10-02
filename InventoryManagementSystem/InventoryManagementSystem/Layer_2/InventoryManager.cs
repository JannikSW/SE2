using InventoryManagementSystem.Layer_3;

namespace InventoryManagementSystem.Layer_2
{
    internal class InventoryManager
    {

        internal List<Product>  productsInventory;
        internal List<Kategory> kategoryInventory;
        internal List<Storage>  storageInventory;
        internal List<Owner>    ownerInventory;

        ProductManager         productManager;
        ProductkategoryManager productkategoryManager;
        StorageplaceManager    storageplaceManager;
        OwnerManager           ownerManager;

        internal InventoryManager()
        {
            this.productManager         = new ProductManager();
            this.productkategoryManager = new ProductkategoryManager();
            this.storageplaceManager    = new StorageplaceManager();
            this.ownerManager           = new OwnerManager();

            this.productsInventory = new List<Product>();
            this.kategoryInventory = new List<Kategory>();
            this.storageInventory  = new List<Storage>();
            this.ownerInventory    = new List<Owner>();


        }

    }
}
