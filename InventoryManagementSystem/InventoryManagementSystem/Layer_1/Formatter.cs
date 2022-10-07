using InventoryManagementSystem.Layer_2;

namespace InventoryManagementSystem.Layer_1
{
    public class Formatter
    {
        InventoryManager inventoryManager;

        public Formatter()
        {
            this.inventoryManager = new InventoryManager();
        }

        public void formatOrder(string elementSource, string elementName, string elementAction, string elementInfo)
        {
            IFormatter formatter;
            string[] formatInfo;

            formatter = this.selectFormatter(elementSource);
            formatInfo = formatter.formatInput(elementInfo);
            this.inventoryManager.execute(elementName, elementAction, formatInfo);
        }

        public string[] formatInfo(string elementSource, string elementName, string elementLength)
        {
            IFormatter formatter;

            formatter = this.selectFormatter(elementSource);

            return this.inventoryManager.request(formatter.formatrequest(elementName, elementLength));
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
