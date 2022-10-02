namespace InventoryManagementSystem.Layer_3
{
    internal class Unperishable : Kategory
    {
        internal Unperishable(string nameProductkategory, Temperature storageTemperatureProductkategory)
        {
            this.name               = nameProductkategory;
            this.storageTemperature = storageTemperatureProductkategory;
        }
    }
}
