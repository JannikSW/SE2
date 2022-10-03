namespace InventoryManagementSystem.Layer_2
{
    internal interface IFormatter
    {
        internal record elementInfo
        {
            internal string name;
            internal bool length;
        }

        internal string[] formatInput(string input);

        internal elementInfo formatrequest(string elementName, string elementLenght);
    }
}
