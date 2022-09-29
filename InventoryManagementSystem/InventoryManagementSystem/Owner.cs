namespace InventoryManagementSystem
{
    internal class Owner
    {
        protected string name;

        internal Owner(string name)
        {
            this.name = name;
        }

        internal string infoString()
        {
            return this.name;
        }
    }
}
