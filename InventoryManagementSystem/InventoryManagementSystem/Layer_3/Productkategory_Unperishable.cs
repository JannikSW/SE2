namespace InventoryManagementSystem.Layer_3
{
    internal class Unperishable : Productkategory
    {
        internal Unperishable(string nameProductkategory, Temperature storageTemperatureProductkategory)
        {
            name = nameProductkategory;
            storageTemperature = storageTemperatureProductkategory;
        }
    }
}
