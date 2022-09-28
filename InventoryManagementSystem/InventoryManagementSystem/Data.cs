namespace InventoryManagementSystem
{
    abstract class Data
    {
        protected List<Product> dataProduct;
        protected List<Productkategory> dataProductkategory;
        protected List<Storageplace> dataStorageplace;
        protected List<Owner> dataOwner;

        protected string path;

        abstract protected string loadData(string data);

        abstract protected void saveData(string data);
    }
}
