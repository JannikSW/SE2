namespace InventoryManagementSystem.Layer_3
{
    public class Product : IInventoryElement 
    {
        protected string   name;
        protected Price    price;
        protected DateTime storagedate;
        protected IInventoryElement kategory;
        protected IInventoryElement storage;
        protected IInventoryElement owner;

        public Product(string nameProduct, Price productPrice, DateTime storagedateProduct, IInventoryElement kategoryProduct, IInventoryElement storageProduct, IInventoryElement ownerProduct)
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
            return string.Format("{0} {1} {2} {3} {4} {5}", this.name, this.price.infoString(), this.storagedate.ToString("MM/dd/yyyy"), this.kategory.getElementShortInfo(), this.storage.getElementShortInfo(), this.owner.getElementShortInfo());
        }

        string IInventoryElement.getElementShortInfo()
        {
            return string.Format("Product: {0}", this.name);
        }
    }
}
