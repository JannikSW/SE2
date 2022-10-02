namespace InventoryManagementSystem.Layer_3
{
    internal class Perishable : Productkategory
    {
        private int durability = 0;

        internal Perishable(string nameProductkategory, Temperature storageTemperatureProductkategory, int durabilityProductkategory)
        {
            name = nameProductkategory;
            storageTemperature = storageTemperatureProductkategory;
            durability = durabilityProductkategory;
        }

        override internal string infoString()
        {
            return string.Format("{0} {1} {2}", name, storageTemperature.infoString(), durability.ToString());
        }
    }
}
