namespace InventoryManagementSystem
{
    class Fridge : Storage
    {
        public Fridge(int storageCapacity)
        {
            this.degreeOfCold = Temperature.chilled;
            this.capacity = storageCapacity;
        }
    }
}
