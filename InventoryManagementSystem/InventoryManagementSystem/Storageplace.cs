namespace InventoryManagementSystem
{
    class Storageplace
    {
        public string name;
        protected int capacity;
        protected Temperature degreeOfCold;

        public Storageplace(string storageName, int storageCapacity, Temperature storageTemperature)
        {
            this.name = storageName;
            this.capacity = storageCapacity;
            this.degreeOfCold = storageTemperature;
        }

        public string infoString()
        {
            return this.name + this.capacity.ToString() + this.degreeOfCold.coldnessString();
        }
    }
}
