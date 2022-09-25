namespace InventoryManagementSystem
{
    class Liquid : Productkategory
    {
        int duration;

        public Liquid(int durability)
        {
            this.name = "Liquid";
            this.duration = durability;
        }
    }
}
