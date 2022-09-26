namespace InventoryManagementSystem
{
    class Food : Productkategory
    {
        int duration;

        public Food(int durability, Temperature temperature)
        {
            this.name = "Food";
            this.temperature = temperature;
            this.duration = durability;
        }
    }
}
