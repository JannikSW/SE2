namespace InventoryManagementSystem
{
    class Freezer : Storage
    {
        public Freezer(int storageCapacity)
        {
            this.degreeOfCold = Temperature.frozen;
            this.capacity = storageCapacity;
        }
    }
}
