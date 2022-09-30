namespace InventoryManagementSystem
{
    internal class Perishable : Productkategory
    {
        private int durability = 0;
        
        internal Perishable(string nameProductkategory, Temperature storageTemperatureProductkategory, int durabilityProductkategory)
        {
            this.name = nameProductkategory;
            this.storageTemperature = storageTemperatureProductkategory;
            this.durability = durabilityProductkategory;
        }

        override internal string infoString()
        {
            return String.Format("{0} {1} {2}", this.name, this.storageTemperature.infoString(), this.durability.ToString());
        }
    }
}
