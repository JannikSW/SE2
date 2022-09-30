namespace InventoryManagementSystem
{
    class Product
    {
        protected string name;
        protected Price price;
        protected DateTime storagedate;
        protected string productkategory;
        protected string storageplace;
        protected string owner;

        internal Product(string nameProduct, Price prductPrice, DateTime storagedateProduct, string productkategoryProduct, string storageplaceProduct, string ownerProduct)
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
            return String.Format("{0} {1} {2} {3} {4} {5}", this.name, this.price.infoString(), this.storagedate.ToString("MM/dd/yyyy"), this.productkategory, this.storageplace, this.owner);
        }

        
    }
}
