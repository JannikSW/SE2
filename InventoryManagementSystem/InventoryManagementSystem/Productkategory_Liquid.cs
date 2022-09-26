namespace InventoryManagementSystem
{
    class Liquid : Productkategory
    {
        int duration;

        public Liquid(int durability, Temperature storageTemperature)
        {
            this.name = "Liquid";
            this.storageTemperature = storageTemperature;
            this.duration = durability;
        }
    }
}
