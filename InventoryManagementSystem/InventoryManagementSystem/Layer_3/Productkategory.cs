namespace InventoryManagementSystem.Layer_3
{
    abstract internal class Productkategory
    {
        protected string name = "";
        protected Temperature storageTemperature;

        internal string infoSmallString()
        {
            return name;
        }

        virtual internal string infoString()
        {
            return string.Format("{0} {1}", name, storageTemperature.infoString());
        }
    }
}
