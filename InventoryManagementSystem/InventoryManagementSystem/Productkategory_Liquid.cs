namespace InventoryManagementSystem
{
    class Liquid : Productkategory
    {
        int duration;

        public Liquid(int durability, Temperature temperature)
        {
            this.name = "Liquid";
            this.temperature = temperature;
            this.duration = durability;
        }
    }
}
