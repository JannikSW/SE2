namespace InventoryManagementSystem
{
    class Storage
    {
        string description;
        int capacity;
        Temperature degreeOfCold;

        public Storage(string storageName, int storageCapacity, Temperature storageTemperature)
        {
            this.description = storageName;
            this.capacity = storageCapacity;
            this.degreeOfCold = storageTemperature;
        }

        public string infoString()
        {
            return this.description + this.capacity.ToString() + this.degreeOfCold.coldnessString();
        }
    }
}
