namespace InventoryManagementSystem.Layer_2
{
    public interface IFormatter
    {
        public record elementInfo
        {
            internal string name;
            internal bool length;
        }

        public string[] formatInput(string input);

        public elementInfo formatrequest(string elementName, string elementLenght);
    }
}
