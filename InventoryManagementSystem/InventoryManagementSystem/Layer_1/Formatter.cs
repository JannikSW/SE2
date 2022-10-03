using InventoryManagementSystem.Layer_2;

namespace InventoryManagementSystem.Layer_1
{
    internal class Formatter
    {
        InventoryManager inventoryManager;

        internal Formatter()
        {
            this.inventoryManager = new InventoryManager();
        }

        internal void formatOrder(string elementSource, string elementName, string elementAction, string elementInfo)
        {
            IFormatter formatter;
            string[] formatInfo;

            formatter = this.selectFormatter(elementSource);
            formatInfo = formatter.formatInput(elementInfo);
            this.inventoryManager.execute(elementName, elementAction, formatInfo);
        }

        private IFormatter selectFormatter(string elementSource)
        {
            if (elementSource == "Gui")
            {
                return new guiFormatter();
            }
            else
            {
                return new csvFormatter();
            }
        }
    }
}
