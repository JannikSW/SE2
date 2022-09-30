namespace InventoryManagementSystem
{
    class Product
    {
        protected string name = "";
        protected Price price;
        protected DateTime storagedate;
        protected Productkategory productkategory;
        protected Storageplace storageplace;
        protected Owner owner;

        internal Product(string nameProduct, Price prductPrice, DateTime storagedateProduct, Productkategory productkategoryProduct, Storageplace storageplaceProduct, Owner ownerProduct)
        {
            this.name = nameProduct;
            this.price = prductPrice;
            this.storagedate = storagedateProduct;
            this.productkategory = productkategoryProduct;
            this.storageplace = storageplaceProduct;
            this.owner = ownerProduct;
        }

        internal string infoString()
        {
            return this.name + " " + this.price.infoString() + " " + this.productkategory.infoString() + " " + storagedate.ToString("MM/dd/yyyy");
        }

        
    }
}
