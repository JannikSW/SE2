namespace InventoryManagementSystem.Layer_1
{
    internal interface IConverter
    {
        internal void parseInfo(string elementSource, string elementName, string elemenAction, string elementInfo);

        internal string[] getInfo(string elementSource, string elementName, string elementLength);
    }
}
