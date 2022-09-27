namespace InventoryManagementSystem
{
    class Product
    {
        string name;
        double price;
        Productkategory productkategory;
        Temperature temperature;

        public Product(string productname, double productprice, Productkategory productkategory, Temperature storageTemperature)
        {
            this.name = productname;
            this.price = productprice;
            this.productkategory = productkategory;
            this.temperature = storageTemperature;
        }

        public string infoString()
        {
            return this.name + this.price.ToString() + this.productkategory.infoSmallString() + this.productkategory.infoSmallString();
        }
    }
}
