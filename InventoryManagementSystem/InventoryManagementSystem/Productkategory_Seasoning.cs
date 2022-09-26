namespace InventoryManagementSystem
{
    class Seasoning : Productkategory
    {

        public Seasoning(Temperature storageTemperature)
        {
            this.name = "Seasoning";
            this.storageTemperature = storageTemperature;
        }
    }
}
