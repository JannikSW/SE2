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

        void IConverter.parseInfo(string elementSource, string elementName, string elemenAction, string elementInfo)
        {
            this.formatter.formatOrder(elementSource, elementName, elemenAction, elementInfo);
        }

        string[] IConverter.getInfo(string elementSource, string elementName, string elementLength)
        {
            return this.formatter.formatInfo(elementSource, elementName, elementLength);
        }
    }
}
