namespace InventoryManagementSystem.Layer_3
{
    internal class Product : IInventoryElement 
    {
        protected string   name;
        protected Price    price;
        protected DateTime storagedate;
        protected Kategory kategory;
        protected Storage  storage;
        protected Owner    owner;

        internal Product(string nameProduct, Price productPrice, DateTime storagedateProduct, Kategory kategoryProduct, Storage storageProduct, Owner ownerProduct)
        {
            this.name        = nameProduct;
            this.price       = productPrice;
            this.storagedate = storagedateProduct;
            this.kategory    = kategoryProduct;
            this.storage     = storageProduct;
            this.owner       = ownerProduct;
        }

        string IInventoryElement.getElementInfo()
        {
            return string.Format("{0} {1} {2} {3} {4} {5}", this.name, this.price.infoString(), this.storagedate.ToString("MM/dd/yyyy"), this.kategory, this.storageplace, this.owner);
        }

        string IInventoryElement.getElementShortInfo()
        {
            return string.Format("Product: {0}", this.name);
        }
    }
}
