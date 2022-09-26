namespace InventoryManagementSystem
{
    class Food : Productkategory
    {
        int duration;

        public Food(int durability, Temperature storageTemperature)
        {
            this.name = "Food";
            this.storageTemperature = storageTemperature;
            this.duration = durability;
        }
    }
}
