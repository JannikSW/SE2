using InventoryManagementSystem.Layer_2;

namespace InventoryManagementSystem.Layer_1
{
    internal interface IConverter
    {
        internal void addProduct();

        internal void addKategory();

        internal void addStorage();

        internal void addOwner(string ownerInformation);
    }
}
