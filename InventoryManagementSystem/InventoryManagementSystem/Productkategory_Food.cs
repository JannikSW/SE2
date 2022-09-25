namespace InventoryManagementSystem
{
    class Food : Productkategory
    {
        int duration;

        public Food(int durability)
        {
            this.name = "Food";
            this.duration = durability;
        }
    }
}
