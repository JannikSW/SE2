using InventoryManagementSystem.Layer_2;

namespace InventoryManagementSystem.Layer_1
{
    internal class guiFormatter : IFormatter
    {
        string[] IFormatter.formatInput(string guiInput)
        {
            return guiInput.Split(';');
        }
    }
}