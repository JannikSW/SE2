namespace InventoryManagementSystem
{
    class Productkategory
    {
        string name;
        Temperature temperature;
        bool perishable;
        int duration;

        public Productkategory(string name, Temperature temperature, int durability)
        {
            this.name = name;
            this.temperature = temperature; 

            if (durability >= 0)
            {
                this.perishable = true;
                this.duration = durability;
            }
            else
            {
                this.perishable = false;
                this.duration = 0;
            }
        }

        public string infoSmallString()
        {
            return this.name;
        }

        public string infoString()
        {
            return this.name + this.temperature.coldnessString() + this.duration.ToString();
        }
    }
}
