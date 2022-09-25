namespace InventoryManagementSystem
{
    class Shelf : Storage
    {
        public Shelf(int storageCapacity)
        {
            this.degreeOfCold = Temperature.room;
            this.capacity = storageCapacity;
        }
    }
}
