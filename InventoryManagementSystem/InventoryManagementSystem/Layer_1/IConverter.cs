namespace InventoryManagementSystem.Layer_1
{
    public interface IConverter
    {
        public void parseInfo(string elementSource, string elementName, string elemenAction, string elementInfo);

        public string[] getInfo(string elementSource, string elementName, string elementLength);
    }
}
