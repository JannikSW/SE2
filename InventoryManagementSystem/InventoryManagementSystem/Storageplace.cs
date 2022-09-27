namespace InventoryManagementSystem
{
    class Storageplace
    {
        string description;
        int capacity;
        Temperature degreeOfCold;

        public Storageplace(string storageName, int storageCapacity, Temperature storageTemperature)
        {
            this.description = storageName;
            this.capacity = storageCapacity;
            this.degreeOfCold = storageTemperature;
        }
        public string infoSmallString()
        {
            return this.description;
        }

        public string infoString()
        {
            return this.description + this.capacity.ToString() + this.degreeOfCold.coldnessString();
        }
    }
}
