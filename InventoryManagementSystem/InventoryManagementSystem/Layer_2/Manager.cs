namespace InventoryManagementSystem.Layer_2
{
    internal abstract class Manager
    {
        ProductManager         productManager;
        ProductkategoryManager productkategoryManager;
        StorageplaceManager    storageplaceManager;
        OwnerManager           ownerManager;

        abstract internal void addElement();

        abstract internal void deleteElement();
    }
}
