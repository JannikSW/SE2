using InventoryManagementSystem.Layer_3;

namespace InventoryManagementSystem.Layer_2
{
    internal interface IManager
    {
        internal void addElement(string[] element);

        internal void deleteElement(string[] element);

        internal string infoElement(string[] element);

        internal string infoShortElement(string[] element);
    }
}
