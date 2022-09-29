namespace InventoryManagementSystem
{
    abstract internal class Productkategory
    {
        protected string name = "";
        protected Temperature storageTemperature;

        virtual internal string infoString()
        { 
            return this.name + " " + this.storageTemperature.infoString();
        }
    }
}
