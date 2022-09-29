namespace InventoryManagementSystem
{
    internal class Unperishable : Productkategory
    {
        internal Unperishable(string nameProductkategory, Temperature storageTemperatureProductkategory)
        {
            this.name = nameProductkategory;
            this.storageTemperature = storageTemperatureProductkategory;
        }
    }
}
