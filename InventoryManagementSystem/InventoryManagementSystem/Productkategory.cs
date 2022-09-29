namespace InventoryManagementSystem
{
    abstract internal class Productkategory
    {
        protected string name = "";
        protected Temperature storageTemperature;

        internal string infoSmallString()
        {
            return this.name;
        }

        virtual internal string infoString()
        { 
            return this.name + " " + this.storageTemperature.infoString();
        }
    }
}
