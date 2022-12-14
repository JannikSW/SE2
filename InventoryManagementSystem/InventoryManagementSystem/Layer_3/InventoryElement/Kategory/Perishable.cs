namespace InventoryManagementSystem.Layer_3
{
    public class Perishable : Kategory
    {
        private int durability;

        public Perishable(string nameProductkategory, Temperature storageTemperatureProductkategory, int durabilityProductkategory)
        {
            this.name               = nameProductkategory;
            this.storageTemperature = storageTemperatureProductkategory;
            this.durability         = durabilityProductkategory;
        }

        override protected string getKategoryInfo()
        {
            return string.Format("{0} {1} {2}", this.name, this.storageTemperature.infoString(), this.durability.ToString());
        }
    }
}
