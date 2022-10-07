using InventoryManagementSystem.Layer_1;

namespace InventoryManagementSystem
{
    public class GuiConverter : IConverter
    {
        Formatter formatter;

        public GuiConverter(Formatter formatter)
        {
            this.formatter = formatter;
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
