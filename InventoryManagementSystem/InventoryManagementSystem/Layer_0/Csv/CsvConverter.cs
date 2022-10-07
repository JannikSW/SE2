using InventoryManagementSystem.Layer_1;

namespace InventoryManagementSystem
{
    public class CsvConverter : IConverter
    {
        Formatter formatter;

        public CsvConverter()
        {
            this.formatter = new Formatter();
        }

        void IConverter.parseInfo(string elementSource, string elementName, string elemenAction, string elementInfo)
        {
            throw new NotImplementedException();
        }

        string[] IConverter.getInfo(string elementSource, string elementName, string elementLength)
        {
            throw new NotImplementedException();
        }
    }
}
