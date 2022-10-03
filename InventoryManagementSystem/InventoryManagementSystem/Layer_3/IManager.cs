namespace InventoryManagementSystem.Layer_3
{
    internal interface IManager
    {
        internal void executeOrder(string order, string[] element);

        protected void addElement(string[] element);

        protected void deleteElement(string[] element);

        protected string infoElement(string[] element);

        protected string infoShortElement(string[] element);
    }
}
