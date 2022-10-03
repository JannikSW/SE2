using InventoryManagementSystem.Layer_1;

namespace InventoryManagementSystem
{
    class GuiConverter : IConverter
    {
        Formatter formatter;

        internal GuiConverter()
        {
            this.formatter = new Formatter();
        }

        void IConverter.pareseInfo(string elementSource, string elementName, string elemenAction, string elementInfo)
        {
            this.formatter.formatOrder(elementSource, elementName, elemenAction, elementInfo);
        }
    }
}
