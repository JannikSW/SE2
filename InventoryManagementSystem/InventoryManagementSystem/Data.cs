namespace InventoryManagementSystem
{
    abstract class Data
    {
        internal List<Product> dataProduct;
        internal List<Productkategory> dataProductkategory;
        internal List<Storageplace> dataStorageplace;
        internal List<Owner> dataOwner;

        protected string path = "";

        abstract protected void loadData();

        abstract protected void saveData();

        protected Price stringToPrice(string input)
        {
            Price output;

        

            output = new Price(5, 5);
            return output;
        }
    }
}
