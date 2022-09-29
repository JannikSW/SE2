namespace InventoryManagementSystem
{
    class Product
    {
        protected string name = "";
        protected Price price;
        protected Productkategory productkategory;
        protected DateTime storageDate;

        internal Product(string nameProduct, Price prductPrice, Productkategory productkategoryProduct, DateTime storageDateProduct)
        {
            this.name = nameProduct;
            this.price = prductPrice;
            this.productkategory = productkategoryProduct;
            this.storageDate = storageDateProduct;
        }

        internal string infoString()
        {
            return this.name + " " + this.price.toString() + " " + this.productkategory.infoString() + " " + storageDate.ToString("MM/dd/yyyy");
        }

        
    }
}
