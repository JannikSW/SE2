namespace InventoryManagementSystem.Layer_3
{
    internal interface IManager
    { 
        internal void addElement(string[] element);

        internal void deleteElement(string name);

        internal string[] infoElement();

        internal string[] infoShortElement();
    }
}
