namespace InventoryManagementSystem
{
    abstract class Storage
    {
        Temperature degreeOfCold;
        int capacity;

        Storage(int storageTemperature, int storageCapacity)
        {
            this.degreeOfCold = new Temperature(storageTemperature);
            this.capacity = storageCapacity;
        }
    }
}
