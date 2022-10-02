namespace InventoryManagementSystem.Layer_3
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
            name = nameProduct;
            price = prductPrice;
            storagedate = storagedateProduct;
            productkategory = productkategoryProduct;
            storageplace = storageplaceProduct;
            owner = ownerProduct;
        }

        internal string infoString()
        {
            return string.Format("{0} {1} {2} {3} {4} {5}", name, price.infoString(), storagedate.ToString("MM/dd/yyyy"), productkategory, storageplace, owner);
        }


    }
}
