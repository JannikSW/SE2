namespace InventoryManagementSystem.Layer_3
{
    public class Unperishable : Kategory
    {
        public Unperishable(string nameProductkategory, Temperature storageTemperatureProductkategory)
        {
            this.name               = nameProductkategory;
            this.storageTemperature = storageTemperatureProductkategory;
        }
    }
}
