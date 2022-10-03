using InventoryManagementSystem.Layer_2;

namespace InventoryManagementSystem.Layer_1
{
    internal class csvFormatter : IFormatter
    {
        string[] IFormatter.formatInput(string csvInput)
        {
            return csvInput.Split(',');
        }
    }
}